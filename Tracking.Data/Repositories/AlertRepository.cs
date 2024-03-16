using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracking.Data.DomainModel;

namespace Tracking.Data.Repositories
{
    public class AlertRepository : IAlertRepository
    {
        private readonly TrackingDbContext _dbContext;

        public AlertRepository(TrackingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public AlertModel GetAlertById(string id)
        {
            throw new NotImplementedException();
        }

        public List<AlertModel> GetAlerts()
        {
            throw new NotImplementedException();
        }
    }
}
