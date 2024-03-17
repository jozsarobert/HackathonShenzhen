using Tracking.Data.DomainModel;

namespace Tracking.Data.Repositories
{
    public interface IPieceRepository
    {
        PieceModel GetPieceById(int id);
        List<PieceModel> GetPieceByShipmentId(int id);
        Task UpdateSensorData(int id, string serialNumber, double? temperature, double? elevation, double? latitude, double? longitude, DateTime timeStamp);
    }
}