using Azure;
using Reelables.Api.SDK.Api;

namespace Tracking.Api
{
    public class TrackingService : BackgroundService
    {
        private readonly ILogger<TrackingService> _logger;
        private readonly IAssetsApi _assetApi;

        public TrackingService(ILogger<TrackingService> logger, ReelablesApiConfig reelablesApiConfig)
        {
            _logger = logger;
            _logger.LogInformation($"Setting up reelables api client: {reelablesApiConfig.BasePath}");
            _assetApi = new AssetsApi(reelablesApiConfig.BasePath);
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
                        var response = await _assetApi.AssetsAssetIdGetWithHttpInfoAsync(assetId, Guid.NewGuid().ToString(),cancellationToken: stoppingToken);
                        _logger.LogInformation($"{response.Data.Id} - {response.Data.Label.NfcId}");

                    }
                }
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
