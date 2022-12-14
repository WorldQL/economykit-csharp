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
    public interface IUniqueItemApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Spawns a new unique item. Can be immediately placed inside a player's inventory.
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uniqueItemCreateBody"> (optional)</param>
        /// <returns>UniqueItemResult</returns>
        UniqueItemResult CreateUniqueItem (UniqueItemCreateBody uniqueItemCreateBody = default(UniqueItemCreateBody));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Spawns a new unique item. Can be immediately placed inside a player's inventory.
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uniqueItemCreateBody"> (optional)</param>
        /// <returns>ApiResponse of UniqueItemResult</returns>
        ApiResponse<UniqueItemResult> CreateUniqueItemWithHttpInfo (UniqueItemCreateBody uniqueItemCreateBody = default(UniqueItemCreateBody));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a list of unique items.
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional, default to 1)</param>
        /// <returns>PaginatedResponseUniqueItemResult</returns>
        PaginatedResponseUniqueItemResult ListUniqueItems (int? page = default(int?));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a list of unique items.
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional, default to 1)</param>
        /// <returns>ApiResponse of PaginatedResponseUniqueItemResult</returns>
        ApiResponse<PaginatedResponseUniqueItemResult> ListUniqueItemsWithHttpInfo (int? page = default(int?));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Spawns a new unique item. Can be immediately placed inside a player's inventory.
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uniqueItemCreateBody"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of UniqueItemResult</returns>
        System.Threading.Tasks.Task<UniqueItemResult> CreateUniqueItemAsync (UniqueItemCreateBody uniqueItemCreateBody = default(UniqueItemCreateBody), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Spawns a new unique item. Can be immediately placed inside a player's inventory.
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uniqueItemCreateBody"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (UniqueItemResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<UniqueItemResult>> CreateUniqueItemWithHttpInfoAsync (UniqueItemCreateBody uniqueItemCreateBody = default(UniqueItemCreateBody), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a list of unique items.
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional, default to 1)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of PaginatedResponseUniqueItemResult</returns>
        System.Threading.Tasks.Task<PaginatedResponseUniqueItemResult> ListUniqueItemsAsync (int? page = default(int?), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a list of unique items.
        /// </remarks>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional, default to 1)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (PaginatedResponseUniqueItemResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<PaginatedResponseUniqueItemResult>> ListUniqueItemsWithHttpInfoAsync (int? page = default(int?), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UniqueItemApi : IUniqueItemApi
    {
        private EconomyKit.UnityClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueItemApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UniqueItemApi(String basePath)
        {
            this.Configuration = new EconomyKit.UnityClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = EconomyKit.UnityClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueItemApi"/> class
        /// </summary>
        /// <returns></returns>
        public UniqueItemApi()
        {
            this.Configuration = EconomyKit.UnityClient.Client.Configuration.Default;

            ExceptionFactory = EconomyKit.UnityClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueItemApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UniqueItemApi(EconomyKit.UnityClient.Client.Configuration configuration = null)
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
        ///  Spawns a new unique item. Can be immediately placed inside a player's inventory.
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uniqueItemCreateBody"> (optional)</param>
        /// <returns>UniqueItemResult</returns>
        public UniqueItemResult CreateUniqueItem (UniqueItemCreateBody uniqueItemCreateBody = default(UniqueItemCreateBody))
        {
             ApiResponse<UniqueItemResult> localVarResponse = CreateUniqueItemWithHttpInfo(uniqueItemCreateBody);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Spawns a new unique item. Can be immediately placed inside a player's inventory.
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uniqueItemCreateBody"> (optional)</param>
        /// <returns>ApiResponse of UniqueItemResult</returns>
        public ApiResponse<UniqueItemResult> CreateUniqueItemWithHttpInfo (UniqueItemCreateBody uniqueItemCreateBody = default(UniqueItemCreateBody))
        {

            var localVarPath = "/inventories/api/v1/unique-item/";
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

            if (uniqueItemCreateBody != null && uniqueItemCreateBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(uniqueItemCreateBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = uniqueItemCreateBody; // byte array
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
                Exception exception = ExceptionFactory("CreateUniqueItem", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UniqueItemResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (UniqueItemResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UniqueItemResult)));
        }

        /// <summary>
        ///  Spawns a new unique item. Can be immediately placed inside a player's inventory.
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uniqueItemCreateBody"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of UniqueItemResult</returns>
        public async System.Threading.Tasks.Task<UniqueItemResult> CreateUniqueItemAsync (UniqueItemCreateBody uniqueItemCreateBody = default(UniqueItemCreateBody), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<UniqueItemResult> localVarResponse = await CreateUniqueItemWithHttpInfoAsync(uniqueItemCreateBody, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Spawns a new unique item. Can be immediately placed inside a player's inventory.
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uniqueItemCreateBody"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (UniqueItemResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UniqueItemResult>> CreateUniqueItemWithHttpInfoAsync (UniqueItemCreateBody uniqueItemCreateBody = default(UniqueItemCreateBody), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/inventories/api/v1/unique-item/";
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

            if (uniqueItemCreateBody != null && uniqueItemCreateBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(uniqueItemCreateBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = uniqueItemCreateBody; // byte array
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
                Exception exception = ExceptionFactory("CreateUniqueItem", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UniqueItemResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (UniqueItemResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UniqueItemResult)));
        }

        /// <summary>
        ///  Returns a list of unique items.
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional, default to 1)</param>
        /// <returns>PaginatedResponseUniqueItemResult</returns>
        public PaginatedResponseUniqueItemResult ListUniqueItems (int? page = default(int?))
        {
             ApiResponse<PaginatedResponseUniqueItemResult> localVarResponse = ListUniqueItemsWithHttpInfo(page);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Returns a list of unique items.
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional, default to 1)</param>
        /// <returns>ApiResponse of PaginatedResponseUniqueItemResult</returns>
        public ApiResponse<PaginatedResponseUniqueItemResult> ListUniqueItemsWithHttpInfo (int? page = default(int?))
        {

            var localVarPath = "/inventories/api/v1/unique-item/";
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

            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter

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
                Exception exception = ExceptionFactory("ListUniqueItems", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaginatedResponseUniqueItemResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PaginatedResponseUniqueItemResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaginatedResponseUniqueItemResult)));
        }

        /// <summary>
        ///  Returns a list of unique items.
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional, default to 1)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of PaginatedResponseUniqueItemResult</returns>
        public async System.Threading.Tasks.Task<PaginatedResponseUniqueItemResult> ListUniqueItemsAsync (int? page = default(int?), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<PaginatedResponseUniqueItemResult> localVarResponse = await ListUniqueItemsWithHttpInfoAsync(page, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Returns a list of unique items.
        /// </summary>
        /// <exception cref="EconomyKit.UnityClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional, default to 1)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (PaginatedResponseUniqueItemResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PaginatedResponseUniqueItemResult>> ListUniqueItemsWithHttpInfoAsync (int? page = default(int?), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/inventories/api/v1/unique-item/";
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

            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter

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
                Exception exception = ExceptionFactory("ListUniqueItems", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaginatedResponseUniqueItemResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PaginatedResponseUniqueItemResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaginatedResponseUniqueItemResult)));
        }

    }
}
