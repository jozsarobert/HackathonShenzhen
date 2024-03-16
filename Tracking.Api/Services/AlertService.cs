using AutoMapper;
using Tracking.Api.Dto;
using Tracking.Data.Repositories;

namespace Tracking.Api.Services
{
    public class AlertService : IAlertService
    {
        private readonly IAlertRepository _alertRepository;
        private readonly IMapper _mapper;

        public AlertService(IAlertRepository alertRepository, IMapper mapper)
        {
            _alertRepository = alertRepository;
            _mapper = mapper;
        }
        public AlertDto GetAlert(string alertId)
        {
            var result = _alertRepository.GetAlertById(alertId);
            return _mapper.Map<AlertDto>(result);
        }
    }
}
