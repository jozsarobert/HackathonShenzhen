/*
 * Reelables API
 *
 * RESTful API for communicating with the Reelables Platform.
 *
 * The version of the OpenAPI document: 1.2.7
 * Contact: team@reelables.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using Reelables.Api.SDK.Client;
using Reelables.Api.SDK.Model;

namespace Reelables.Api.SDK.Api;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IWorkspaceFacilitiesApiSync : IApiAccessor
{
    #region Synchronous Operations
    /// <summary>
    /// List Facilities in a Workspace
    /// </summary>
    /// <exception cref="Reelables.Api.SDK.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="workspaceId">The identifier of the Workspace</param>
    /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00 (optional)</param>
    /// <param name="limit">Number of Facilities to return. Default: 10. Maximum: 10000 (optional)</param>
    /// <param name="nextToken">Pagination token to get next page of Facilities (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>WorkspaceFacilities</returns>
    WorkspaceFacilities WorkspacesWorkspaceIdFacilitiesGet(string workspaceId, string? requestId = default(string?), string? limit = default(string?), string? nextToken = default(string?), int operationIndex = 0);

    /// <summary>
    /// List Facilities in a Workspace
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="Reelables.Api.SDK.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="workspaceId">The identifier of the Workspace</param>
    /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00 (optional)</param>
    /// <param name="limit">Number of Facilities to return. Default: 10. Maximum: 10000 (optional)</param>
    /// <param name="nextToken">Pagination token to get next page of Facilities (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of WorkspaceFacilities</returns>
    ApiResponse<WorkspaceFacilities> WorkspacesWorkspaceIdFacilitiesGetWithHttpInfo(string workspaceId, string? requestId = default(string?), string? limit = default(string?), string? nextToken = default(string?), int operationIndex = 0);
    #endregion Synchronous Operations
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IWorkspaceFacilitiesApiAsync : IApiAccessor
{
    #region Asynchronous Operations
    /// <summary>
    /// List Facilities in a Workspace
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="Reelables.Api.SDK.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="workspaceId">The identifier of the Workspace</param>
    /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00 (optional)</param>
    /// <param name="limit">Number of Facilities to return. Default: 10. Maximum: 10000 (optional)</param>
    /// <param name="nextToken">Pagination token to get next page of Facilities (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of WorkspaceFacilities</returns>
    System.Threading.Tasks.Task<WorkspaceFacilities> WorkspacesWorkspaceIdFacilitiesGetAsync(string workspaceId, string? requestId = default(string?), string? limit = default(string?), string? nextToken = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    /// <summary>
    /// List Facilities in a Workspace
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="Reelables.Api.SDK.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="workspaceId">The identifier of the Workspace</param>
    /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00 (optional)</param>
    /// <param name="limit">Number of Facilities to return. Default: 10. Maximum: 10000 (optional)</param>
    /// <param name="nextToken">Pagination token to get next page of Facilities (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (WorkspaceFacilities)</returns>
    System.Threading.Tasks.Task<ApiResponse<WorkspaceFacilities>> WorkspacesWorkspaceIdFacilitiesGetWithHttpInfoAsync(string workspaceId, string? requestId = default(string?), string? limit = default(string?), string? nextToken = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    #endregion Asynchronous Operations
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IWorkspaceFacilitiesApi : IWorkspaceFacilitiesApiSync, IWorkspaceFacilitiesApiAsync
{

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public class WorkspaceFacilitiesApi : IWorkspaceFacilitiesApi
{
    private Reelables.Api.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkspaceFacilitiesApi"/> class.
    /// </summary>
    /// <returns></returns>
    public WorkspaceFacilitiesApi() : this((string)null)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkspaceFacilitiesApi"/> class.
    /// </summary>
    /// <returns></returns>
    public WorkspaceFacilitiesApi(string basePath)
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
    /// Initializes a new instance of the <see cref="WorkspaceFacilitiesApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public WorkspaceFacilitiesApi(Reelables.Api.SDK.Client.Configuration configuration)
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
    /// Initializes a new instance of the <see cref="WorkspaceFacilitiesApi"/> class
    /// using a Configuration object and client instance.
    /// </summary>
    /// <param name="client">The client interface for synchronous API access.</param>
    /// <param name="asyncClient">The client interface for asynchronous API access.</param>
    /// <param name="configuration">The configuration object.</param>
    public WorkspaceFacilitiesApi(Reelables.Api.SDK.Client.ISynchronousClient client, Reelables.Api.SDK.Client.IAsynchronousClient asyncClient, Reelables.Api.SDK.Client.IReadableConfiguration configuration)
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
    /// List Facilities in a Workspace 
    /// </summary>
    /// <exception cref="Reelables.Api.SDK.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="workspaceId">The identifier of the Workspace</param>
    /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00 (optional)</param>
    /// <param name="limit">Number of Facilities to return. Default: 10. Maximum: 10000 (optional)</param>
    /// <param name="nextToken">Pagination token to get next page of Facilities (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>WorkspaceFacilities</returns>
    public WorkspaceFacilities WorkspacesWorkspaceIdFacilitiesGet(string workspaceId, string? requestId = default(string?), string? limit = default(string?), string? nextToken = default(string?), int operationIndex = 0)
    {
        Reelables.Api.SDK.Client.ApiResponse<WorkspaceFacilities> localVarResponse = WorkspacesWorkspaceIdFacilitiesGetWithHttpInfo(workspaceId, requestId, limit, nextToken);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List Facilities in a Workspace 
    /// </summary>
    /// <exception cref="Reelables.Api.SDK.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="workspaceId">The identifier of the Workspace</param>
    /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00 (optional)</param>
    /// <param name="limit">Number of Facilities to return. Default: 10. Maximum: 10000 (optional)</param>
    /// <param name="nextToken">Pagination token to get next page of Facilities (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of WorkspaceFacilities</returns>
    public Reelables.Api.SDK.Client.ApiResponse<WorkspaceFacilities> WorkspacesWorkspaceIdFacilitiesGetWithHttpInfo(string workspaceId, string? requestId = default(string?), string? limit = default(string?), string? nextToken = default(string?), int operationIndex = 0)
    {
        // verify the required parameter 'workspaceId' is set
        if (workspaceId == null)
        {
            throw new Reelables.Api.SDK.Client.ApiException(400, "Missing required parameter 'workspaceId' when calling WorkspaceFacilitiesApi->WorkspacesWorkspaceIdFacilitiesGet");
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

        localVarRequestOptions.PathParameters.Add("workspaceId", Reelables.Api.SDK.Client.ClientUtils.ParameterToString(workspaceId)); // path parameter
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

        localVarRequestOptions.Operation = "WorkspaceFacilitiesApi.WorkspacesWorkspaceIdFacilitiesGet";
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
        var localVarResponse = this.Client.Get<WorkspaceFacilities>("/workspaces/{workspaceId}/facilities", localVarRequestOptions, this.Configuration);
        if (this.ExceptionFactory != null)
        {
            Exception _exception = this.ExceptionFactory("WorkspacesWorkspaceIdFacilitiesGet", localVarResponse);
            if (_exception != null)
            {
                throw _exception;
            }
        }

        return localVarResponse;
    }

    /// <summary>
    /// List Facilities in a Workspace 
    /// </summary>
    /// <exception cref="Reelables.Api.SDK.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="workspaceId">The identifier of the Workspace</param>
    /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00 (optional)</param>
    /// <param name="limit">Number of Facilities to return. Default: 10. Maximum: 10000 (optional)</param>
    /// <param name="nextToken">Pagination token to get next page of Facilities (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of WorkspaceFacilities</returns>
    public async System.Threading.Tasks.Task<WorkspaceFacilities> WorkspacesWorkspaceIdFacilitiesGetAsync(string workspaceId, string? requestId = default(string?), string? limit = default(string?), string? nextToken = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
    {
        Reelables.Api.SDK.Client.ApiResponse<WorkspaceFacilities> localVarResponse = await WorkspacesWorkspaceIdFacilitiesGetWithHttpInfoAsync(workspaceId, requestId, limit, nextToken, operationIndex, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List Facilities in a Workspace 
    /// </summary>
    /// <exception cref="Reelables.Api.SDK.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="workspaceId">The identifier of the Workspace</param>
    /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00 (optional)</param>
    /// <param name="limit">Number of Facilities to return. Default: 10. Maximum: 10000 (optional)</param>
    /// <param name="nextToken">Pagination token to get next page of Facilities (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (WorkspaceFacilities)</returns>
    public async System.Threading.Tasks.Task<Reelables.Api.SDK.Client.ApiResponse<WorkspaceFacilities>> WorkspacesWorkspaceIdFacilitiesGetWithHttpInfoAsync(string workspaceId, string? requestId = default(string?), string? limit = default(string?), string? nextToken = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
    {
        // verify the required parameter 'workspaceId' is set
        if (workspaceId == null)
        {
            throw new Reelables.Api.SDK.Client.ApiException(400, "Missing required parameter 'workspaceId' when calling WorkspaceFacilitiesApi->WorkspacesWorkspaceIdFacilitiesGet");
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

        localVarRequestOptions.PathParameters.Add("workspaceId", Reelables.Api.SDK.Client.ClientUtils.ParameterToString(workspaceId)); // path parameter
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

        localVarRequestOptions.Operation = "WorkspaceFacilitiesApi.WorkspacesWorkspaceIdFacilitiesGet";
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
        var localVarResponse = await this.AsynchronousClient.GetAsync<WorkspaceFacilities>("/workspaces/{workspaceId}/facilities", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

        if (this.ExceptionFactory != null)
        {
            Exception _exception = this.ExceptionFactory("WorkspacesWorkspaceIdFacilitiesGet", localVarResponse);
            if (_exception != null)
            {
                throw _exception;
            }
        }

        return localVarResponse;
    }

}