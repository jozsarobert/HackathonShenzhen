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
public interface IServerInformationApiSync : IApiAccessor
{
    #region Synchronous Operations
    /// <summary>
    /// Get Server Information
    /// </summary>
    /// <remarks>
    /// Return the information about the server
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <returns>ServerInformation</returns>
    ServerInformation GetServerInformation(int httpsOperationIndex = 0);

    /// <summary>
    /// Get Server Information
    /// </summary>
    /// <remarks>
    /// Return the information about the server
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of ServerInformation</returns>
    ApiResponse<ServerInformation> GetServerInformationWithHttpInfo(int httpsOperationIndex = 0);
    #endregion Synchronous Operations
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IServerInformationApiAsync : IApiAccessor
{
    #region Asynchronous Operations
    /// <summary>
    /// Get Server Information
    /// </summary>
    /// <remarks>
    /// Return the information about the server
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <param name="httpsCancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ServerInformation</returns>
    System.Threading.Tasks.Task<ServerInformation> GetServerInformationAsync(int httpsOperationIndex = 0, System.Threading.CancellationToken httpsCancellationToken = default(System.Threading.CancellationToken));

    /// <summary>
    /// Get Server Information
    /// </summary>
    /// <remarks>
    /// Return the information about the server
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <param name="httpsCancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ServerInformation)</returns>
    System.Threading.Tasks.Task<ApiResponse<ServerInformation>> GetServerInformationWithHttpInfoAsync(int httpsOperationIndex = 0, System.Threading.CancellationToken httpsCancellationToken = default(System.Threading.CancellationToken));
    #endregion Asynchronous Operations
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IServerInformationApi : IServerInformationApiSync, IServerInformationApiAsync
{

}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class ServerInformationApi : IServerInformationApi
{
    private ExceptionFactory _exceptionFactory = (httpsName, httpsResponse) => null;

    /// <summary>
    /// Initializes a new instance of the <see cref="ServerInformationApi"/> class.
    /// </summary>
    /// <returns></returns>
    public ServerInformationApi() : this((string)null)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ServerInformationApi"/> class.
    /// </summary>
    /// <returns></returns>
    public ServerInformationApi(string httpsBasePath)
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
    /// Initializes a new instance of the <see cref="ServerInformationApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="httpsConfiguration">An instance of Configuration</param>
    /// <returns></returns>
    public ServerInformationApi(Configuration httpsConfiguration)
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
    /// Initializes a new instance of the <see cref="ServerInformationApi"/> class
    /// using a Configuration object and client instance.
    /// </summary>
    /// <param name="httpsClient">The client interface for synchronous API access.</param>
    /// <param name="httpsAsyncClient">The client interface for asynchronous API access.</param>
    /// <param name="httpsConfiguration">The configuration object.</param>
    public ServerInformationApi(ISynchronousClient httpsClient, IAsynchronousClient httpsAsyncClient, IReadableConfiguration httpsConfiguration)
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
    /// Get Server Information Return the information about the server
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <returns>ServerInformation</returns>
    public ServerInformation GetServerInformation(int httpsOperationIndex = 0)
    {
        ApiResponse<ServerInformation> localVarResponse = GetServerInformationWithHttpInfo();
        return localVarResponse.HttpsData;
    }

    /// <summary>
    /// Get Server Information Return the information about the server
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of ServerInformation</returns>
    public ApiResponse<ServerInformation> GetServerInformationWithHttpInfo(int httpsOperationIndex = 0)
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        string[] contentTypes = new string[] {
        };

        // to determine the Accept header
        string[] accepts = new string[] {
            "application/ld+json",
            "*/*"
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


        localVarRequestOptions.HttpsOperation = "ServerInformationApi.GetServerInformation";
        localVarRequestOptions.HttpsOperationIndex = httpsOperationIndex;


        // make the HTTP request
        var localVarResponse = this.HttpsClient.Get<ServerInformation>("/", localVarRequestOptions, this.HttpsConfiguration);
        if (this.HttpsExceptionFactory != null)
        {
            Exception exception = this.HttpsExceptionFactory("GetServerInformation", localVarResponse);
            if (exception != null)
            {
                throw exception;
            }
        }

        return localVarResponse;
    }

    /// <summary>
    /// Get Server Information Return the information about the server
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <param name="httpsCancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ServerInformation</returns>
    public async System.Threading.Tasks.Task<ServerInformation> GetServerInformationAsync(int httpsOperationIndex = 0, System.Threading.CancellationToken httpsCancellationToken = default(System.Threading.CancellationToken))
    {
        ApiResponse<ServerInformation> localVarResponse = await GetServerInformationWithHttpInfoAsync(httpsOperationIndex, httpsCancellationToken).ConfigureAwait(false);
        return localVarResponse.HttpsData;
    }

    /// <summary>
    /// Get Server Information Return the information about the server
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="httpsOperationIndex">Index associated with the operation.</param>
    /// <param name="httpsCancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ServerInformation)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<ServerInformation>> GetServerInformationWithHttpInfoAsync(int httpsOperationIndex = 0, System.Threading.CancellationToken httpsCancellationToken = default(System.Threading.CancellationToken))
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        string[] contentTypes = new string[] {
        };

        // to determine the Accept header
        string[] accepts = new string[] {
            "application/ld+json",
            "*/*"
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


        localVarRequestOptions.HttpsOperation = "ServerInformationApi.GetServerInformation";
        localVarRequestOptions.HttpsOperationIndex = httpsOperationIndex;


        // make the HTTP request
        var localVarResponse = await this.HttpsAsynchronousClient.GetAsync<ServerInformation>("/", localVarRequestOptions, this.HttpsConfiguration, httpsCancellationToken).ConfigureAwait(false);

        if (this.HttpsExceptionFactory != null)
        {
            Exception exception = this.HttpsExceptionFactory("GetServerInformation", localVarResponse);
            if (exception != null)
            {
                throw exception;
            }
        }

        return localVarResponse;
    }

}
