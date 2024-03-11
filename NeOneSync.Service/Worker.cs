using OneRecord.Api.SDK.Api;
using OneRecord.Api.SDK.Client;
using OneRecord.Api.SDK.Model;

namespace NeOneSync.Service
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }


        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                if (_logger.IsEnabled(LogLevel.Information))
                {
                    //_logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                }
                await Task.Delay(1000, stoppingToken);
            }
        }

        string GetIdFromResponse(ApiResponse<object> httpsResult)
        {
            var location = httpsResult.HttpsHeaders.TryGetValue("Location", out var value);

            var id = new Uri(value.First()).Segments.Last();

            return id;
        }
    }
}
