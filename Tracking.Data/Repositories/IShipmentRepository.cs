using Tracking.Data.DomainModel;

namespace Tracking.Data.Repositories
{
    public interface IShipmentRepository
    {
        public ShipmentModel GetShipmentById(int id);
    }
}