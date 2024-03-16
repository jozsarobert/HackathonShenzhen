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
        public ShipmentModel GetShipmentById(string id)
        {
            //var result = _dbContext.Shipment.Where(x => x.Id == id).Select(x => new ShipmentModel 
            //{
            // Id = x.Id,
            // DepartureDate = x. 
         
            //}).FirstOrDefault();

            //return result;

            throw new NotImplementedException();
        }
    }
}
