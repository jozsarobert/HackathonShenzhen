using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracking.Data.DomainModel;

namespace Tracking.Data.Repositories
{
    public interface IFlightRepository
    {
        FlightModel GetFlightByDateAndFlightNo(DateTime date, string flightNo);
    }
}
