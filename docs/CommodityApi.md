# EconomyKit.UnityClient.Api.CommodityApi

All URIs are relative to *https://app.economykit.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCommodity**](CommodityApi.md#createcommodity) | **POST** /inventories/api/v1/commodity/ | 
[**GiveCommodity**](CommodityApi.md#givecommodity) | **PUT** /inventories/api/v1/commodity/ | 
[**ListCommodities**](CommodityApi.md#listcommodities) | **GET** /inventories/api/v1/commodity/ | 



## CreateCommodity

> CommodityResult CreateCommodity (CommodityCreateBody commodityCreateBody = null)



Create a commodity associated with a Customer App

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EconomyKit.UnityClient.Api;
using EconomyKit.UnityClient.Client;
using EconomyKit.UnityClient.Model;

namespace Example
{
    public class CreateCommodityExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.economykit.com";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CommodityApi(Configuration.Default);
            var commodityCreateBody = new CommodityCreateBody(); // CommodityCreateBody |  (optional) 

            try
            {
                CommodityResult result = apiInstance.CreateCommodity(commodityCreateBody);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CommodityApi.CreateCommodity: " + e.Message );
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
 **commodityCreateBody** | [**CommodityCreateBody**](CommodityCreateBody.md)|  | [optional] 

### Return type

[**CommodityResult**](CommodityResult.md)

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


## GiveCommodity

> CommodityStackResult GiveCommodity (CommodityStackCreateBody commodityStackCreateBody = null)



Give a commodity to a player

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EconomyKit.UnityClient.Api;
using EconomyKit.UnityClient.Client;
using EconomyKit.UnityClient.Model;

namespace Example
{
    public class GiveCommodityExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.economykit.com";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CommodityApi(Configuration.Default);
            var commodityStackCreateBody = new CommodityStackCreateBody(); // CommodityStackCreateBody |  (optional) 

            try
            {
                CommodityStackResult result = apiInstance.GiveCommodity(commodityStackCreateBody);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CommodityApi.GiveCommodity: " + e.Message );
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
 **commodityStackCreateBody** | [**CommodityStackCreateBody**](CommodityStackCreateBody.md)|  | [optional] 

### Return type

[**CommodityStackResult**](CommodityStackResult.md)

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


## ListCommodities

> PaginatedResponseCommodityResult ListCommodities (int? page = null)



List all commodities associated with a Customer App

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EconomyKit.UnityClient.Api;
using EconomyKit.UnityClient.Client;
using EconomyKit.UnityClient.Model;

namespace Example
{
    public class ListCommoditiesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.economykit.com";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CommodityApi(Configuration.Default);
            var page = 1;  // int? |  (optional)  (default to 1)

            try
            {
                PaginatedResponseCommodityResult result = apiInstance.ListCommodities(page);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CommodityApi.ListCommodities: " + e.Message );
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
 **page** | **int?**|  | [optional] [default to 1]

### Return type

[**PaginatedResponseCommodityResult**](PaginatedResponseCommodityResult.md)

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

