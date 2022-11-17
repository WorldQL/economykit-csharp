# EconomyKit.UnityClient.Api.InventoryApi

All URIs are relative to *https://app.economykit.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListInventory**](InventoryApi.md#listinventory) | **GET** /inventories/api/v1/player-inventory/ | 



## ListInventory

> PaginatedResponseInventoryEntry ListInventory (int? page = null, Guid? player = null)



Get the contents of a player's inventory

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EconomyKit.UnityClient.Api;
using EconomyKit.UnityClient.Client;
using EconomyKit.UnityClient.Model;

namespace Example
{
    public class ListInventoryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.economykit.com";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InventoryApi(Configuration.Default);
            var page = 1;  // int? |  (optional)  (default to 1)
            var player = "player_example";  // Guid? |  (optional) 

            try
            {
                PaginatedResponseInventoryEntry result = apiInstance.ListInventory(page, player);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InventoryApi.ListInventory: " + e.Message );
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
 **player** | **Guid?**|  | [optional] 

### Return type

[**PaginatedResponseInventoryEntry**](PaginatedResponseInventoryEntry.md)

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

