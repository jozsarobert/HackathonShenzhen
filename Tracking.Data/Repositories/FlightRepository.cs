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
            //var flight = _dbContext.TransportMovement
            //    .Where(x=> x.TransportIdentifier ==  flightNo && x.MovementTimes.Any(y=> y.MovementTimestamp.Date == date && y.Direction == "OUTBOUND"))
            //    .Select(x=> new
            //    {
            //        x.ArrivalLocation,
            //        x.DepartureLocation,
            //        x.TransportIdentifier,
            //        x.Load
            //    });

            throw new NotImplementedException();
        }
    }
}
