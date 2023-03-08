# Merge.CRMClient.Api.CommonModelScopesApi

All URIs are relative to *https://api.merge.dev/api/crm/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CommonModelScopesCreate**](CommonModelScopesApi.md#commonmodelscopescreate) | **POST** /common-model-scopes | 
[**CommonModelScopesRetrieve**](CommonModelScopesApi.md#commonmodelscopesretrieve) | **GET** /common-model-scopes | 


<a name="commonmodelscopescreate"></a>
# **CommonModelScopesCreate**
> CommonModelScopes CommonModelScopesCreate (CommonModelScopesUpdateSerializer commonModelScopesUpdateSerializer, string linkedAccountId = null)



Update the configuration of what data is saved by Merge when syncing. Common model scopes are set as a default across all linked accounts, but can be updated to have greater granularity per account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.CRMClient.Api;
using Merge.CRMClient.Client;
using Merge.CRMClient.Model;

namespace Example
{
    public class CommonModelScopesCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/crm/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CommonModelScopesApi(config);
            var commonModelScopesUpdateSerializer = new CommonModelScopesUpdateSerializer(); // CommonModelScopesUpdateSerializer | 
            var linkedAccountId = linkedAccountId_example;  // string | ID of specific linked account to fetch (optional) 

            try
            {
                CommonModelScopes result = apiInstance.CommonModelScopesCreate(commonModelScopesUpdateSerializer, linkedAccountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CommonModelScopesApi.CommonModelScopesCreate: " + e.Message );
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
 **commonModelScopesUpdateSerializer** | [**CommonModelScopesUpdateSerializer**](CommonModelScopesUpdateSerializer.md)|  | 
 **linkedAccountId** | **string**| ID of specific linked account to fetch | [optional] 

### Return type

[**CommonModelScopes**](CommonModelScopes.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="commonmodelscopesretrieve"></a>
# **CommonModelScopesRetrieve**
> CommonModelScopes CommonModelScopesRetrieve (string linkedAccountId = null)



Fetch the configuration of what data is saved by Merge when syncing. Common model scopes are set as a default across all linked accounts, but can be updated to have greater granularity per account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.CRMClient.Api;
using Merge.CRMClient.Client;
using Merge.CRMClient.Model;

namespace Example
{
    public class CommonModelScopesRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/crm/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CommonModelScopesApi(config);
            var linkedAccountId = linkedAccountId_example;  // string | ID of specific linked account to fetch (optional) 

            try
            {
                CommonModelScopes result = apiInstance.CommonModelScopesRetrieve(linkedAccountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CommonModelScopesApi.CommonModelScopesRetrieve: " + e.Message );
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
 **linkedAccountId** | **string**| ID of specific linked account to fetch | [optional] 

### Return type

[**CommonModelScopes**](CommonModelScopes.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

