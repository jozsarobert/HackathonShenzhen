using AutoMapper;
using Tracking.Api.Dto;
using Tracking.Data.Repositories;

namespace Tracking.Api.Services
{
    public class ShipmentService : IShipmentService
    {
        private readonly IShipmentRepository _shipmentRepository;
        private readonly IMapper _mapper;
        private readonly IPieceRepository _pieceRepository;

        public ShipmentService(IShipmentRepository shipmentRepository, IMapper mapper, IPieceRepository pieceRepository)
        {
            _shipmentRepository = shipmentRepository;
            _mapper = mapper;
            _pieceRepository = pieceRepository;
        }
        public ShipmentDto GetShipmentById(int id)
        {
            var result = _shipmentRepository.GetShipmentById(id);

            var shipmentDto = _mapper.Map<ShipmentDto>(result);

            var pieces = new List<PieceDto>();
            foreach (var pieceId in result.PieceIds)
            {
                var piece = _pieceRepository.GetPieceById(pieceId);
                var pieceDto = _mapper.Map<PieceDto>(piece);
                pieces.Add(pieceDto);
            }

            shipmentDto.Pieces = pieces;

            return shipmentDto;
        }
    }
}
