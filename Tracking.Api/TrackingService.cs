using Azure;
using MassTransit;
using MessageContracts;
using Reelables.Api.SDK.Api;

namespace Tracking.Api
{
    public class TrackingService : BackgroundService
    {
        private readonly ILogger<TrackingService> _logger;
        private readonly IAssetsApi _assetApi;
        private readonly IBus _bus;
        public TrackingService(ILogger<TrackingService> logger, ReelablesApiConfig reelablesApiConfig, IBus bus)
        {
            _bus = bus;
            _logger = logger;
            _logger.LogInformation($"Setting up reelables api client: {reelablesApiConfig.BasePath}");
            _assetApi = new AssetsApi(reelablesApiConfig.BasePath);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var timestampDictionary = new Dictionary<string, DateTime>();

            var assetIdList = new List<string>
            {
                "aaaa"
            };

            while (!stoppingToken.IsCancellationRequested)
            {
                if (_logger.IsEnabled(LogLevel.Information))
                {
                    //_logger.LogInformation("Tracking sevice polling for IOT device update: {time}", DateTimeOffset.Now);

                    foreach (var assetId in assetIdList)
                    {
                        var response = await _assetApi.AssetsAssetIdGetWithHttpInfoAsync(assetId, Guid.NewGuid().ToString(), cancellationToken: stoppingToken);
                        
                        timestampDictionary.TryGetValue(assetId, out var lastTimeStamp);
                        //response.Data.Temperatures.Items


                        //await _bus.Publish(new TestMessage { Content = Guid.NewGuid().ToString() });
                        //_logger.LogInformation($"Message publlished at {DateTime.UtcNow}");
                    }
                }
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
