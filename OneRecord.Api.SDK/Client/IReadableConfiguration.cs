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
using System.Collections.Generic;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace OneRecord.Api.SDK.Client;

/// <summary>
/// Represents a readable-only configuration contract.
/// </summary>
public interface IReadableConfiguration
{
    /// <summary>
    /// Gets the access token.
    /// </summary>
    /// <value>Access token.</value>
    string HttpsAccessToken { get; }

    /// <summary>
    /// Gets the API key.
    /// </summary>
    /// <value>API key.</value>
    IDictionary<string, string> HttpsApiKey { get; }

    /// <summary>
    /// Gets the API key prefix.
    /// </summary>
    /// <value>API key prefix.</value>
    IDictionary<string, string> HttpsApiKeyPrefix { get; }

    /// <summary>
    /// Gets the base path.
    /// </summary>
    /// <value>Base path.</value>
    string HttpsBasePath { get; }

    /// <summary>
    /// Gets the date time format.
    /// </summary>
    /// <value>Date time format.</value>
    string HttpsDateTimeFormat { get; }

    /// <summary>
    /// Gets the default header.
    /// </summary>
    /// <value>Default header.</value>
    [Obsolete("Use DefaultHeaders instead.")]
    IDictionary<string, string> HttpsDefaultHeader { get; }

    /// <summary>
    /// Gets the default headers.
    /// </summary>
    /// <value>Default headers.</value>
    IDictionary<string, string> HttpsDefaultHeaders { get; }

    /// <summary>
    /// Gets the temp folder path.
    /// </summary>
    /// <value>Temp folder path.</value>
    string HttpsTempFolderPath { get; }

    /// <summary>
    /// Gets the HTTP connection timeout (in milliseconds)
    /// </summary>
    /// <value>HTTP connection timeout.</value>
    int HttpsTimeout { get; }

    /// <summary>
    /// Gets the proxy.
    /// </summary>
    /// <value>Proxy.</value>
    WebProxy HttpsProxy { get; }

    /// <summary>
    /// Gets the user agent.
    /// </summary>
    /// <value>User agent.</value>
    string HttpsUserAgent { get; }

    /// <summary>
    /// Gets the username.
    /// </summary>
    /// <value>Username.</value>
    string HttpsUsername { get; }

    /// <summary>
    /// Gets the password.
    /// </summary>
    /// <value>Password.</value>
    string HttpsPassword { get; }

    /// <summary>
    /// Determine whether or not the "default credentials" (e.g. the user account under which the current process is running) will be sent along to the server. The default is false.
    /// </summary>
    bool HttpsUseDefaultCredentials { get; }

    /// <summary>
    /// Get the servers associated with the operation.
    /// </summary>
    /// <value>Operation servers.</value>
    IReadOnlyDictionary<string, List<IReadOnlyDictionary<string, object>>> HttpsOperationServers { get; }

    /// <summary>
    /// Gets the API key with prefix.
    /// </summary>
    /// <param name="httpsApiKeyIdentifier">API key identifier (authentication scheme).</param>
    /// <returns>API key with prefix.</returns>
    string GetApiKeyWithPrefix(string httpsApiKeyIdentifier);

    /// <summary>
    /// Gets the Operation server url at the provided index.
    /// </summary>
    /// <param name="httpsOperation">Operation server name.</param>
    /// <param name="httpsIndex">Index of the operation server settings.</param>
    /// <returns></returns>
    string GetOperationServerUrl(string httpsOperation, int httpsIndex);

    /// <summary>
    /// Gets certificate collection to be sent with requests.
    /// </summary>
    /// <value>X509 Certificate collection.</value>
    X509CertificateCollection HttpsClientCertificates { get; }

    /// <summary>
    /// Callback function for handling the validation of remote certificates. Useful for certificate pinning and
    /// overriding certificate errors in the scope of a request.
    /// </summary>
    RemoteCertificateValidationCallback HttpsRemoteCertificateValidationCallback { get; }
}
