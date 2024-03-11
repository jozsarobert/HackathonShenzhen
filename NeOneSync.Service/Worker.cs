using OneRecord.Api.SDK.Api;
using OneRecord.Api.SDK.Client;
using OneRecord.Api.SDK.Model;

namespace NeOneSync.Service
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly LogisticsObjectsApi _logisticsObjectsApi;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
            //var token = TokenClient.GetAccessToken(@"http://keycloak:8989", "neone", "neone-client",
            //    "lx7ThS5aYggdsMm42BP3wMrVqKm9WpNY").GetAwaiter().GetResult();

            //_logger.LogInformation(token);


            //Configuration config = new Configuration
            //{
            //    HttpsBasePath = "http://neone:8080",
            //    HttpsDefaultHeaders = new Dictionary<string, string>
            //    {
            //        { "Authorization", $"Bearer {token}" },
            //        { "Authentication", $"Bearer {token}" }
            //    },
            //    HttpsAccessToken = Guid.NewGuid().ToString()
            //};

            //_logisticsObjectsApi = new LogisticsObjectsApi(config);

           // var p = new Piece()
           // {
           //     Type = new List<string> { "cargo:Piece" },
           //     Coload = false,
                
           // };
            
           //var response = _logisticsObjectsApi.CreateLogisticsObjectWithHttpInfoAsync(p).GetAwaiter().GetResult();
           //_logger.LogInformation(GetIdFromResponse(response));

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
