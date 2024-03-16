using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracking.Data.DomainModel;

namespace Tracking.Data.Repositories
{
    public class PieceRepository : IPieceRepository
    {
        private readonly TrackingDbContext _dbContext;

        public PieceRepository(TrackingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public PieceModel GetPieceById(string id)
        {
            var result = _dbContext.Piece.Where(x => x.Id == id).Select(x => new PieceModel
            {

            }).FirstOrDefault();

            return result;
        }

        public List<PieceModel> GetPieces()
        {
            var result = _dbContext.Piece.Select(x => new PieceModel { }).ToList();
            return result;
        }
    }
}
