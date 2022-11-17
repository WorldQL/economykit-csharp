/*
 * EconomyKit API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * 
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using EconomyKit.UnityClient.Client;
using EconomyKit.UnityClient.Model;

namespace EconomyKit.UnityClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAPIKeyApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Generate a new API key bound to an entire app or scoped to a player.
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provisionAPIKeyBody"> (optional)</param>
        /// <returns>ProvisionAPIKeyResponse</returns>
        ProvisionAPIKeyResponse ProvisionAPIKey (ProvisionAPIKeyBody provisionAPIKeyBody = default(ProvisionAPIKeyBody));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Generate a new API key bound to an entire app or scoped to a player.
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provisionAPIKeyBody"> (optional)</param>
        /// <returns>ApiResponse of ProvisionAPIKeyResponse</returns>
        ApiResponse<ProvisionAPIKeyResponse> ProvisionAPIKeyWithHttpInfo (ProvisionAPIKeyBody provisionAPIKeyBody = default(ProvisionAPIKeyBody));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Generate a new API key bound to an entire app or scoped to a player.
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provisionAPIKeyBody"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ProvisionAPIKeyResponse</returns>
        System.Threading.Tasks.Task<ProvisionAPIKeyResponse> ProvisionAPIKeyAsync (ProvisionAPIKeyBody provisionAPIKeyBody = default(ProvisionAPIKeyBody), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Generate a new API key bound to an entire app or scoped to a player.
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provisionAPIKeyBody"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ProvisionAPIKeyResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProvisionAPIKeyResponse>> ProvisionAPIKeyWithHttpInfoAsync (ProvisionAPIKeyBody provisionAPIKeyBody = default(ProvisionAPIKeyBody), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class APIKeyApi : IAPIKeyApi
    {
        private EconomyKit.UnityClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKeyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public APIKeyApi(String basePath)
        {
            this.Configuration = new EconomyKit.UnityClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = EconomyKit.UnityClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKeyApi"/> class
        /// </summary>
        /// <returns></returns>
        public APIKeyApi()
        {
            this.Configuration = EconomyKit.UnityClient.Client.Configuration.Default;

            ExceptionFactory = EconomyKit.UnityClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKeyApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public APIKeyApi(EconomyKit.UnityClient.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = EconomyKit.UnityClient.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = EconomyKit.UnityClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public EconomyKit.UnityClient.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public EconomyKit.UnityClient.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  Generate a new API key bound to an entire app or scoped to a player.
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provisionAPIKeyBody"> (optional)</param>
        /// <returns>ProvisionAPIKeyResponse</returns>
        public ProvisionAPIKeyResponse ProvisionAPIKey (ProvisionAPIKeyBody provisionAPIKeyBody = default(ProvisionAPIKeyBody))
        {
             ApiResponse<ProvisionAPIKeyResponse> localVarResponse = ProvisionAPIKeyWithHttpInfo(provisionAPIKeyBody);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Generate a new API key bound to an entire app or scoped to a player.
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provisionAPIKeyBody"> (optional)</param>
        /// <returns>ApiResponse of ProvisionAPIKeyResponse</returns>
        public ApiResponse<ProvisionAPIKeyResponse> ProvisionAPIKeyWithHttpInfo (ProvisionAPIKeyBody provisionAPIKeyBody = default(ProvisionAPIKeyBody))
        {

            var localVarPath = "/inventories/api/v1/api-key/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (provisionAPIKeyBody != null && provisionAPIKeyBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(provisionAPIKeyBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = provisionAPIKeyBody; // byte array
            }

            // authentication (bearerAuth) required
            // http bearer authentication required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ProvisionAPIKey", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProvisionAPIKeyResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ProvisionAPIKeyResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProvisionAPIKeyResponse)));
        }

        /// <summary>
        ///  Generate a new API key bound to an entire app or scoped to a player.
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provisionAPIKeyBody"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ProvisionAPIKeyResponse</returns>
        public async System.Threading.Tasks.Task<ProvisionAPIKeyResponse> ProvisionAPIKeyAsync (ProvisionAPIKeyBody provisionAPIKeyBody = default(ProvisionAPIKeyBody), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<ProvisionAPIKeyResponse> localVarResponse = await ProvisionAPIKeyWithHttpInfoAsync(provisionAPIKeyBody, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Generate a new API key bound to an entire app or scoped to a player.
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provisionAPIKeyBody"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ProvisionAPIKeyResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProvisionAPIKeyResponse>> ProvisionAPIKeyWithHttpInfoAsync (ProvisionAPIKeyBody provisionAPIKeyBody = default(ProvisionAPIKeyBody), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/inventories/api/v1/api-key/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (provisionAPIKeyBody != null && provisionAPIKeyBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(provisionAPIKeyBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = provisionAPIKeyBody; // byte array
            }

            // authentication (bearerAuth) required
            // http bearer authentication required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ProvisionAPIKey", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProvisionAPIKeyResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ProvisionAPIKeyResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProvisionAPIKeyResponse)));
        }

    }
}