# EconomyKit.UnityClient.Api.PlayerIDApi

All URIs are relative to *https://app.economykit.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePlayer**](PlayerIDApi.md#createplayer) | **POST** /inventories/api/v1/player-id/ | 
[**FetchPlayer**](PlayerIDApi.md#fetchplayer) | **GET** /inventories/api/v1/player-id/ | 



## CreatePlayer

> FetchPlayerResponse CreatePlayer (FetchPlayerRequest fetchPlayerRequest = null)



Create a player by an external ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EconomyKit.UnityClient.Api;
using EconomyKit.UnityClient.Client;
using EconomyKit.UnityClient.Model;

namespace Example
{
    public class CreatePlayerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.economykit.com";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PlayerIDApi(Configuration.Default);
            var fetchPlayerRequest = new FetchPlayerRequest(); // FetchPlayerRequest |  (optional) 

            try
            {
                FetchPlayerResponse result = apiInstance.CreatePlayer(fetchPlayerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlayerIDApi.CreatePlayer: " + e.Message );
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
 **fetchPlayerRequest** | [**FetchPlayerRequest**](FetchPlayerRequest.md)|  | [optional] 

### Return type

[**FetchPlayerResponse**](FetchPlayerResponse.md)

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


## FetchPlayer

> FetchPlayerResponse FetchPlayer (FetchPlayerRequest fetchPlayerRequest = null)



Fetch a player by an external ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EconomyKit.UnityClient.Api;
using EconomyKit.UnityClient.Client;
using EconomyKit.UnityClient.Model;

namespace Example
{
    public class FetchPlayerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.economykit.com";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PlayerIDApi(Configuration.Default);
            var fetchPlayerRequest = new FetchPlayerRequest(); // FetchPlayerRequest |  (optional) 

            try
            {
                FetchPlayerResponse result = apiInstance.FetchPlayer(fetchPlayerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlayerIDApi.FetchPlayer: " + e.Message );
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
 **fetchPlayerRequest** | [**FetchPlayerRequest**](FetchPlayerRequest.md)|  | [optional] 

### Return type

[**FetchPlayerResponse**](FetchPlayerResponse.md)

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

