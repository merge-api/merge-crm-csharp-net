# Merge.CRMClient.Api.CustomObjectsApi

All URIs are relative to *https://api.merge.dev/api/crm/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CustomObjectClassesCustomObjectsCreate**](CustomObjectsApi.md#customobjectclassescustomobjectscreate) | **POST** /custom-object-classes/{custom_object_class_id}/custom-objects | 
[**CustomObjectClassesCustomObjectsList**](CustomObjectsApi.md#customobjectclassescustomobjectslist) | **GET** /custom-object-classes/{custom_object_class_id}/custom-objects | 
[**CustomObjectClassesCustomObjectsMetaPatchRetrieve**](CustomObjectsApi.md#customobjectclassescustomobjectsmetapatchretrieve) | **GET** /custom-object-classes/{custom_object_class_id}/custom-objects/meta/patch/{id} | 
[**CustomObjectClassesCustomObjectsMetaPostRetrieve**](CustomObjectsApi.md#customobjectclassescustomobjectsmetapostretrieve) | **GET** /custom-object-classes/{custom_object_class_id}/custom-objects/meta/post | 
[**CustomObjectClassesCustomObjectsPartialUpdate**](CustomObjectsApi.md#customobjectclassescustomobjectspartialupdate) | **PATCH** /custom-object-classes/{custom_object_class_id}/custom-objects/{id} | 
[**CustomObjectClassesCustomObjectsRetrieve**](CustomObjectsApi.md#customobjectclassescustomobjectsretrieve) | **GET** /custom-object-classes/{custom_object_class_id}/custom-objects/{id} | 


<a name="customobjectclassescustomobjectscreate"></a>
# **CustomObjectClassesCustomObjectsCreate**
> CRMCustomObjectResponse CustomObjectClassesCustomObjectsCreate (string xAccountToken, Guid customObjectClassId, CRMCustomObjectEndpointRequest cRMCustomObjectEndpointRequest, bool? isDebugMode = null, bool? runAsync = null)



Creates a `CustomObject` object with the given values.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.CRMClient.Api;
using Merge.CRMClient.Client;
using Merge.CRMClient.Model;

namespace Example
{
    public class CustomObjectClassesCustomObjectsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/crm/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomObjectsApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var customObjectClassId = new Guid(); // Guid | 
            var cRMCustomObjectEndpointRequest = new CRMCustomObjectEndpointRequest(); // CRMCustomObjectEndpointRequest | 
            var isDebugMode = true;  // bool? | Whether to include debug fields (such as log file links) in the response. (optional) 
            var runAsync = true;  // bool? | Whether or not third-party updates should be run asynchronously. (optional) 

            try
            {
                CRMCustomObjectResponse result = apiInstance.CustomObjectClassesCustomObjectsCreate(xAccountToken, customObjectClassId, cRMCustomObjectEndpointRequest, isDebugMode, runAsync);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomObjectsApi.CustomObjectClassesCustomObjectsCreate: " + e.Message );
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
 **customObjectClassId** | [**Guid**](Guid.md)|  | 
 **cRMCustomObjectEndpointRequest** | [**CRMCustomObjectEndpointRequest**](CRMCustomObjectEndpointRequest.md)|  | 
 **isDebugMode** | **bool?**| Whether to include debug fields (such as log file links) in the response. | [optional] 
 **runAsync** | **bool?**| Whether or not third-party updates should be run asynchronously. | [optional] 

### Return type

[**CRMCustomObjectResponse**](CRMCustomObjectResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customobjectclassescustomobjectslist"></a>
# **CustomObjectClassesCustomObjectsList**
> PaginatedCustomObjectList CustomObjectClassesCustomObjectsList (string xAccountToken, Guid customObjectClassId, DateTime? createdAfter = null, DateTime? createdBefore = null, string cursor = null, bool? includeDeletedData = null, bool? includeRemoteData = null, bool? includeRemoteFields = null, DateTime? modifiedAfter = null, DateTime? modifiedBefore = null, int? pageSize = null, string remoteId = null)



Returns a list of `CustomObject` objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.CRMClient.Api;
using Merge.CRMClient.Client;
using Merge.CRMClient.Model;

namespace Example
{
    public class CustomObjectClassesCustomObjectsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/crm/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomObjectsApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var customObjectClassId = new Guid(); // Guid | 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return objects created after this datetime. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return objects created before this datetime. (optional) 
            var cursor = cD0yMDIxLTAxLTA2KzAzJTNBMjQlM0E1My40MzQzMjYlMkIwMCUzQTAw;  // string | The pagination cursor value. (optional) 
            var includeDeletedData = true;  // bool? | Whether to include data that was marked as deleted by third party webhooks. (optional) 
            var includeRemoteData = true;  // bool? | Whether to include the original data Merge fetched from the third-party to produce these models. (optional) 
            var includeRemoteFields = true;  // bool? | Whether to include all remote fields, including fields that Merge did not map to common models, in a normalized format. (optional) 
            var modifiedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, only objects synced by Merge after this date time will be returned. (optional) 
            var modifiedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, only objects synced by Merge before this date time will be returned. (optional) 
            var pageSize = 56;  // int? | Number of results to return per page. (optional) 
            var remoteId = remoteId_example;  // string | The API provider's ID for the given object. (optional) 

            try
            {
                PaginatedCustomObjectList result = apiInstance.CustomObjectClassesCustomObjectsList(xAccountToken, customObjectClassId, createdAfter, createdBefore, cursor, includeDeletedData, includeRemoteData, includeRemoteFields, modifiedAfter, modifiedBefore, pageSize, remoteId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomObjectsApi.CustomObjectClassesCustomObjectsList: " + e.Message );
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
 **customObjectClassId** | [**Guid**](Guid.md)|  | 
 **createdAfter** | **DateTime?**| If provided, will only return objects created after this datetime. | [optional] 
 **createdBefore** | **DateTime?**| If provided, will only return objects created before this datetime. | [optional] 
 **cursor** | **string**| The pagination cursor value. | [optional] 
 **includeDeletedData** | **bool?**| Whether to include data that was marked as deleted by third party webhooks. | [optional] 
 **includeRemoteData** | **bool?**| Whether to include the original data Merge fetched from the third-party to produce these models. | [optional] 
 **includeRemoteFields** | **bool?**| Whether to include all remote fields, including fields that Merge did not map to common models, in a normalized format. | [optional] 
 **modifiedAfter** | **DateTime?**| If provided, only objects synced by Merge after this date time will be returned. | [optional] 
 **modifiedBefore** | **DateTime?**| If provided, only objects synced by Merge before this date time will be returned. | [optional] 
 **pageSize** | **int?**| Number of results to return per page. | [optional] 
 **remoteId** | **string**| The API provider&#39;s ID for the given object. | [optional] 

### Return type

[**PaginatedCustomObjectList**](PaginatedCustomObjectList.md)

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

<a name="customobjectclassescustomobjectsmetapatchretrieve"></a>
# **CustomObjectClassesCustomObjectsMetaPatchRetrieve**
> MetaResponse CustomObjectClassesCustomObjectsMetaPatchRetrieve (string xAccountToken, Guid customObjectClassId, Guid id)



Returns metadata for `CRMCustomObject` PATCHs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.CRMClient.Api;
using Merge.CRMClient.Client;
using Merge.CRMClient.Model;

namespace Example
{
    public class CustomObjectClassesCustomObjectsMetaPatchRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/crm/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomObjectsApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var customObjectClassId = new Guid(); // Guid | 
            var id = new Guid(); // Guid | 

            try
            {
                MetaResponse result = apiInstance.CustomObjectClassesCustomObjectsMetaPatchRetrieve(xAccountToken, customObjectClassId, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomObjectsApi.CustomObjectClassesCustomObjectsMetaPatchRetrieve: " + e.Message );
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
 **customObjectClassId** | [**Guid**](Guid.md)|  | 
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**MetaResponse**](MetaResponse.md)

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

<a name="customobjectclassescustomobjectsmetapostretrieve"></a>
# **CustomObjectClassesCustomObjectsMetaPostRetrieve**
> MetaResponse CustomObjectClassesCustomObjectsMetaPostRetrieve (string xAccountToken, Guid customObjectClassId)



Returns metadata for `CRMCustomObject` POSTs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.CRMClient.Api;
using Merge.CRMClient.Client;
using Merge.CRMClient.Model;

namespace Example
{
    public class CustomObjectClassesCustomObjectsMetaPostRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/crm/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomObjectsApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var customObjectClassId = new Guid(); // Guid | 

            try
            {
                MetaResponse result = apiInstance.CustomObjectClassesCustomObjectsMetaPostRetrieve(xAccountToken, customObjectClassId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomObjectsApi.CustomObjectClassesCustomObjectsMetaPostRetrieve: " + e.Message );
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
 **customObjectClassId** | [**Guid**](Guid.md)|  | 

### Return type

[**MetaResponse**](MetaResponse.md)

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

<a name="customobjectclassescustomobjectspartialupdate"></a>
# **CustomObjectClassesCustomObjectsPartialUpdate**
> CRMCustomObjectResponse CustomObjectClassesCustomObjectsPartialUpdate (string xAccountToken, Guid customObjectClassId, Guid id, PatchedCRMCustomObjectEndpointRequest patchedCRMCustomObjectEndpointRequest, bool? isDebugMode = null, bool? runAsync = null)



Updates a `CustomObject` object with the given `id`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.CRMClient.Api;
using Merge.CRMClient.Client;
using Merge.CRMClient.Model;

namespace Example
{
    public class CustomObjectClassesCustomObjectsPartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/crm/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomObjectsApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var customObjectClassId = new Guid(); // Guid | 
            var id = new Guid(); // Guid | 
            var patchedCRMCustomObjectEndpointRequest = new PatchedCRMCustomObjectEndpointRequest(); // PatchedCRMCustomObjectEndpointRequest | 
            var isDebugMode = true;  // bool? | Whether to include debug fields (such as log file links) in the response. (optional) 
            var runAsync = true;  // bool? | Whether or not third-party updates should be run asynchronously. (optional) 

            try
            {
                CRMCustomObjectResponse result = apiInstance.CustomObjectClassesCustomObjectsPartialUpdate(xAccountToken, customObjectClassId, id, patchedCRMCustomObjectEndpointRequest, isDebugMode, runAsync);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomObjectsApi.CustomObjectClassesCustomObjectsPartialUpdate: " + e.Message );
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
 **customObjectClassId** | [**Guid**](Guid.md)|  | 
 **id** | [**Guid**](Guid.md)|  | 
 **patchedCRMCustomObjectEndpointRequest** | [**PatchedCRMCustomObjectEndpointRequest**](PatchedCRMCustomObjectEndpointRequest.md)|  | 
 **isDebugMode** | **bool?**| Whether to include debug fields (such as log file links) in the response. | [optional] 
 **runAsync** | **bool?**| Whether or not third-party updates should be run asynchronously. | [optional] 

### Return type

[**CRMCustomObjectResponse**](CRMCustomObjectResponse.md)

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

<a name="customobjectclassescustomobjectsretrieve"></a>
# **CustomObjectClassesCustomObjectsRetrieve**
> CustomObject CustomObjectClassesCustomObjectsRetrieve (string xAccountToken, Guid customObjectClassId, Guid id, bool? includeRemoteData = null, bool? includeRemoteFields = null)



Returns a `CustomObject` object with the given `id`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.CRMClient.Api;
using Merge.CRMClient.Client;
using Merge.CRMClient.Model;

namespace Example
{
    public class CustomObjectClassesCustomObjectsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/crm/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomObjectsApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var customObjectClassId = new Guid(); // Guid | 
            var id = new Guid(); // Guid | 
            var includeRemoteData = true;  // bool? | Whether to include the original data Merge fetched from the third-party to produce these models. (optional) 
            var includeRemoteFields = true;  // bool? | Whether to include all remote fields, including fields that Merge did not map to common models, in a normalized format. (optional) 

            try
            {
                CustomObject result = apiInstance.CustomObjectClassesCustomObjectsRetrieve(xAccountToken, customObjectClassId, id, includeRemoteData, includeRemoteFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomObjectsApi.CustomObjectClassesCustomObjectsRetrieve: " + e.Message );
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
 **customObjectClassId** | [**Guid**](Guid.md)|  | 
 **id** | [**Guid**](Guid.md)|  | 
 **includeRemoteData** | **bool?**| Whether to include the original data Merge fetched from the third-party to produce these models. | [optional] 
 **includeRemoteFields** | **bool?**| Whether to include all remote fields, including fields that Merge did not map to common models, in a normalized format. | [optional] 

### Return type

[**CustomObject**](CustomObject.md)

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

