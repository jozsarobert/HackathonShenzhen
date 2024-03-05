using System.Net.Http.Json;

public static class TokenClient
{
    //static async Task Main(string[] args)
    //{
    //    string baseUri = "YOUR_KEYCLOAK_BASE_URL";
    //    string realm = "YOUR_REALM_NAME";
    //    string clientId = "YOUR_CLIENT_ID";
    //    string clientSecret = "YOUR_CLIENT_SECRET";

    //    string accessToken = await GetAccessToken(baseUri, realm, clientId, clientSecret);

    //    if (!string.IsNullOrEmpty(accessToken))
    //    {
    //        Console.WriteLine($"Access Token: {accessToken}");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Failed to obtain access token");
    //    }
    //}

    public static async Task<string> GetAccessToken(string baseUri, string realm, string clientId, string clientSecret)
    {
        using HttpClient client = new HttpClient();
        string tokenUrl = $"{baseUri}/realms/{realm}/protocol/openid-connect/token";

        var content = new FormUrlEncodedContent(new Dictionary<string, string>
        {
            { "grant_type", "client_credentials" },
            { "client_id", clientId },
            { "client_secret", clientSecret }
        });

        try
        {
            HttpResponseMessage response = await client.PostAsync(tokenUrl, content);

            if (response.IsSuccessStatusCode)
            {
                var tokenData = await response.Content.ReadFromJsonAsync<TokenResponse>();
                return tokenData.access_token;
            }
            else
            {
                Console.WriteLine($"Failed to get access token. Status code: {response.StatusCode}");
                return null;
            }
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"HTTP Request Exception: {e.Message}");
            return null;
        }
    }

    // Class to represent the token response
    public class TokenResponse
    {
        public string access_token { get; set; }
        // Add other properties if needed (e.g., expires_in, token_type, etc.)
    }
}
