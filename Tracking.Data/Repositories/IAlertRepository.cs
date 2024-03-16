using Tracking.Data.DomainModel;

namespace Tracking.Data.Repositories
{
    public interface IAlertRepository
    {
        public List<AlertModel> GetAlerts();
        public AlertModel GetAlertById(string id);
    }
}