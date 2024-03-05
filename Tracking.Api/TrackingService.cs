namespace Tracking.Api
{
    public class TrackingService : BackgroundService
    {
        private readonly ILogger<TrackingService> _logger;

        public TrackingService(ILogger<TrackingService> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                if (_logger.IsEnabled(LogLevel.Information))
                {
                    _logger.LogInformation("Tracking sevice polling for IOT device update: {time}", DateTimeOffset.Now);
                }
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
