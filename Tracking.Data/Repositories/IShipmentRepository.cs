using Tracking.Data.DomainModel;

namespace Tracking.Data.Repositories
{
    public interface IShipmentRepository
    {
        ShipmentModel GetShipmentById(int id);
        List<ShipmentModel> GetShipments();
    }
}