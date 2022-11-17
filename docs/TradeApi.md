# EconomyKit.UnityClient.Api.TradeApi

All URIs are relative to *https://app.economykit.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AcceptTradeRequest**](TradeApi.md#accepttraderequest) | **POST** /inventories/api/v1/trade/accept/ | 
[**DenyTradeRequest**](TradeApi.md#denytraderequest) | **POST** /inventories/api/v1/trade/deny/ | 
[**ListTrades**](TradeApi.md#listtrades) | **GET** /inventories/api/v1/trades/ | 
[**PlaceTradeRequest**](TradeApi.md#placetraderequest) | **POST** /inventories/api/v1/trade/ | 
[**TradeDetails**](TradeApi.md#tradedetails) | **GET** /inventories/api/v1/trade/ | 



## AcceptTradeRequest

> TradeRequestModel AcceptTradeRequest (TradeActionBody tradeActionBody = null)



Accepts & executes a trade request

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EconomyKit.UnityClient.Api;
using EconomyKit.UnityClient.Client;
using EconomyKit.UnityClient.Model;

namespace Example
{
    public class AcceptTradeRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.economykit.com";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TradeApi(Configuration.Default);
            var tradeActionBody = new TradeActionBody(); // TradeActionBody |  (optional) 

            try
            {
                TradeRequestModel result = apiInstance.AcceptTradeRequest(tradeActionBody);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TradeApi.AcceptTradeRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tradeActionBody** | [**TradeActionBody**](TradeActionBody.md)|  | [optional] 

### Return type

[**TradeRequestModel**](TradeRequestModel.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DenyTradeRequest

> TradeRequestModel DenyTradeRequest (TradeActionBody tradeActionBody = null)



Denies a trade request

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EconomyKit.UnityClient.Api;
using EconomyKit.UnityClient.Client;
using EconomyKit.UnityClient.Model;

namespace Example
{
    public class DenyTradeRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.economykit.com";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TradeApi(Configuration.Default);
            var tradeActionBody = new TradeActionBody(); // TradeActionBody |  (optional) 

            try
            {
                TradeRequestModel result = apiInstance.DenyTradeRequest(tradeActionBody);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TradeApi.DenyTradeRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tradeActionBody** | [**TradeActionBody**](TradeActionBody.md)|  | [optional] 

### Return type

[**TradeRequestModel**](TradeRequestModel.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListTrades

> ListTradesResponse ListTrades (Guid? player = null, bool? activeOnly = null)



List all trades associated with a Player

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EconomyKit.UnityClient.Api;
using EconomyKit.UnityClient.Client;
using EconomyKit.UnityClient.Model;

namespace Example
{
    public class ListTradesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.economykit.com";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TradeApi(Configuration.Default);
            var player = "player_example";  // Guid? |  (optional) 
            var activeOnly = false;  // bool? |  (optional)  (default to false)

            try
            {
                ListTradesResponse result = apiInstance.ListTrades(player, activeOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TradeApi.ListTrades: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **player** | **Guid?**|  | [optional] 
 **activeOnly** | **bool?**|  | [optional] [default to false]

### Return type

[**ListTradesResponse**](ListTradesResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PlaceTradeRequest

> TradeRequestModel PlaceTradeRequest (PlaceTradeReqRequest placeTradeReqRequest = null)



Create a trade request

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EconomyKit.UnityClient.Api;
using EconomyKit.UnityClient.Client;
using EconomyKit.UnityClient.Model;

namespace Example
{
    public class PlaceTradeRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.economykit.com";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TradeApi(Configuration.Default);
            var placeTradeReqRequest = new PlaceTradeReqRequest(); // PlaceTradeReqRequest |  (optional) 

            try
            {
                TradeRequestModel result = apiInstance.PlaceTradeRequest(placeTradeReqRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TradeApi.PlaceTradeRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **placeTradeReqRequest** | [**PlaceTradeReqRequest**](PlaceTradeReqRequest.md)|  | [optional] 

### Return type

[**TradeRequestModel**](TradeRequestModel.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TradeDetails

> TradeRequestModel TradeDetails (Guid? trade = null)



Get the full details of a specific trade

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EconomyKit.UnityClient.Api;
using EconomyKit.UnityClient.Client;
using EconomyKit.UnityClient.Model;

namespace Example
{
    public class TradeDetailsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.economykit.com";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TradeApi(Configuration.Default);
            var trade = "trade_example";  // Guid? |  (optional) 

            try
            {
                TradeRequestModel result = apiInstance.TradeDetails(trade);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TradeApi.TradeDetails: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **trade** | **Guid?**|  | [optional] 

### Return type

[**TradeRequestModel**](TradeRequestModel.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

