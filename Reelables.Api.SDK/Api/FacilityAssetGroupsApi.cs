using System;
using Reelables.Api.SDK.Client;
using Reelables.Api.SDK.Model;

namespace Reelables.Api.SDK.Api;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IFacilityAssetGroupsApiSync : IApiAccessor
{
    #region Synchronous Operations
    /// <summary>
    /// Get Asset Groups in a Facility
    /// </summary>
    /// <exception cref="Reelables.Api.SDK.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="facilityId">The identifier of the Facility</param>
    /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00 (optional)</param>
    /// <param name="limit">Number of Asset Groups to return. Default: 10. Maximum: 10000 (optional)</param>
    /// <param name="nextToken">Pagination token to get next page of Asset Groups (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>FacilityAssetGroups</returns>
    FacilityAssetGroups FacilitiesFacilityIdAssetGroupsGet(string facilityId, string? requestId = default(string?), string? limit = default(string?), string? nextToken = default(string?), int operationIndex = 0);

    /// <summary>
    /// Get Asset Groups in a Facility
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="Reelables.Api.SDK.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="facilityId">The identifier of the Facility</param>
    /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00 (optional)</param>
    /// <param name="limit">Number of Asset Groups to return. Default: 10. Maximum: 10000 (optional)</param>
    /// <param name="nextToken">Pagination token to get next page of Asset Groups (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of FacilityAssetGroups</returns>
    ApiResponse<FacilityAssetGroups> FacilitiesFacilityIdAssetGroupsGetWithHttpInfo(string facilityId, string? requestId = default(string?), string? limit = default(string?), string? nextToken = default(string?), int operationIndex = 0);
    #endregion Synchronous Operations
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IFacilityAssetGroupsApiAsync : IApiAccessor
{
    #region Asynchronous Operations
    /// <summary>
    /// Get Asset Groups in a Facility
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="Reelables.Api.SDK.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="facilityId">The identifier of the Facility</param>
    /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00 (optional)</param>
    /// <param name="limit">Number of Asset Groups to return. Default: 10. Maximum: 10000 (optional)</param>
    /// <param name="nextToken">Pagination token to get next page of Asset Groups (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of FacilityAssetGroups</returns>
    System.Threading.Tasks.Task<FacilityAssetGroups> FacilitiesFacilityIdAssetGroupsGetAsync(string facilityId, string? requestId = default(string?), string? limit = default(string?), string? nextToken = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    /// <summary>
    /// Get Asset Groups in a Facility
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="Reelables.Api.SDK.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="facilityId">The identifier of the Facility</param>
    /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00 (optional)</param>
    /// <param name="limit">Number of Asset Groups to return. Default: 10. Maximum: 10000 (optional)</param>
    /// <param name="nextToken">Pagination token to get next page of Asset Groups (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (FacilityAssetGroups)</returns>
    System.Threading.Tasks.Task<ApiResponse<FacilityAssetGroups>> FacilitiesFacilityIdAssetGroupsGetWithHttpInfoAsync(string facilityId, string? requestId = default(string?), string? limit = default(string?), string? nextToken = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    #endregion Asynchronous Operations
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IFacilityAssetGroupsApi : IFacilityAssetGroupsApiSync, IFacilityAssetGroupsApiAsync
{

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public class FacilityAssetGroupsApi : IFacilityAssetGroupsApi
{
    private Reelables.Api.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

    /// <summary>
    /// Initializes a new instance of the <see cref="FacilityAssetGroupsApi"/> class.
    /// </summary>
    /// <returns></returns>
    public FacilityAssetGroupsApi() : this((string)null)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FacilityAssetGroupsApi"/> class.
    /// </summary>
    /// <returns></returns>
    public FacilityAssetGroupsApi(string basePath)
    {
        this.Configuration = Reelables.Api.SDK.Client.Configuration.MergeConfigurations(
            Reelables.Api.SDK.Client.GlobalConfiguration.Instance,
            new Reelables.Api.SDK.Client.Configuration { BasePath = basePath }
        );
        this.Client = new Reelables.Api.SDK.Client.ApiClient(this.Configuration.BasePath);
        this.AsynchronousClient = new Reelables.Api.SDK.Client.ApiClient(this.Configuration.BasePath);
        this.ExceptionFactory = Reelables.Api.SDK.Client.Configuration.DefaultExceptionFactory;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FacilityAssetGroupsApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public FacilityAssetGroupsApi(Reelables.Api.SDK.Client.Configuration configuration)
    {
        if (configuration == null) throw new ArgumentNullException("configuration");

        this.Configuration = Reelables.Api.SDK.Client.Configuration.MergeConfigurations(
            Reelables.Api.SDK.Client.GlobalConfiguration.Instance,
            configuration
        );
        this.Client = new Reelables.Api.SDK.Client.ApiClient(this.Configuration.BasePath);
        this.AsynchronousClient = new Reelables.Api.SDK.Client.ApiClient(this.Configuration.BasePath);
        ExceptionFactory = Reelables.Api.SDK.Client.Configuration.DefaultExceptionFactory;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FacilityAssetGroupsApi"/> class
    /// using a Configuration object and client instance.
    /// </summary>
    /// <param name="client">The client interface for synchronous API access.</param>
    /// <param name="asyncClient">The client interface for asynchronous API access.</param>
    /// <param name="configuration">The configuration object.</param>
    public FacilityAssetGroupsApi(Reelables.Api.SDK.Client.ISynchronousClient client, Reelables.Api.SDK.Client.IAsynchronousClient asyncClient, Reelables.Api.SDK.Client.IReadableConfiguration configuration)
    {
        if (client == null) throw new ArgumentNullException("client");
        if (asyncClient == null) throw new ArgumentNullException("asyncClient");
        if (configuration == null) throw new ArgumentNullException("configuration");

        this.Client = client;
        this.AsynchronousClient = asyncClient;
        this.Configuration = configuration;
        this.ExceptionFactory = Reelables.Api.SDK.Client.Configuration.DefaultExceptionFactory;
    }

    /// <summary>
    /// The client for accessing this underlying API asynchronously.
    /// </summary>
    public Reelables.Api.SDK.Client.IAsynchronousClient AsynchronousClient { get; set; }

    /// <summary>
    /// The client for accessing this underlying API synchronously.
    /// </summary>
    public Reelables.Api.SDK.Client.ISynchronousClient Client { get; set; }

    /// <summary>
    /// Gets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public string GetBasePath()
    {
        return this.Configuration.BasePath;
    }

    /// <summary>
    /// Gets or sets the configuration object
    /// </summary>
    /// <value>An instance of the Configuration</value>
    public Reelables.Api.SDK.Client.IReadableConfiguration Configuration { get; set; }

    /// <summary>
    /// Provides a factory method hook for the creation of exceptions.
    /// </summary>
    public Reelables.Api.SDK.Client.ExceptionFactory ExceptionFactory
    {
        get
        {
            if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
            {
                throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
            }
            return _exceptionFactory;
        }
        set { _exceptionFactory = value; }
    }

    /// <summary>
    /// Get Asset Groups in a Facility 
    /// </summary>
    /// <exception cref="Reelables.Api.SDK.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="facilityId">The identifier of the Facility</param>
    /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00 (optional)</param>
    /// <param name="limit">Number of Asset Groups to return. Default: 10. Maximum: 10000 (optional)</param>
    /// <param name="nextToken">Pagination token to get next page of Asset Groups (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>FacilityAssetGroups</returns>
    public FacilityAssetGroups FacilitiesFacilityIdAssetGroupsGet(string facilityId, string? requestId = default(string?), string? limit = default(string?), string? nextToken = default(string?), int operationIndex = 0)
    {
        Reelables.Api.SDK.Client.ApiResponse<FacilityAssetGroups> localVarResponse = FacilitiesFacilityIdAssetGroupsGetWithHttpInfo(facilityId, requestId, limit, nextToken);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Asset Groups in a Facility 
    /// </summary>
    /// <exception cref="Reelables.Api.SDK.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="facilityId">The identifier of the Facility</param>
    /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00 (optional)</param>
    /// <param name="limit">Number of Asset Groups to return. Default: 10. Maximum: 10000 (optional)</param>
    /// <param name="nextToken">Pagination token to get next page of Asset Groups (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of FacilityAssetGroups</returns>
    public Reelables.Api.SDK.Client.ApiResponse<FacilityAssetGroups> FacilitiesFacilityIdAssetGroupsGetWithHttpInfo(string facilityId, string? requestId = default(string?), string? limit = default(string?), string? nextToken = default(string?), int operationIndex = 0)
    {
        // verify the required parameter 'facilityId' is set
        if (facilityId == null)
        {
            throw new Reelables.Api.SDK.Client.ApiException(400, "Missing required parameter 'facilityId' when calling FacilityAssetGroupsApi->FacilitiesFacilityIdAssetGroupsGet");
        }

        Reelables.Api.SDK.Client.RequestOptions localVarRequestOptions = new Reelables.Api.SDK.Client.RequestOptions();

        string[] _contentTypes = new string[] {
        };

        // to determine the Accept header
        string[] _accepts = new string[] {
            "application/json"
        };

        var localVarContentType = Reelables.Api.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
        if (localVarContentType != null)
        {
            localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
        }

        var localVarAccept = Reelables.Api.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
        if (localVarAccept != null)
        {
            localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
        }

        localVarRequestOptions.PathParameters.Add("facilityId", Reelables.Api.SDK.Client.ClientUtils.ParameterToString(facilityId)); // path parameter
        if (limit != null)
        {
            localVarRequestOptions.QueryParameters.Add(Reelables.Api.SDK.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
        }
        if (nextToken != null)
        {
            localVarRequestOptions.QueryParameters.Add(Reelables.Api.SDK.Client.ClientUtils.ParameterToMultiMap("", "nextToken", nextToken));
        }
        if (requestId != null)
        {
            localVarRequestOptions.HeaderParameters.Add("request-id", Reelables.Api.SDK.Client.ClientUtils.ParameterToString(requestId)); // header parameter
        }

        localVarRequestOptions.Operation = "FacilityAssetGroupsApi.FacilitiesFacilityIdAssetGroupsGet";
        localVarRequestOptions.OperationIndex = operationIndex;

        // authentication (AuthEndpoint) required
        // oauth required
        if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
        {
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                     !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                     !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                     this.Configuration.OAuthFlow != null)
            {
                localVarRequestOptions.OAuth = true;
            }
        }

        // make the HTTP request
        var localVarResponse = this.Client.Get<FacilityAssetGroups>("/facilities/{facilityId}/asset-groups", localVarRequestOptions, this.Configuration);
        if (this.ExceptionFactory != null)
        {
            Exception _exception = this.ExceptionFactory("FacilitiesFacilityIdAssetGroupsGet", localVarResponse);
            if (_exception != null)
            {
                throw _exception;
            }
        }

        return localVarResponse;
    }

    /// <summary>
    /// Get Asset Groups in a Facility 
    /// </summary>
    /// <exception cref="Reelables.Api.SDK.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="facilityId">The identifier of the Facility</param>
    /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00 (optional)</param>
    /// <param name="limit">Number of Asset Groups to return. Default: 10. Maximum: 10000 (optional)</param>
    /// <param name="nextToken">Pagination token to get next page of Asset Groups (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of FacilityAssetGroups</returns>
    public async System.Threading.Tasks.Task<FacilityAssetGroups> FacilitiesFacilityIdAssetGroupsGetAsync(string facilityId, string? requestId = default(string?), string? limit = default(string?), string? nextToken = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
    {
        Reelables.Api.SDK.Client.ApiResponse<FacilityAssetGroups> localVarResponse = await FacilitiesFacilityIdAssetGroupsGetWithHttpInfoAsync(facilityId, requestId, limit, nextToken, operationIndex, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Asset Groups in a Facility 
    /// </summary>
    /// <exception cref="Reelables.Api.SDK.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="facilityId">The identifier of the Facility</param>
    /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00 (optional)</param>
    /// <param name="limit">Number of Asset Groups to return. Default: 10. Maximum: 10000 (optional)</param>
    /// <param name="nextToken">Pagination token to get next page of Asset Groups (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (FacilityAssetGroups)</returns>
    public async System.Threading.Tasks.Task<Reelables.Api.SDK.Client.ApiResponse<FacilityAssetGroups>> FacilitiesFacilityIdAssetGroupsGetWithHttpInfoAsync(string facilityId, string? requestId = default(string?), string? limit = default(string?), string? nextToken = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
    {
        // verify the required parameter 'facilityId' is set
        if (facilityId == null)
        {
            throw new Reelables.Api.SDK.Client.ApiException(400, "Missing required parameter 'facilityId' when calling FacilityAssetGroupsApi->FacilitiesFacilityIdAssetGroupsGet");
        }


        Reelables.Api.SDK.Client.RequestOptions localVarRequestOptions = new Reelables.Api.SDK.Client.RequestOptions();

        string[] _contentTypes = new string[] {
        };

        // to determine the Accept header
        string[] _accepts = new string[] {
            "application/json"
        };

        var localVarContentType = Reelables.Api.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
        if (localVarContentType != null)
        {
            localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
        }

        var localVarAccept = Reelables.Api.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
        if (localVarAccept != null)
        {
            localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
        }

        localVarRequestOptions.PathParameters.Add("facilityId", Reelables.Api.SDK.Client.ClientUtils.ParameterToString(facilityId)); // path parameter
        if (limit != null)
        {
            localVarRequestOptions.QueryParameters.Add(Reelables.Api.SDK.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
        }
        if (nextToken != null)
        {
            localVarRequestOptions.QueryParameters.Add(Reelables.Api.SDK.Client.ClientUtils.ParameterToMultiMap("", "nextToken", nextToken));
        }
        if (requestId != null)
        {
            localVarRequestOptions.HeaderParameters.Add("request-id", Reelables.Api.SDK.Client.ClientUtils.ParameterToString(requestId)); // header parameter
        }

        localVarRequestOptions.Operation = "FacilityAssetGroupsApi.FacilitiesFacilityIdAssetGroupsGet";
        localVarRequestOptions.OperationIndex = operationIndex;

        // authentication (AuthEndpoint) required
        // oauth required
        if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
        {
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                     !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                     !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                     this.Configuration.OAuthFlow != null)
            {
                localVarRequestOptions.OAuth = true;
            }
        }

        // make the HTTP request
        var localVarResponse = await this.AsynchronousClient.GetAsync<FacilityAssetGroups>("/facilities/{facilityId}/asset-groups", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

        if (this.ExceptionFactory != null)
        {
            Exception _exception = this.ExceptionFactory("FacilitiesFacilityIdAssetGroupsGet", localVarResponse);
            if (_exception != null)
            {
                throw _exception;
            }
        }

        return localVarResponse;
    }

}