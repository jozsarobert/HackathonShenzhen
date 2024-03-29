/*
 * Reelables API
 *
 * RESTful API for communicating with the Reelables Platform.
 *
 * The version of the OpenAPI document: 1.2.7
 * Contact: team@reelables.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Polly;
using RestSharp;

namespace Reelables.Api.SDK.Client;

/// <summary>
/// Configuration class to set the polly retry policies to be applied to the requests.
/// </summary>
public static class RetryConfiguration
{
    /// <summary>
    /// Retry policy
    /// </summary>
    public static Policy<RestResponse> RetryPolicy { get; set; }

    /// <summary>
    /// Async retry policy
    /// </summary>
    public static AsyncPolicy<RestResponse> AsyncRetryPolicy { get; set; }
}