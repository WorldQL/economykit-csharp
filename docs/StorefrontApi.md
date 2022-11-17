# EconomyKit.UnityClient.Api.StorefrontApi

All URIs are relative to *https://app.economykit.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetStorefront**](StorefrontApi.md#getstorefront) | **GET** /inventories/api/v1/storefront/ | 
[**GetStorefrontitem**](StorefrontApi.md#getstorefrontitem) | **GET** /inventories/api/v1/storefront-item/ | 



## GetStorefront

> StorefrontResult GetStorefront (Guid? storefront = null, Guid? app = null, Guid? player = null)



Gets a storefront by ID or by app/player IDs

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EconomyKit.UnityClient.Api;
using EconomyKit.UnityClient.Client;
using EconomyKit.UnityClient.Model;

namespace Example
{
    public class GetStorefrontExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.economykit.com";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StorefrontApi(Configuration.Default);
            var storefront = "storefront_example";  // Guid? |  (optional) 
            var app = "app_example";  // Guid? |  (optional) 
            var player = "player_example";  // Guid? |  (optional) 

            try
            {
                StorefrontResult result = apiInstance.GetStorefront(storefront, app, player);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetStorefront: " + e.Message );
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
 **storefront** | **Guid?**|  | [optional] 
 **app** | **Guid?**|  | [optional] 
 **player** | **Guid?**|  | [optional] 

### Return type

[**StorefrontResult**](StorefrontResult.md)

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


## GetStorefrontitem

> StorefrontItemResult GetStorefrontitem (Guid? id = null)



Gets a storefront item by ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EconomyKit.UnityClient.Api;
using EconomyKit.UnityClient.Client;
using EconomyKit.UnityClient.Model;

namespace Example
{
    public class GetStorefrontitemExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.economykit.com";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StorefrontApi(Configuration.Default);
            var id = "id_example";  // Guid? |  (optional) 

            try
            {
                StorefrontItemResult result = apiInstance.GetStorefrontitem(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StorefrontApi.GetStorefrontitem: " + e.Message );
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
 **id** | **Guid?**|  | [optional] 

### Return type

[**StorefrontItemResult**](StorefrontItemResult.md)

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

