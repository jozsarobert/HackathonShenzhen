using Tracking.Api.Dto;

namespace Tracking.Api.Services
{
    public interface IAlertService
    {
        public AlertDto GetAlert(string alertId);
    }
}
