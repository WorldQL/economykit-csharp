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
    public interface IPlayerIDApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create a player by an external ID.
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fetchPlayerRequest"> (optional)</param>
        /// <returns>FetchPlayerResponse</returns>
        FetchPlayerResponse CreatePlayer (FetchPlayerRequest fetchPlayerRequest = default(FetchPlayerRequest));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create a player by an external ID.
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fetchPlayerRequest"> (optional)</param>
        /// <returns>ApiResponse of FetchPlayerResponse</returns>
        ApiResponse<FetchPlayerResponse> CreatePlayerWithHttpInfo (FetchPlayerRequest fetchPlayerRequest = default(FetchPlayerRequest));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Fetch a player by an external ID.
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fetchPlayerRequest"> (optional)</param>
        /// <returns>FetchPlayerResponse</returns>
        FetchPlayerResponse FetchPlayer (FetchPlayerRequest fetchPlayerRequest = default(FetchPlayerRequest));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Fetch a player by an external ID.
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fetchPlayerRequest"> (optional)</param>
        /// <returns>ApiResponse of FetchPlayerResponse</returns>
        ApiResponse<FetchPlayerResponse> FetchPlayerWithHttpInfo (FetchPlayerRequest fetchPlayerRequest = default(FetchPlayerRequest));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create a player by an external ID.
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fetchPlayerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of FetchPlayerResponse</returns>
        System.Threading.Tasks.Task<FetchPlayerResponse> CreatePlayerAsync (FetchPlayerRequest fetchPlayerRequest = default(FetchPlayerRequest), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create a player by an external ID.
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fetchPlayerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (FetchPlayerResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FetchPlayerResponse>> CreatePlayerWithHttpInfoAsync (FetchPlayerRequest fetchPlayerRequest = default(FetchPlayerRequest), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Fetch a player by an external ID.
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fetchPlayerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of FetchPlayerResponse</returns>
        System.Threading.Tasks.Task<FetchPlayerResponse> FetchPlayerAsync (FetchPlayerRequest fetchPlayerRequest = default(FetchPlayerRequest), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Fetch a player by an external ID.
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fetchPlayerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (FetchPlayerResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FetchPlayerResponse>> FetchPlayerWithHttpInfoAsync (FetchPlayerRequest fetchPlayerRequest = default(FetchPlayerRequest), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PlayerIDApi : IPlayerIDApi
    {
        private EconomyKit.UnityClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerIDApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PlayerIDApi(String basePath)
        {
            this.Configuration = new EconomyKit.UnityClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = EconomyKit.UnityClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerIDApi"/> class
        /// </summary>
        /// <returns></returns>
        public PlayerIDApi()
        {
            this.Configuration = EconomyKit.UnityClient.Client.Configuration.Default;

            ExceptionFactory = EconomyKit.UnityClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerIDApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PlayerIDApi(EconomyKit.UnityClient.Client.Configuration configuration = null)
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
        ///  Create a player by an external ID.
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fetchPlayerRequest"> (optional)</param>
        /// <returns>FetchPlayerResponse</returns>
        public FetchPlayerResponse CreatePlayer (FetchPlayerRequest fetchPlayerRequest = default(FetchPlayerRequest))
        {
             ApiResponse<FetchPlayerResponse> localVarResponse = CreatePlayerWithHttpInfo(fetchPlayerRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Create a player by an external ID.
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fetchPlayerRequest"> (optional)</param>
        /// <returns>ApiResponse of FetchPlayerResponse</returns>
        public ApiResponse<FetchPlayerResponse> CreatePlayerWithHttpInfo (FetchPlayerRequest fetchPlayerRequest = default(FetchPlayerRequest))
        {

            var localVarPath = "/inventories/api/v1/player-id/";
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

            if (fetchPlayerRequest != null && fetchPlayerRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(fetchPlayerRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = fetchPlayerRequest; // byte array
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
                Exception exception = ExceptionFactory("CreatePlayer", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FetchPlayerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (FetchPlayerResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FetchPlayerResponse)));
        }

        /// <summary>
        ///  Create a player by an external ID.
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fetchPlayerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of FetchPlayerResponse</returns>
        public async System.Threading.Tasks.Task<FetchPlayerResponse> CreatePlayerAsync (FetchPlayerRequest fetchPlayerRequest = default(FetchPlayerRequest), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<FetchPlayerResponse> localVarResponse = await CreatePlayerWithHttpInfoAsync(fetchPlayerRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Create a player by an external ID.
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fetchPlayerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (FetchPlayerResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FetchPlayerResponse>> CreatePlayerWithHttpInfoAsync (FetchPlayerRequest fetchPlayerRequest = default(FetchPlayerRequest), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/inventories/api/v1/player-id/";
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

            if (fetchPlayerRequest != null && fetchPlayerRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(fetchPlayerRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = fetchPlayerRequest; // byte array
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
                Exception exception = ExceptionFactory("CreatePlayer", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FetchPlayerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (FetchPlayerResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FetchPlayerResponse)));
        }

        /// <summary>
        ///  Fetch a player by an external ID.
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fetchPlayerRequest"> (optional)</param>
        /// <returns>FetchPlayerResponse</returns>
        public FetchPlayerResponse FetchPlayer (FetchPlayerRequest fetchPlayerRequest = default(FetchPlayerRequest))
        {
             ApiResponse<FetchPlayerResponse> localVarResponse = FetchPlayerWithHttpInfo(fetchPlayerRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Fetch a player by an external ID.
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fetchPlayerRequest"> (optional)</param>
        /// <returns>ApiResponse of FetchPlayerResponse</returns>
        public ApiResponse<FetchPlayerResponse> FetchPlayerWithHttpInfo (FetchPlayerRequest fetchPlayerRequest = default(FetchPlayerRequest))
        {

            var localVarPath = "/inventories/api/v1/player-id/";
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

            if (fetchPlayerRequest != null && fetchPlayerRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(fetchPlayerRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = fetchPlayerRequest; // byte array
            }

            // authentication (bearerAuth) required
            // http bearer authentication required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FetchPlayer", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FetchPlayerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (FetchPlayerResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FetchPlayerResponse)));
        }

        /// <summary>
        ///  Fetch a player by an external ID.
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fetchPlayerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of FetchPlayerResponse</returns>
        public async System.Threading.Tasks.Task<FetchPlayerResponse> FetchPlayerAsync (FetchPlayerRequest fetchPlayerRequest = default(FetchPlayerRequest), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<FetchPlayerResponse> localVarResponse = await FetchPlayerWithHttpInfoAsync(fetchPlayerRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Fetch a player by an external ID.
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fetchPlayerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (FetchPlayerResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FetchPlayerResponse>> FetchPlayerWithHttpInfoAsync (FetchPlayerRequest fetchPlayerRequest = default(FetchPlayerRequest), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/inventories/api/v1/player-id/";
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

            if (fetchPlayerRequest != null && fetchPlayerRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(fetchPlayerRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = fetchPlayerRequest; // byte array
            }

            // authentication (bearerAuth) required
            // http bearer authentication required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FetchPlayer", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FetchPlayerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (FetchPlayerResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FetchPlayerResponse)));
        }

    }
}
