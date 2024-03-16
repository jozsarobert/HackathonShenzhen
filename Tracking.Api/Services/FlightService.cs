﻿using AutoMapper;
using Tracking.Api.Dto;
using Tracking.Data.Repositories;

namespace Tracking.Api.Services
{
    public class FlightService : IFlightService
    {
        private readonly IFlightRepository _flightRepository;
        private readonly IPieceRepository _pieceRepository;
        private readonly IMapper _mapper;

        public FlightService(IFlightRepository flightRepository, IMapper mapper, IPieceRepository pieceRepository)
        {
            _flightRepository = flightRepository;
            _mapper = mapper;
            _pieceRepository = pieceRepository;
        }
        public FlightDto GetFlightByDateAndFlightNo(DateTime date, string flightNo)
        {
            var result = _flightRepository.GetFlightByDateAndFlightNo(date, flightNo);

            var shipments = result.Shipments.Select(x => new { x.Id, x.Pieces });

            var shipmentPieceDictionary = new Dictionary<int, List<PieceDto>>();

            foreach (var shipment in shipments)
            {
                var pieceList = new List<PieceDto>();
                foreach (var item in shipment.Pieces)
                {
                    var piece = _pieceRepository.GetPieceById(item);
                    var pieceDto = _mapper.Map<PieceDto>(piece);
                    pieceList.Add(pieceDto);
                }
                shipmentPieceDictionary.Add(shipment.Id, pieceList);
            }

            var dto = _mapper.Map<FlightDto>(result);

            foreach (var shipment in dto.Shipments)
            {
                if (shipmentPieceDictionary.TryGetValue(shipment.Id, out var pieceDtos))
                {
                    shipment.Pieces = pieceDtos;
                }
            }

            return dto;
        }
    }
}
