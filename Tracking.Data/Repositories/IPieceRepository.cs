using Tracking.Data.DomainModel;

namespace Tracking.Data.Repositories
{
    public interface IPieceRepository
    {
        public PieceModel GetPieceById(string id);
    }
}