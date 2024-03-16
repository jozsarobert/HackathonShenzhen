using Tracking.Api.Dto;

namespace Tracking.Api.Services
{
    public interface IPieceService
    {
        PieceDto GetPieceById(int id);
        List<PieceDto> GetPieceByShipmentId(int id);
    }
}
