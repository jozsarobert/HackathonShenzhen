using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracking.Data.DomainModel;

namespace Tracking.Data.Repositories
{
    public class FlightRepository : IFlightRepository
    {
        private readonly TrackingDbContext _dbContext;
        public FlightRepository(TrackingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public FlightModel GetFlightByDateAndFlightNo(DateTime date, string flightNo)
        {

            var flight = _dbContext.TransportMovement
                .Include(x => x.MovementTimes)
                .Include(x => x.LoadingActions).ThenInclude(x=>x.LoadedPieces).ThenInclude(x=>x.OfShipment)
                .Where(x => x.TransportIdentifier == flightNo && x.MovementTimes.Any(y => y.MovementTimestamp.Date.Date == date.Date && y.Direction == "OUTBOUND"))
                .Select(x => new
                {
                    x.Id,
                    x.ArrivalLocation,
                    x.DepartureLocation,
                    x.TransportIdentifier,
                    DepartureDateTime = x.MovementTimes.Where(y => y.Direction == "OUTBOUND").FirstOrDefault().MovementTimestamp,
                    ArrivalDateTime = x.MovementTimes.Where(y => y.Direction == "INBOUND").FirstOrDefault().MovementTimestamp,

                }).FirstOrDefault();

            var ids = _dbContext.Loading
                .Where(x=> x.ServedActivity.Id == flight.Id)
                .Include(x=>x.LoadedPieces)
                .ThenInclude(x=> x.OfShipment).Select(x=> x.Id).ToList();

            var shipmentList = _dbContext.Shipment.Where(x => ids.Contains(x.Id)).
                Select(x => new ShipmentModel
                {
                    Flights = null,
                    Id = x.Id,
                    WaybillNumber = x.Waybill.WaybillNumber,
                    PieceIds = x.Pieces.Select(y=> y.Id).ToList(),
                }).ToList();

            return new FlightModel
            {
                ArrivalDateTime = flight.ArrivalDateTime,
                DepartureDateTime = flight.DepartureDateTime,
                DestinationlCode = flight.ArrivalLocation.Code,
                FlightNo = flightNo,
                OriginCode = flight.DepartureLocation.Code,
                Shipments = shipmentList,
            };

        }
    }
}
