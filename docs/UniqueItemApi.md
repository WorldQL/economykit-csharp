# EconomyKit.UnityClient.Api.UniqueItemApi

All URIs are relative to *https://app.economykit.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateUniqueItem**](UniqueItemApi.md#createuniqueitem) | **POST** /inventories/api/v1/unique-item/ | 
[**ListUniqueItems**](UniqueItemApi.md#listuniqueitems) | **GET** /inventories/api/v1/unique-item/ | 



## CreateUniqueItem

> UniqueItemResult CreateUniqueItem (UniqueItemCreateBody uniqueItemCreateBody = null)



Spawns a new unique item. Can be immediately placed inside a player's inventory.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EconomyKit.UnityClient.Api;
using EconomyKit.UnityClient.Client;
using EconomyKit.UnityClient.Model;

namespace Example
{
    public class CreateUniqueItemExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.economykit.com";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UniqueItemApi(Configuration.Default);
            var uniqueItemCreateBody = new UniqueItemCreateBody(); // UniqueItemCreateBody |  (optional) 

            try
            {
                UniqueItemResult result = apiInstance.CreateUniqueItem(uniqueItemCreateBody);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UniqueItemApi.CreateUniqueItem: " + e.Message );
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
 **uniqueItemCreateBody** | [**UniqueItemCreateBody**](UniqueItemCreateBody.md)|  | [optional] 

### Return type

[**UniqueItemResult**](UniqueItemResult.md)

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


## ListUniqueItems

> PaginatedResponseUniqueItemResult ListUniqueItems (int? page = null)



Returns a list of unique items.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EconomyKit.UnityClient.Api;
using EconomyKit.UnityClient.Client;
using EconomyKit.UnityClient.Model;

namespace Example
{
    public class ListUniqueItemsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.economykit.com";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UniqueItemApi(Configuration.Default);
            var page = 1;  // int? |  (optional)  (default to 1)

            try
            {
                PaginatedResponseUniqueItemResult result = apiInstance.ListUniqueItems(page);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UniqueItemApi.ListUniqueItems: " + e.Message );
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

[**PaginatedResponseUniqueItemResult**](PaginatedResponseUniqueItemResult.md)

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

