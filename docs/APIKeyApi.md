# EconomyKit.UnityClient.Api.APIKeyApi

All URIs are relative to *https://app.economykit.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProvisionAPIKey**](APIKeyApi.md#provisionapikey) | **POST** /inventories/api/v1/api-key/ | 



## ProvisionAPIKey

> ProvisionAPIKeyResponse ProvisionAPIKey (ProvisionAPIKeyBody provisionAPIKeyBody = null)



Generate a new API key bound to an entire app or scoped to a player.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EconomyKit.UnityClient.Api;
using EconomyKit.UnityClient.Client;
using EconomyKit.UnityClient.Model;

namespace Example
{
    public class ProvisionAPIKeyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.economykit.com";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new APIKeyApi(Configuration.Default);
            var provisionAPIKeyBody = new ProvisionAPIKeyBody(); // ProvisionAPIKeyBody |  (optional) 

            try
            {
                ProvisionAPIKeyResponse result = apiInstance.ProvisionAPIKey(provisionAPIKeyBody);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling APIKeyApi.ProvisionAPIKey: " + e.Message );
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
 **provisionAPIKeyBody** | [**ProvisionAPIKeyBody**](ProvisionAPIKeyBody.md)|  | [optional] 

### Return type

[**ProvisionAPIKeyResponse**](ProvisionAPIKeyResponse.md)

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

