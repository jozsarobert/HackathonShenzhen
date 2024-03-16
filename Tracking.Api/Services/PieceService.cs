using AutoMapper;
using Tracking.Api.Dto;
using Tracking.Data.Repositories;

namespace Tracking.Api.Services
{
    public class PieceService : IPieceService
    {
        private readonly IPieceRepository _pieceRepository;
        private readonly IMapper _mapper;
        public PieceService(IPieceRepository pieceRepository, IMapper mapper)
        {
            _pieceRepository = pieceRepository;
            _mapper = mapper;
        }

        public PieceDto GetPieceById(int id)
        {
            var result = _pieceRepository.GetPieceById(id);
            return _mapper.Map<PieceDto>(result);

        }

        public List<PieceDto> GetPieceByShipmentId(int id)
        {
            var result = _pieceRepository.GetPieceByShipmentId(id);
            return _mapper.Map<List<PieceDto>>(result);

        }
    }
}
