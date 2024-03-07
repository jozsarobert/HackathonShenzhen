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
public interface IWorkspacePrintTemplatesApiSync : IApiAccessor
{
    #region Synchronous Operations
    /// <summary>
    /// Get Print Templates in a Workspace
    /// </summary>
    /// <exception cref="Reelables.Api.SDK.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="workspaceId">The identifier of the Workspace</param>
    /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00 (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>WorkspacePrintTemplates</returns>
    WorkspacePrintTemplates WorkspacesWorkspaceIdPrintTemplatesGet(string workspaceId, string? requestId = default(string?), int operationIndex = 0);

    /// <summary>
    /// Get Print Templates in a Workspace
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="Reelables.Api.SDK.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="workspaceId">The identifier of the Workspace</param>
    /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00 (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of WorkspacePrintTemplates</returns>
    ApiResponse<WorkspacePrintTemplates> WorkspacesWorkspaceIdPrintTemplatesGetWithHttpInfo(string workspaceId, string? requestId = default(string?), int operationIndex = 0);
    #endregion Synchronous Operations
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IWorkspacePrintTemplatesApiAsync : IApiAccessor
{
    #region Asynchronous Operations
    /// <summary>
    /// Get Print Templates in a Workspace
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="Reelables.Api.SDK.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="workspaceId">The identifier of the Workspace</param>
    /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00 (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of WorkspacePrintTemplates</returns>
    System.Threading.Tasks.Task<WorkspacePrintTemplates> WorkspacesWorkspaceIdPrintTemplatesGetAsync(string workspaceId, string? requestId = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    /// <summary>
    /// Get Print Templates in a Workspace
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="Reelables.Api.SDK.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="workspaceId">The identifier of the Workspace</param>
    /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00 (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (WorkspacePrintTemplates)</returns>
    System.Threading.Tasks.Task<ApiResponse<WorkspacePrintTemplates>> WorkspacesWorkspaceIdPrintTemplatesGetWithHttpInfoAsync(string workspaceId, string? requestId = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    #endregion Asynchronous Operations
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IWorkspacePrintTemplatesApi : IWorkspacePrintTemplatesApiSync, IWorkspacePrintTemplatesApiAsync
{

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public class WorkspacePrintTemplatesApi : IWorkspacePrintTemplatesApi
{
    private Reelables.Api.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkspacePrintTemplatesApi"/> class.
    /// </summary>
    /// <returns></returns>
    public WorkspacePrintTemplatesApi() : this((string)null)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkspacePrintTemplatesApi"/> class.
    /// </summary>
    /// <returns></returns>
    public WorkspacePrintTemplatesApi(string basePath)
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
    /// Initializes a new instance of the <see cref="WorkspacePrintTemplatesApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public WorkspacePrintTemplatesApi(Reelables.Api.SDK.Client.Configuration configuration)
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
    /// Initializes a new instance of the <see cref="WorkspacePrintTemplatesApi"/> class
    /// using a Configuration object and client instance.
    /// </summary>
    /// <param name="client">The client interface for synchronous API access.</param>
    /// <param name="asyncClient">The client interface for asynchronous API access.</param>
    /// <param name="configuration">The configuration object.</param>
    public WorkspacePrintTemplatesApi(Reelables.Api.SDK.Client.ISynchronousClient client, Reelables.Api.SDK.Client.IAsynchronousClient asyncClient, Reelables.Api.SDK.Client.IReadableConfiguration configuration)
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
    /// Get Print Templates in a Workspace 
    /// </summary>
    /// <exception cref="Reelables.Api.SDK.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="workspaceId">The identifier of the Workspace</param>
    /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00 (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>WorkspacePrintTemplates</returns>
    public WorkspacePrintTemplates WorkspacesWorkspaceIdPrintTemplatesGet(string workspaceId, string? requestId = default(string?), int operationIndex = 0)
    {
        Reelables.Api.SDK.Client.ApiResponse<WorkspacePrintTemplates> localVarResponse = WorkspacesWorkspaceIdPrintTemplatesGetWithHttpInfo(workspaceId, requestId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Print Templates in a Workspace 
    /// </summary>
    /// <exception cref="Reelables.Api.SDK.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="workspaceId">The identifier of the Workspace</param>
    /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00 (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of WorkspacePrintTemplates</returns>
    public Reelables.Api.SDK.Client.ApiResponse<WorkspacePrintTemplates> WorkspacesWorkspaceIdPrintTemplatesGetWithHttpInfo(string workspaceId, string? requestId = default(string?), int operationIndex = 0)
    {
        // verify the required parameter 'workspaceId' is set
        if (workspaceId == null)
        {
            throw new Reelables.Api.SDK.Client.ApiException(400, "Missing required parameter 'workspaceId' when calling WorkspacePrintTemplatesApi->WorkspacesWorkspaceIdPrintTemplatesGet");
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
        if (requestId != null)
        {
            localVarRequestOptions.HeaderParameters.Add("request-id", Reelables.Api.SDK.Client.ClientUtils.ParameterToString(requestId)); // header parameter
        }

        localVarRequestOptions.Operation = "WorkspacePrintTemplatesApi.WorkspacesWorkspaceIdPrintTemplatesGet";
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
        var localVarResponse = this.Client.Get<WorkspacePrintTemplates>("/workspaces/{workspaceId}/print-templates", localVarRequestOptions, this.Configuration);
        if (this.ExceptionFactory != null)
        {
            Exception _exception = this.ExceptionFactory("WorkspacesWorkspaceIdPrintTemplatesGet", localVarResponse);
            if (_exception != null)
            {
                throw _exception;
            }
        }

        return localVarResponse;
    }

    /// <summary>
    /// Get Print Templates in a Workspace 
    /// </summary>
    /// <exception cref="Reelables.Api.SDK.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="workspaceId">The identifier of the Workspace</param>
    /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00 (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of WorkspacePrintTemplates</returns>
    public async System.Threading.Tasks.Task<WorkspacePrintTemplates> WorkspacesWorkspaceIdPrintTemplatesGetAsync(string workspaceId, string? requestId = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
    {
        Reelables.Api.SDK.Client.ApiResponse<WorkspacePrintTemplates> localVarResponse = await WorkspacesWorkspaceIdPrintTemplatesGetWithHttpInfoAsync(workspaceId, requestId, operationIndex, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Print Templates in a Workspace 
    /// </summary>
    /// <exception cref="Reelables.Api.SDK.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="workspaceId">The identifier of the Workspace</param>
    /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00 (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (WorkspacePrintTemplates)</returns>
    public async System.Threading.Tasks.Task<Reelables.Api.SDK.Client.ApiResponse<WorkspacePrintTemplates>> WorkspacesWorkspaceIdPrintTemplatesGetWithHttpInfoAsync(string workspaceId, string? requestId = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
    {
        // verify the required parameter 'workspaceId' is set
        if (workspaceId == null)
        {
            throw new Reelables.Api.SDK.Client.ApiException(400, "Missing required parameter 'workspaceId' when calling WorkspacePrintTemplatesApi->WorkspacesWorkspaceIdPrintTemplatesGet");
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
        if (requestId != null)
        {
            localVarRequestOptions.HeaderParameters.Add("request-id", Reelables.Api.SDK.Client.ClientUtils.ParameterToString(requestId)); // header parameter
        }

        localVarRequestOptions.Operation = "WorkspacePrintTemplatesApi.WorkspacesWorkspaceIdPrintTemplatesGet";
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
        var localVarResponse = await this.AsynchronousClient.GetAsync<WorkspacePrintTemplates>("/workspaces/{workspaceId}/print-templates", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

        if (this.ExceptionFactory != null)
        {
            Exception _exception = this.ExceptionFactory("WorkspacesWorkspaceIdPrintTemplatesGet", localVarResponse);
            if (_exception != null)
            {
                throw _exception;
            }
        }

        return localVarResponse;
    }

}