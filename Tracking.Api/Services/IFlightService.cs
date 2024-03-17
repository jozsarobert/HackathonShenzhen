using Tracking.Api.Dto;

namespace Tracking.Api.Services
{
    public interface IFlightService
    {
        FlightDto GetFlightByDateAndFlightNo(DateTime date, string flightNo);
    }
}