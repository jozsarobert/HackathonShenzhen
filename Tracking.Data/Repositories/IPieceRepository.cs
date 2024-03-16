using Tracking.Data.DomainModel;

namespace Tracking.Data.Repositories
{
    public interface IPieceRepository
    {
        public PieceModel GetPieceById(string id);

        public Task UpdateSensorData(string id, string serialNumber, double? temperature, double? elevation, double? latitude, double? longitude, DateTime timeStamp);
    }
}