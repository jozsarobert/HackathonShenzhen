using Tracking.Api.Dto;

namespace Tracking.Api.Services
{
    public interface IShipmentService
    {
        ShipmentDto GetShipmentById(int id);

        List<ShipmentDto> GetShipmentWithAlerts();
    }
}