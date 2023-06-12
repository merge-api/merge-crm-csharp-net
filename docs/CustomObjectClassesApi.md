# Merge.CRMClient.Api.CustomObjectClassesApi

All URIs are relative to *https://api.merge.dev/api/crm/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CustomObjectClassesGeneratorUpdate**](CustomObjectClassesApi.md#customobjectclassesgeneratorupdate) | **PUT** /custom-object-classes/generator/{generator_id} | 
[**CustomObjectClassesList**](CustomObjectClassesApi.md#customobjectclasseslist) | **GET** /custom-object-classes | 
[**CustomObjectClassesRetrieve**](CustomObjectClassesApi.md#customobjectclassesretrieve) | **GET** /custom-object-classes/{id} | 


<a name="customobjectclassesgeneratorupdate"></a>
# **CustomObjectClassesGeneratorUpdate**
> CustomObjectClass CustomObjectClassesGeneratorUpdate (string xAccountToken, Guid generatorId, bool? isDebugMode = null, bool? runAsync = null)



Updates a `CustomObjectClass` object with the given `id`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.CRMClient.Api;
using Merge.CRMClient.Client;
using Merge.CRMClient.Model;

namespace Example
{
    public class CustomObjectClassesGeneratorUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/crm/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomObjectClassesApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var generatorId = new Guid(); // Guid | 
            var isDebugMode = true;  // bool? | Whether to include debug fields (such as log file links) in the response. (optional) 
            var runAsync = true;  // bool? | Whether or not third-party updates should be run asynchronously. (optional) 

            try
            {
                CustomObjectClass result = apiInstance.CustomObjectClassesGeneratorUpdate(xAccountToken, generatorId, isDebugMode, runAsync);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomObjectClassesApi.CustomObjectClassesGeneratorUpdate: " + e.Message );
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
 **xAccountToken** | **string**| Token identifying the end user. | 
 **generatorId** | [**Guid**](Guid.md)|  | 
 **isDebugMode** | **bool?**| Whether to include debug fields (such as log file links) in the response. | [optional] 
 **runAsync** | **bool?**| Whether or not third-party updates should be run asynchronously. | [optional] 

### Return type

[**CustomObjectClass**](CustomObjectClass.md)

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

<a name="customobjectclasseslist"></a>
# **CustomObjectClassesList**
> PaginatedCustomObjectClassList CustomObjectClassesList (string xAccountToken, DateTime? createdAfter = null, DateTime? createdBefore = null, string cursor = null, bool? includeDeletedData = null, bool? includeRemoteData = null, DateTime? modifiedAfter = null, DateTime? modifiedBefore = null, int? pageSize = null, string remoteId = null)



Returns a list of `CustomObjectClass` objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.CRMClient.Api;
using Merge.CRMClient.Client;
using Merge.CRMClient.Model;

namespace Example
{
    public class CustomObjectClassesListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/crm/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomObjectClassesApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return objects created after this datetime. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return objects created before this datetime. (optional) 
            var cursor = cD0yMDIxLTAxLTA2KzAzJTNBMjQlM0E1My40MzQzMjYlMkIwMCUzQTAw;  // string | The pagination cursor value. (optional) 
            var includeDeletedData = true;  // bool? | Whether to include data that was marked as deleted by third party webhooks. (optional) 
            var includeRemoteData = true;  // bool? | Whether to include the original data Merge fetched from the third-party to produce these models. (optional) 
            var modifiedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, only objects synced by Merge after this date time will be returned. (optional) 
            var modifiedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, only objects synced by Merge before this date time will be returned. (optional) 
            var pageSize = 56;  // int? | Number of results to return per page. (optional) 
            var remoteId = remoteId_example;  // string | The API provider's ID for the given object. (optional) 

            try
            {
                PaginatedCustomObjectClassList result = apiInstance.CustomObjectClassesList(xAccountToken, createdAfter, createdBefore, cursor, includeDeletedData, includeRemoteData, modifiedAfter, modifiedBefore, pageSize, remoteId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomObjectClassesApi.CustomObjectClassesList: " + e.Message );
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
 **xAccountToken** | **string**| Token identifying the end user. | 
 **createdAfter** | **DateTime?**| If provided, will only return objects created after this datetime. | [optional] 
 **createdBefore** | **DateTime?**| If provided, will only return objects created before this datetime. | [optional] 
 **cursor** | **string**| The pagination cursor value. | [optional] 
 **includeDeletedData** | **bool?**| Whether to include data that was marked as deleted by third party webhooks. | [optional] 
 **includeRemoteData** | **bool?**| Whether to include the original data Merge fetched from the third-party to produce these models. | [optional] 
 **modifiedAfter** | **DateTime?**| If provided, only objects synced by Merge after this date time will be returned. | [optional] 
 **modifiedBefore** | **DateTime?**| If provided, only objects synced by Merge before this date time will be returned. | [optional] 
 **pageSize** | **int?**| Number of results to return per page. | [optional] 
 **remoteId** | **string**| The API provider&#39;s ID for the given object. | [optional] 

### Return type

[**PaginatedCustomObjectClassList**](PaginatedCustomObjectClassList.md)

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

<a name="customobjectclassesretrieve"></a>
# **CustomObjectClassesRetrieve**
> CustomObjectClass CustomObjectClassesRetrieve (string xAccountToken, Guid id, bool? includeRemoteData = null)



Returns a `CustomObjectClass` object with the given `id`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.CRMClient.Api;
using Merge.CRMClient.Client;
using Merge.CRMClient.Model;

namespace Example
{
    public class CustomObjectClassesRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/crm/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomObjectClassesApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var id = new Guid(); // Guid | 
            var includeRemoteData = true;  // bool? | Whether to include the original data Merge fetched from the third-party to produce these models. (optional) 

            try
            {
                CustomObjectClass result = apiInstance.CustomObjectClassesRetrieve(xAccountToken, id, includeRemoteData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomObjectClassesApi.CustomObjectClassesRetrieve: " + e.Message );
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
 **xAccountToken** | **string**| Token identifying the end user. | 
 **id** | [**Guid**](Guid.md)|  | 
 **includeRemoteData** | **bool?**| Whether to include the original data Merge fetched from the third-party to produce these models. | [optional] 

### Return type

[**CustomObjectClass**](CustomObjectClass.md)

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

