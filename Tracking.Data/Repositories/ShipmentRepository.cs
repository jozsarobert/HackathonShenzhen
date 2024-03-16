using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracking.Data.DomainModel;

namespace Tracking.Data.Repositories
{
    public class ShipmentRepository : IShipmentRepository
    {
        public readonly TrackingDbContext _dbContext;
        public ShipmentRepository(TrackingDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ShipmentModel GetShipmentById(int id)
        {
            var result = _dbContext.Shipment.Where(x => x.Id == id)
                .Include(x=> x.Pieces)
                .Select(x => new ShipmentModel
                {
                    Id = x.Id,
                    WaybillNumber = x.Waybill.WaybillNumber,
                    HasAlert = false, // todo move to calculation logic
                    PieceIds = x.Pieces.Select(y => y.Id).ToList(),
                }).FirstOrDefault();

            var pieceIds = result.PieceIds;

            var flights = new List<FlightModel>();

            foreach (var pieceId in pieceIds) 
            {
                var movementId = _dbContext.Loading
                    .Include(x => x.LoadedPieces)
                    .Include(x => x.ServedActivity)
                    .Where(x => x.LoadedPieces.Select(x => x.Id).Contains(pieceId))
                    .Where(x => x.LoadingType == "LOADING")
                    .Select(x => x.ServedActivity.Id)
                    .FirstOrDefault();

                var flight = _dbContext.TransportMovement.Where(x => x.Id == movementId)
                    .Include(x => x.ArrivalLocation)
                    .Include(x => x.DepartureLocation)
                    .Include(x => x.MovementTimes)
                    .Select(x => new FlightModel
                    {
                        OriginCode = x.DepartureLocation.Code,
                        DestinationlCode = x.ArrivalLocation.Code,
                        FlightNo = x.TransportIdentifier,
                        DepartureDateTime = x.MovementTimes.Where(y => y.Direction == "OUTBOUND").FirstOrDefault().MovementTimestamp,
                        ArrivalDateTime = x.MovementTimes.Where(y => y.Direction == "INBOUND").FirstOrDefault().MovementTimestamp,

                    }).FirstOrDefault();
                flights.Add(flight);
            }

            result.Flights = flights;

            return result;
        }
    }
}
