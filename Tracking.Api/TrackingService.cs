using Reelables.Api.SDK.Api;

namespace Tracking.Api
{
    public class TrackingService : BackgroundService
    {
        private readonly ILogger<TrackingService> _logger;
        //private readonly IAssetsApi _assetApi;

        public TrackingService(ILogger<TrackingService> logger)
        {
            _logger = logger;
            //_assetApi = new AssetsApi("http://localhost");
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var assetIdList = new List<string>
            {
                "aaaa"
            };

            while (!stoppingToken.IsCancellationRequested)
            {
                if (_logger.IsEnabled(LogLevel.Information))
                {
                    _logger.LogInformation("Tracking sevice polling for IOT device update: {time}", DateTimeOffset.Now);

                    foreach (var assetId in assetIdList)
                    {
                        //await _assetApi.AssetsAssetIdGetWithHttpInfoAsync(assetId, cancellationToken: stoppingToken);
                    }
                }
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
