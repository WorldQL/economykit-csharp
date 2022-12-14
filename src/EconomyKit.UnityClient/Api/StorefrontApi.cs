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
    public interface IStorefrontApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets a storefront by ID or by app/player IDs
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storefront"> (optional)</param>
        /// <param name="app"> (optional)</param>
        /// <param name="player"> (optional)</param>
        /// <returns>StorefrontResult</returns>
        StorefrontResult GetStorefront (Guid? storefront = default(Guid?), Guid? app = default(Guid?), Guid? player = default(Guid?));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets a storefront by ID or by app/player IDs
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storefront"> (optional)</param>
        /// <param name="app"> (optional)</param>
        /// <param name="player"> (optional)</param>
        /// <returns>ApiResponse of StorefrontResult</returns>
        ApiResponse<StorefrontResult> GetStorefrontWithHttpInfo (Guid? storefront = default(Guid?), Guid? app = default(Guid?), Guid? player = default(Guid?));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets a storefront item by ID
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <returns>StorefrontItemResult</returns>
        StorefrontItemResult GetStorefrontitem (Guid? id = default(Guid?));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets a storefront item by ID
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <returns>ApiResponse of StorefrontItemResult</returns>
        ApiResponse<StorefrontItemResult> GetStorefrontitemWithHttpInfo (Guid? id = default(Guid?));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets a storefront by ID or by app/player IDs
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storefront"> (optional)</param>
        /// <param name="app"> (optional)</param>
        /// <param name="player"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of StorefrontResult</returns>
        System.Threading.Tasks.Task<StorefrontResult> GetStorefrontAsync (Guid? storefront = default(Guid?), Guid? app = default(Guid?), Guid? player = default(Guid?), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets a storefront by ID or by app/player IDs
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storefront"> (optional)</param>
        /// <param name="app"> (optional)</param>
        /// <param name="player"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (StorefrontResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<StorefrontResult>> GetStorefrontWithHttpInfoAsync (Guid? storefront = default(Guid?), Guid? app = default(Guid?), Guid? player = default(Guid?), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets a storefront item by ID
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of StorefrontItemResult</returns>
        System.Threading.Tasks.Task<StorefrontItemResult> GetStorefrontitemAsync (Guid? id = default(Guid?), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets a storefront item by ID
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (StorefrontItemResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<StorefrontItemResult>> GetStorefrontitemWithHttpInfoAsync (Guid? id = default(Guid?), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class StorefrontApi : IStorefrontApi
    {
        private EconomyKit.UnityClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StorefrontApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StorefrontApi(String basePath)
        {
            this.Configuration = new EconomyKit.UnityClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = EconomyKit.UnityClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorefrontApi"/> class
        /// </summary>
        /// <returns></returns>
        public StorefrontApi()
        {
            this.Configuration = EconomyKit.UnityClient.Client.Configuration.Default;

            ExceptionFactory = EconomyKit.UnityClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorefrontApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StorefrontApi(EconomyKit.UnityClient.Client.Configuration configuration = null)
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
        ///  Gets a storefront by ID or by app/player IDs
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storefront"> (optional)</param>
        /// <param name="app"> (optional)</param>
        /// <param name="player"> (optional)</param>
        /// <returns>StorefrontResult</returns>
        public StorefrontResult GetStorefront (Guid? storefront = default(Guid?), Guid? app = default(Guid?), Guid? player = default(Guid?))
        {
             ApiResponse<StorefrontResult> localVarResponse = GetStorefrontWithHttpInfo(storefront, app, player);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Gets a storefront by ID or by app/player IDs
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storefront"> (optional)</param>
        /// <param name="app"> (optional)</param>
        /// <param name="player"> (optional)</param>
        /// <returns>ApiResponse of StorefrontResult</returns>
        public ApiResponse<StorefrontResult> GetStorefrontWithHttpInfo (Guid? storefront = default(Guid?), Guid? app = default(Guid?), Guid? player = default(Guid?))
        {

            var localVarPath = "/inventories/api/v1/storefront/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (storefront != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "storefront", storefront)); // query parameter
            if (app != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "app", app)); // query parameter
            if (player != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "player", player)); // query parameter

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
                Exception exception = ExceptionFactory("GetStorefront", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StorefrontResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (StorefrontResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StorefrontResult)));
        }

        /// <summary>
        ///  Gets a storefront by ID or by app/player IDs
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storefront"> (optional)</param>
        /// <param name="app"> (optional)</param>
        /// <param name="player"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of StorefrontResult</returns>
        public async System.Threading.Tasks.Task<StorefrontResult> GetStorefrontAsync (Guid? storefront = default(Guid?), Guid? app = default(Guid?), Guid? player = default(Guid?), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<StorefrontResult> localVarResponse = await GetStorefrontWithHttpInfoAsync(storefront, app, player, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Gets a storefront by ID or by app/player IDs
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storefront"> (optional)</param>
        /// <param name="app"> (optional)</param>
        /// <param name="player"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (StorefrontResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StorefrontResult>> GetStorefrontWithHttpInfoAsync (Guid? storefront = default(Guid?), Guid? app = default(Guid?), Guid? player = default(Guid?), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/inventories/api/v1/storefront/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (storefront != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "storefront", storefront)); // query parameter
            if (app != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "app", app)); // query parameter
            if (player != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "player", player)); // query parameter

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
                Exception exception = ExceptionFactory("GetStorefront", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StorefrontResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (StorefrontResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StorefrontResult)));
        }

        /// <summary>
        ///  Gets a storefront item by ID
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <returns>StorefrontItemResult</returns>
        public StorefrontItemResult GetStorefrontitem (Guid? id = default(Guid?))
        {
             ApiResponse<StorefrontItemResult> localVarResponse = GetStorefrontitemWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Gets a storefront item by ID
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <returns>ApiResponse of StorefrontItemResult</returns>
        public ApiResponse<StorefrontItemResult> GetStorefrontitemWithHttpInfo (Guid? id = default(Guid?))
        {

            var localVarPath = "/inventories/api/v1/storefront-item/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter

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
                Exception exception = ExceptionFactory("GetStorefrontitem", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StorefrontItemResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (StorefrontItemResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StorefrontItemResult)));
        }

        /// <summary>
        ///  Gets a storefront item by ID
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of StorefrontItemResult</returns>
        public async System.Threading.Tasks.Task<StorefrontItemResult> GetStorefrontitemAsync (Guid? id = default(Guid?), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<StorefrontItemResult> localVarResponse = await GetStorefrontitemWithHttpInfoAsync(id, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Gets a storefront item by ID
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (StorefrontItemResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StorefrontItemResult>> GetStorefrontitemWithHttpInfoAsync (Guid? id = default(Guid?), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/inventories/api/v1/storefront-item/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter

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
                Exception exception = ExceptionFactory("GetStorefrontitem", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StorefrontItemResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (StorefrontItemResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StorefrontItemResult)));
        }

    }
}
