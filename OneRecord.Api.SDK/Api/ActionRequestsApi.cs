/*
 * ONE Record API Documentation
 *
 * This OpenAPI specification describes the API endpoint structure of an ONE Record API implementation.<br/><br/><b>Note:</b><br/>The included schemas can only be used to generate JSON-LD in the extended document form.<br/>However, to be fully ONE Record compliant, any ONE Record API (and any compliant ONE Record client)<br/><b>MUST</b> support at least the expanded, compacted, and flattened document forms.<br/><br/>More information about the ONE Record specification are available on [IATA Github repository](https://github.com/IATA-Cargo/ONE-Record) and on the [ONE Record Developer Portal](https://onerecord.iata.org).
 *
 * The version of the OpenAPI document: 2.0.0-dev
 * Contact: onerecord@iata.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using OneRecord.Api.SDK.Client;
using OneRecord.Api.SDK.Model;

namespace OneRecord.Api.SDK.Api;


/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IActionRequestsApiSync : IApiAccessor
{
    #region Synchronous Operations
    /// <summary>
    /// Retrieve an ActionRequest
    /// </summary>
    /// <remarks>
    /// Get any type of ActionRequest by the id
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsActionRequestId"></param>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <returns>GetActionRequest200Response</returns>
    GetActionRequest200Response GetActionRequest(string httpsActionRequestId, int httpsOperationIndex = 0);

    /// <summary>
    /// Retrieve an ActionRequest
    /// </summary>
    /// <remarks>
    /// Get any type of ActionRequest by the id
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsActionRequestId"></param>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of GetActionRequest200Response</returns>
    ApiResponse<GetActionRequest200Response> GetActionRequestWithHttpInfo(string httpsActionRequestId, int httpsOperationIndex = 0);
    /// <summary>
    /// Revoke an Action Request
    /// </summary>
    /// <remarks>
    /// Revoke an Action Request
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsActionRequestId"></param>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <returns></returns>
    void RevokeActionRequest(string httpsActionRequestId, int httpsOperationIndex = 0);

    /// <summary>
    /// Revoke an Action Request
    /// </summary>
    /// <remarks>
    /// Revoke an Action Request
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsActionRequestId"></param>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of Object(void)</returns>
    ApiResponse<Object> RevokeActionRequestWithHttpInfo(string httpsActionRequestId, int httpsOperationIndex = 0);
    /// <summary>
    /// INTERNAL: Update an ActionRequest
    /// </summary>
    /// <remarks>
    /// Update the status of an ActionRequest
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsActionRequestId"></param>
    /// <param name="httpsStatus"></param>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <returns></returns>
    void UpdateActionRequest(string httpsActionRequestId, string httpsStatus, int httpsOperationIndex = 0);

    /// <summary>
    /// INTERNAL: Update an ActionRequest
    /// </summary>
    /// <remarks>
    /// Update the status of an ActionRequest
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsActionRequestId"></param>
    /// <param name="httpsStatus"></param>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of Object(void)</returns>
    ApiResponse<Object> UpdateActionRequestWithHttpInfo(string httpsActionRequestId, string httpsStatus, int httpsOperationIndex = 0);
    #endregion Synchronous Operations
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IActionRequestsApiAsync : IApiAccessor
{
    #region Asynchronous Operations
    /// <summary>
    /// Retrieve an ActionRequest
    /// </summary>
    /// <remarks>
    /// Get any type of ActionRequest by the id
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsActionRequestId"></param>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <param name="httpsCancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of GetActionRequest200Response</returns>
    System.Threading.Tasks.Task<GetActionRequest200Response> GetActionRequestAsync(string httpsActionRequestId, int httpsOperationIndex = 0, System.Threading.CancellationToken httpsCancellationToken = default(System.Threading.CancellationToken));

    /// <summary>
    /// Retrieve an ActionRequest
    /// </summary>
    /// <remarks>
    /// Get any type of ActionRequest by the id
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsActionRequestId"></param>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <param name="httpsCancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetActionRequest200Response)</returns>
    System.Threading.Tasks.Task<ApiResponse<GetActionRequest200Response>> GetActionRequestWithHttpInfoAsync(string httpsActionRequestId, int httpsOperationIndex = 0, System.Threading.CancellationToken httpsCancellationToken = default(System.Threading.CancellationToken));
    /// <summary>
    /// Revoke an Action Request
    /// </summary>
    /// <remarks>
    /// Revoke an Action Request
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsActionRequestId"></param>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <param name="httpsCancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    System.Threading.Tasks.Task RevokeActionRequestAsync(string httpsActionRequestId, int httpsOperationIndex = 0, System.Threading.CancellationToken httpsCancellationToken = default(System.Threading.CancellationToken));

    /// <summary>
    /// Revoke an Action Request
    /// </summary>
    /// <remarks>
    /// Revoke an Action Request
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsActionRequestId"></param>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <param name="httpsCancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    System.Threading.Tasks.Task<ApiResponse<Object>> RevokeActionRequestWithHttpInfoAsync(string httpsActionRequestId, int httpsOperationIndex = 0, System.Threading.CancellationToken httpsCancellationToken = default(System.Threading.CancellationToken));
    /// <summary>
    /// INTERNAL: Update an ActionRequest
    /// </summary>
    /// <remarks>
    /// Update the status of an ActionRequest
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsActionRequestId"></param>
    /// <param name="httpsStatus"></param>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <param name="httpsCancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    System.Threading.Tasks.Task UpdateActionRequestAsync(string httpsActionRequestId, string httpsStatus, int httpsOperationIndex = 0, System.Threading.CancellationToken httpsCancellationToken = default(System.Threading.CancellationToken));

    /// <summary>
    /// INTERNAL: Update an ActionRequest
    /// </summary>
    /// <remarks>
    /// Update the status of an ActionRequest
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsActionRequestId"></param>
    /// <param name="httpsStatus"></param>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <param name="httpsCancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    System.Threading.Tasks.Task<ApiResponse<Object>> UpdateActionRequestWithHttpInfoAsync(string httpsActionRequestId, string httpsStatus, int httpsOperationIndex = 0, System.Threading.CancellationToken httpsCancellationToken = default(System.Threading.CancellationToken));
    #endregion Asynchronous Operations
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IActionRequestsApi : IActionRequestsApiSync, IActionRequestsApiAsync
{

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class ActionRequestsApi : IActionRequestsApi
{
    private ExceptionFactory _exceptionFactory = (httpsName, httpsResponse) => null;

    /// <summary>
    /// Initializes a new instance of the <see cref="ActionRequestsApi"/> class.
    /// </summary>
    /// <returns></returns>
    public ActionRequestsApi() : this((string)null)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ActionRequestsApi"/> class.
    /// </summary>
    /// <returns></returns>
    public ActionRequestsApi(string httpsBasePath)
    {
        this.HttpsConfiguration = Configuration.MergeConfigurations(
            GlobalConfiguration.HttpsInstance,
            new Configuration { HttpsBasePath = httpsBasePath }
        );
        this.HttpsClient = new ApiClient(this.HttpsConfiguration.HttpsBasePath);
        this.HttpsAsynchronousClient = new ApiClient(this.HttpsConfiguration.HttpsBasePath);
        this.HttpsExceptionFactory = Configuration.DefaultExceptionFactory;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ActionRequestsApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="httpsConfiguration">An instance of Configuration</param>
    /// <returns></returns>
    public ActionRequestsApi(Configuration httpsConfiguration)
    {
        if (httpsConfiguration == null) throw new ArgumentNullException("httpsConfiguration");

        this.HttpsConfiguration = Configuration.MergeConfigurations(
            GlobalConfiguration.HttpsInstance,
            httpsConfiguration
        );
        this.HttpsClient = new ApiClient(this.HttpsConfiguration.HttpsBasePath);
        this.HttpsAsynchronousClient = new ApiClient(this.HttpsConfiguration.HttpsBasePath);
        HttpsExceptionFactory = Configuration.DefaultExceptionFactory;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ActionRequestsApi"/> class
    /// using a Configuration object and client instance.
    /// </summary>
    /// <param name="httpsClient">The client interface for synchronous API access.</param>
    /// <param name="httpsAsyncClient">The client interface for asynchronous API access.</param>
    /// <param name="httpsConfiguration">The configuration object.</param>
    public ActionRequestsApi(ISynchronousClient httpsClient, IAsynchronousClient httpsAsyncClient, IReadableConfiguration httpsConfiguration)
    {
        if (httpsClient == null) throw new ArgumentNullException("httpsClient");
        if (httpsAsyncClient == null) throw new ArgumentNullException("httpsAsyncClient");
        if (httpsConfiguration == null) throw new ArgumentNullException("httpsConfiguration");

        this.HttpsClient = httpsClient;
        this.HttpsAsynchronousClient = httpsAsyncClient;
        this.HttpsConfiguration = httpsConfiguration;
        this.HttpsExceptionFactory = Configuration.DefaultExceptionFactory;
    }

    /// <summary>
    /// The client for accessing this underlying API asynchronously.
    /// </summary>
    public IAsynchronousClient HttpsAsynchronousClient { get; set; }

    /// <summary>
    /// The client for accessing this underlying API synchronously.
    /// </summary>
    public ISynchronousClient HttpsClient { get; set; }

    /// <summary>
    /// Gets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public string GetBasePath()
    {
        return this.HttpsConfiguration.HttpsBasePath;
    }

    /// <summary>
    /// Gets or sets the configuration object
    /// </summary>
    /// <value>An instance of the Configuration</value>
    public IReadableConfiguration HttpsConfiguration { get; set; }

    /// <summary>
    /// Provides a factory method hook for the creation of exceptions.
    /// </summary>
    public ExceptionFactory HttpsExceptionFactory
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
    /// Retrieve an ActionRequest Get any type of ActionRequest by the id
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsActionRequestId"></param>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <returns>GetActionRequest200Response</returns>
    public GetActionRequest200Response GetActionRequest(string httpsActionRequestId, int httpsOperationIndex = 0)
    {
        ApiResponse<GetActionRequest200Response> localVarResponse = GetActionRequestWithHttpInfo(httpsActionRequestId);
        return localVarResponse.HttpsData;
    }

    /// <summary>
    /// Retrieve an ActionRequest Get any type of ActionRequest by the id
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsActionRequestId"></param>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of GetActionRequest200Response</returns>
    public ApiResponse<GetActionRequest200Response> GetActionRequestWithHttpInfo(string httpsActionRequestId, int httpsOperationIndex = 0)
    {
        // verify the required parameter 'actionRequestId' is set
        if (httpsActionRequestId == null)
        {
            throw new ApiException(400, "Missing required parameter 'actionRequestId' when calling ActionRequestsApi->GetActionRequest");
        }

        RequestOptions localVarRequestOptions = new RequestOptions();

        string[] contentTypes = new string[] {
        };

        // to determine the Accept header
        string[] accepts = new string[] {
            "application/ld+json"
        };

        var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
        if (localVarContentType != null)
        {
            localVarRequestOptions.HttpsHeaderParameters.Add("Content-Type", localVarContentType);
        }

        var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
        if (localVarAccept != null)
        {
            localVarRequestOptions.HttpsHeaderParameters.Add("Accept", localVarAccept);
        }

        localVarRequestOptions.HttpsPathParameters.Add("actionRequestId", ClientUtils.ParameterToString(httpsActionRequestId)); // path parameter

        localVarRequestOptions.HttpsOperation = "ActionRequestsApi.GetActionRequest";
        localVarRequestOptions.HttpsOperationIndex = httpsOperationIndex;


        // make the HTTP request
        var localVarResponse = this.HttpsClient.Get<GetActionRequest200Response>("/action-requests/{actionRequestId}", localVarRequestOptions, this.HttpsConfiguration);
        if (this.HttpsExceptionFactory != null)
        {
            Exception exception = this.HttpsExceptionFactory("GetActionRequest", localVarResponse);
            if (exception != null)
            {
                throw exception;
            }
        }

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve an ActionRequest Get any type of ActionRequest by the id
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsActionRequestId"></param>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <param name="httpsCancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of GetActionRequest200Response</returns>
    public async System.Threading.Tasks.Task<GetActionRequest200Response> GetActionRequestAsync(string httpsActionRequestId, int httpsOperationIndex = 0, System.Threading.CancellationToken httpsCancellationToken = default(System.Threading.CancellationToken))
    {
        ApiResponse<GetActionRequest200Response> localVarResponse = await GetActionRequestWithHttpInfoAsync(httpsActionRequestId, httpsOperationIndex, httpsCancellationToken).ConfigureAwait(false);
        return localVarResponse.HttpsData;
    }

    /// <summary>
    /// Retrieve an ActionRequest Get any type of ActionRequest by the id
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsActionRequestId"></param>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <param name="httpsCancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (GetActionRequest200Response)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<GetActionRequest200Response>> GetActionRequestWithHttpInfoAsync(string httpsActionRequestId, int httpsOperationIndex = 0, System.Threading.CancellationToken httpsCancellationToken = default(System.Threading.CancellationToken))
    {
        // verify the required parameter 'actionRequestId' is set
        if (httpsActionRequestId == null)
        {
            throw new ApiException(400, "Missing required parameter 'actionRequestId' when calling ActionRequestsApi->GetActionRequest");
        }


        RequestOptions localVarRequestOptions = new RequestOptions();

        string[] contentTypes = new string[] {
        };

        // to determine the Accept header
        string[] accepts = new string[] {
            "application/ld+json"
        };

        var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
        if (localVarContentType != null)
        {
            localVarRequestOptions.HttpsHeaderParameters.Add("Content-Type", localVarContentType);
        }

        var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
        if (localVarAccept != null)
        {
            localVarRequestOptions.HttpsHeaderParameters.Add("Accept", localVarAccept);
        }

        localVarRequestOptions.HttpsPathParameters.Add("actionRequestId", ClientUtils.ParameterToString(httpsActionRequestId)); // path parameter

        localVarRequestOptions.HttpsOperation = "ActionRequestsApi.GetActionRequest";
        localVarRequestOptions.HttpsOperationIndex = httpsOperationIndex;


        // make the HTTP request
        var localVarResponse = await this.HttpsAsynchronousClient.GetAsync<GetActionRequest200Response>("/action-requests/{actionRequestId}", localVarRequestOptions, this.HttpsConfiguration, httpsCancellationToken).ConfigureAwait(false);

        if (this.HttpsExceptionFactory != null)
        {
            Exception exception = this.HttpsExceptionFactory("GetActionRequest", localVarResponse);
            if (exception != null)
            {
                throw exception;
            }
        }

        return localVarResponse;
    }

    /// <summary>
    /// Revoke an Action Request Revoke an Action Request
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsActionRequestId"></param>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <returns></returns>
    public void RevokeActionRequest(string httpsActionRequestId, int httpsOperationIndex = 0)
    {
        RevokeActionRequestWithHttpInfo(httpsActionRequestId);
    }

    /// <summary>
    /// Revoke an Action Request Revoke an Action Request
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsActionRequestId"></param>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of Object(void)</returns>
    public ApiResponse<Object> RevokeActionRequestWithHttpInfo(string httpsActionRequestId, int httpsOperationIndex = 0)
    {
        // verify the required parameter 'actionRequestId' is set
        if (httpsActionRequestId == null)
        {
            throw new ApiException(400, "Missing required parameter 'actionRequestId' when calling ActionRequestsApi->RevokeActionRequest");
        }

        RequestOptions localVarRequestOptions = new RequestOptions();

        string[] contentTypes = new string[] {
        };

        // to determine the Accept header
        string[] accepts = new string[] {
            "application/ld+json"
        };

        var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
        if (localVarContentType != null)
        {
            localVarRequestOptions.HttpsHeaderParameters.Add("Content-Type", localVarContentType);
        }

        var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
        if (localVarAccept != null)
        {
            localVarRequestOptions.HttpsHeaderParameters.Add("Accept", localVarAccept);
        }

        localVarRequestOptions.HttpsPathParameters.Add("actionRequestId", ClientUtils.ParameterToString(httpsActionRequestId)); // path parameter

        localVarRequestOptions.HttpsOperation = "ActionRequestsApi.RevokeActionRequest";
        localVarRequestOptions.HttpsOperationIndex = httpsOperationIndex;


        // make the HTTP request
        var localVarResponse = this.HttpsClient.Delete<Object>("/action-requests/{actionRequestId}", localVarRequestOptions, this.HttpsConfiguration);
        if (this.HttpsExceptionFactory != null)
        {
            Exception exception = this.HttpsExceptionFactory("RevokeActionRequest", localVarResponse);
            if (exception != null)
            {
                throw exception;
            }
        }

        return localVarResponse;
    }

    /// <summary>
    /// Revoke an Action Request Revoke an Action Request
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsActionRequestId"></param>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <param name="httpsCancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task RevokeActionRequestAsync(string httpsActionRequestId, int httpsOperationIndex = 0, System.Threading.CancellationToken httpsCancellationToken = default(System.Threading.CancellationToken))
    {
        await RevokeActionRequestWithHttpInfoAsync(httpsActionRequestId, httpsOperationIndex, httpsCancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Revoke an Action Request Revoke an Action Request
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsActionRequestId"></param>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <param name="httpsCancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    public async System.Threading.Tasks.Task<ApiResponse<Object>> RevokeActionRequestWithHttpInfoAsync(string httpsActionRequestId, int httpsOperationIndex = 0, System.Threading.CancellationToken httpsCancellationToken = default(System.Threading.CancellationToken))
    {
        // verify the required parameter 'actionRequestId' is set
        if (httpsActionRequestId == null)
        {
            throw new ApiException(400, "Missing required parameter 'actionRequestId' when calling ActionRequestsApi->RevokeActionRequest");
        }


        RequestOptions localVarRequestOptions = new RequestOptions();

        string[] contentTypes = new string[] {
        };

        // to determine the Accept header
        string[] accepts = new string[] {
            "application/ld+json"
        };

        var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
        if (localVarContentType != null)
        {
            localVarRequestOptions.HttpsHeaderParameters.Add("Content-Type", localVarContentType);
        }

        var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
        if (localVarAccept != null)
        {
            localVarRequestOptions.HttpsHeaderParameters.Add("Accept", localVarAccept);
        }

        localVarRequestOptions.HttpsPathParameters.Add("actionRequestId", ClientUtils.ParameterToString(httpsActionRequestId)); // path parameter

        localVarRequestOptions.HttpsOperation = "ActionRequestsApi.RevokeActionRequest";
        localVarRequestOptions.HttpsOperationIndex = httpsOperationIndex;


        // make the HTTP request
        var localVarResponse = await this.HttpsAsynchronousClient.DeleteAsync<Object>("/action-requests/{actionRequestId}", localVarRequestOptions, this.HttpsConfiguration, httpsCancellationToken).ConfigureAwait(false);

        if (this.HttpsExceptionFactory != null)
        {
            Exception exception = this.HttpsExceptionFactory("RevokeActionRequest", localVarResponse);
            if (exception != null)
            {
                throw exception;
            }
        }

        return localVarResponse;
    }

    /// <summary>
    /// INTERNAL: Update an ActionRequest Update the status of an ActionRequest
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsActionRequestId"></param>
    /// <param name="httpsStatus"></param>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <returns></returns>
    public void UpdateActionRequest(string httpsActionRequestId, string httpsStatus, int httpsOperationIndex = 0)
    {
        UpdateActionRequestWithHttpInfo(httpsActionRequestId, httpsStatus);
    }

    /// <summary>
    /// INTERNAL: Update an ActionRequest Update the status of an ActionRequest
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsActionRequestId"></param>
    /// <param name="httpsStatus"></param>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of Object(void)</returns>
    public ApiResponse<Object> UpdateActionRequestWithHttpInfo(string httpsActionRequestId, string httpsStatus, int httpsOperationIndex = 0)
    {
        // verify the required parameter 'actionRequestId' is set
        if (httpsActionRequestId == null)
        {
            throw new ApiException(400, "Missing required parameter 'actionRequestId' when calling ActionRequestsApi->UpdateActionRequest");
        }

        // verify the required parameter 'status' is set
        if (httpsStatus == null)
        {
            throw new ApiException(400, "Missing required parameter 'status' when calling ActionRequestsApi->UpdateActionRequest");
        }

        RequestOptions localVarRequestOptions = new RequestOptions();

        string[] contentTypes = new string[] {
        };

        // to determine the Accept header
        string[] accepts = new string[] {
            "application/ld+json"
        };

        var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
        if (localVarContentType != null)
        {
            localVarRequestOptions.HttpsHeaderParameters.Add("Content-Type", localVarContentType);
        }

        var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
        if (localVarAccept != null)
        {
            localVarRequestOptions.HttpsHeaderParameters.Add("Accept", localVarAccept);
        }

        localVarRequestOptions.HttpsPathParameters.Add("actionRequestId", ClientUtils.ParameterToString(httpsActionRequestId)); // path parameter
        localVarRequestOptions.HttpsQueryParameters.Add(ClientUtils.ParameterToMultiMap("", "status", httpsStatus));

        localVarRequestOptions.HttpsOperation = "ActionRequestsApi.UpdateActionRequest";
        localVarRequestOptions.HttpsOperationIndex = httpsOperationIndex;


        // make the HTTP request
        var localVarResponse = this.HttpsClient.Patch<Object>("/action-requests/{actionRequestId}", localVarRequestOptions, this.HttpsConfiguration);
        if (this.HttpsExceptionFactory != null)
        {
            Exception exception = this.HttpsExceptionFactory("UpdateActionRequest", localVarResponse);
            if (exception != null)
            {
                throw exception;
            }
        }

        return localVarResponse;
    }

    /// <summary>
    /// INTERNAL: Update an ActionRequest Update the status of an ActionRequest
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsActionRequestId"></param>
    /// <param name="httpsStatus"></param>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <param name="httpsCancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task UpdateActionRequestAsync(string httpsActionRequestId, string httpsStatus, int httpsOperationIndex = 0, System.Threading.CancellationToken httpsCancellationToken = default(System.Threading.CancellationToken))
    {
        await UpdateActionRequestWithHttpInfoAsync(httpsActionRequestId, httpsStatus, httpsOperationIndex, httpsCancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// INTERNAL: Update an ActionRequest Update the status of an ActionRequest
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsActionRequestId"></param>
    /// <param name="httpsStatus"></param>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <param name="httpsCancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateActionRequestWithHttpInfoAsync(string httpsActionRequestId, string httpsStatus, int httpsOperationIndex = 0, System.Threading.CancellationToken httpsCancellationToken = default(System.Threading.CancellationToken))
    {
        // verify the required parameter 'actionRequestId' is set
        if (httpsActionRequestId == null)
        {
            throw new ApiException(400, "Missing required parameter 'actionRequestId' when calling ActionRequestsApi->UpdateActionRequest");
        }

        // verify the required parameter 'status' is set
        if (httpsStatus == null)
        {
            throw new ApiException(400, "Missing required parameter 'status' when calling ActionRequestsApi->UpdateActionRequest");
        }


        RequestOptions localVarRequestOptions = new RequestOptions();

        string[] contentTypes = new string[] {
        };

        // to determine the Accept header
        string[] accepts = new string[] {
            "application/ld+json"
        };

        var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
        if (localVarContentType != null)
        {
            localVarRequestOptions.HttpsHeaderParameters.Add("Content-Type", localVarContentType);
        }

        var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
        if (localVarAccept != null)
        {
            localVarRequestOptions.HttpsHeaderParameters.Add("Accept", localVarAccept);
        }

        localVarRequestOptions.HttpsPathParameters.Add("actionRequestId", ClientUtils.ParameterToString(httpsActionRequestId)); // path parameter
        localVarRequestOptions.HttpsQueryParameters.Add(ClientUtils.ParameterToMultiMap("", "status", httpsStatus));

        localVarRequestOptions.HttpsOperation = "ActionRequestsApi.UpdateActionRequest";
        localVarRequestOptions.HttpsOperationIndex = httpsOperationIndex;


        // make the HTTP request
        var localVarResponse = await this.HttpsAsynchronousClient.PatchAsync<Object>("/action-requests/{actionRequestId}", localVarRequestOptions, this.HttpsConfiguration, httpsCancellationToken).ConfigureAwait(false);

        if (this.HttpsExceptionFactory != null)
        {
            Exception exception = this.HttpsExceptionFactory("UpdateActionRequest", localVarResponse);
            if (exception != null)
            {
                throw exception;
            }
        }

        return localVarResponse;
    }

}
