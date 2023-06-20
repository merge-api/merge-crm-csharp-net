# Merge.CRMClient.Api.AssociationTypesApi

All URIs are relative to *https://api.merge.dev/api/crm/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CustomObjectClassesAssociationTypesCreate**](AssociationTypesApi.md#customobjectclassesassociationtypescreate) | **POST** /custom-object-classes/{custom_object_class_id}/association-types | 
[**CustomObjectClassesAssociationTypesList**](AssociationTypesApi.md#customobjectclassesassociationtypeslist) | **GET** /custom-object-classes/{custom_object_class_id}/association-types | 
[**CustomObjectClassesAssociationTypesMetaPostRetrieve**](AssociationTypesApi.md#customobjectclassesassociationtypesmetapostretrieve) | **GET** /custom-object-classes/{custom_object_class_id}/association-types/meta/post | 
[**CustomObjectClassesAssociationTypesRetrieve**](AssociationTypesApi.md#customobjectclassesassociationtypesretrieve) | **GET** /custom-object-classes/{custom_object_class_id}/association-types/{id} | 


<a name="customobjectclassesassociationtypescreate"></a>
# **CustomObjectClassesAssociationTypesCreate**
> CRMAssociationTypeResponse CustomObjectClassesAssociationTypesCreate (string xAccountToken, Guid customObjectClassId, CRMAssociationTypeEndpointRequest cRMAssociationTypeEndpointRequest, bool? isDebugMode = null, bool? runAsync = null)



Creates an `AssociationType` object with the given values.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.CRMClient.Api;
using Merge.CRMClient.Client;
using Merge.CRMClient.Model;

namespace Example
{
    public class CustomObjectClassesAssociationTypesCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/crm/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssociationTypesApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var customObjectClassId = new Guid(); // Guid | 
            var cRMAssociationTypeEndpointRequest = new CRMAssociationTypeEndpointRequest(); // CRMAssociationTypeEndpointRequest | 
            var isDebugMode = true;  // bool? | Whether to include debug fields (such as log file links) in the response. (optional) 
            var runAsync = true;  // bool? | Whether or not third-party updates should be run asynchronously. (optional) 

            try
            {
                CRMAssociationTypeResponse result = apiInstance.CustomObjectClassesAssociationTypesCreate(xAccountToken, customObjectClassId, cRMAssociationTypeEndpointRequest, isDebugMode, runAsync);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssociationTypesApi.CustomObjectClassesAssociationTypesCreate: " + e.Message );
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
 **cRMAssociationTypeEndpointRequest** | [**CRMAssociationTypeEndpointRequest**](CRMAssociationTypeEndpointRequest.md)|  | 
 **isDebugMode** | **bool?**| Whether to include debug fields (such as log file links) in the response. | [optional] 
 **runAsync** | **bool?**| Whether or not third-party updates should be run asynchronously. | [optional] 

### Return type

[**CRMAssociationTypeResponse**](CRMAssociationTypeResponse.md)

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

<a name="customobjectclassesassociationtypeslist"></a>
# **CustomObjectClassesAssociationTypesList**
> PaginatedAssociationTypeList CustomObjectClassesAssociationTypesList (string xAccountToken, Guid customObjectClassId, DateTime? createdAfter = null, DateTime? createdBefore = null, string cursor = null, bool? includeDeletedData = null, bool? includeRemoteData = null, DateTime? modifiedAfter = null, DateTime? modifiedBefore = null, int? pageSize = null, string remoteId = null)



Returns a list of `AssociationType` objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.CRMClient.Api;
using Merge.CRMClient.Client;
using Merge.CRMClient.Model;

namespace Example
{
    public class CustomObjectClassesAssociationTypesListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/crm/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssociationTypesApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var customObjectClassId = new Guid(); // Guid | 
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
                PaginatedAssociationTypeList result = apiInstance.CustomObjectClassesAssociationTypesList(xAccountToken, customObjectClassId, createdAfter, createdBefore, cursor, includeDeletedData, includeRemoteData, modifiedAfter, modifiedBefore, pageSize, remoteId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssociationTypesApi.CustomObjectClassesAssociationTypesList: " + e.Message );
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
 **modifiedAfter** | **DateTime?**| If provided, only objects synced by Merge after this date time will be returned. | [optional] 
 **modifiedBefore** | **DateTime?**| If provided, only objects synced by Merge before this date time will be returned. | [optional] 
 **pageSize** | **int?**| Number of results to return per page. | [optional] 
 **remoteId** | **string**| The API provider&#39;s ID for the given object. | [optional] 

### Return type

[**PaginatedAssociationTypeList**](PaginatedAssociationTypeList.md)

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

<a name="customobjectclassesassociationtypesmetapostretrieve"></a>
# **CustomObjectClassesAssociationTypesMetaPostRetrieve**
> MetaResponse CustomObjectClassesAssociationTypesMetaPostRetrieve (string xAccountToken, Guid customObjectClassId)



Returns metadata for `CRMAssociationType` POSTs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.CRMClient.Api;
using Merge.CRMClient.Client;
using Merge.CRMClient.Model;

namespace Example
{
    public class CustomObjectClassesAssociationTypesMetaPostRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/crm/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssociationTypesApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var customObjectClassId = new Guid(); // Guid | 

            try
            {
                MetaResponse result = apiInstance.CustomObjectClassesAssociationTypesMetaPostRetrieve(xAccountToken, customObjectClassId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssociationTypesApi.CustomObjectClassesAssociationTypesMetaPostRetrieve: " + e.Message );
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

<a name="customobjectclassesassociationtypesretrieve"></a>
# **CustomObjectClassesAssociationTypesRetrieve**
> AssociationType CustomObjectClassesAssociationTypesRetrieve (string xAccountToken, Guid customObjectClassId, Guid id, bool? includeRemoteData = null)



Returns an `AssociationType` object with the given `id`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.CRMClient.Api;
using Merge.CRMClient.Client;
using Merge.CRMClient.Model;

namespace Example
{
    public class CustomObjectClassesAssociationTypesRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/crm/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssociationTypesApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var customObjectClassId = new Guid(); // Guid | 
            var id = new Guid(); // Guid | 
            var includeRemoteData = true;  // bool? | Whether to include the original data Merge fetched from the third-party to produce these models. (optional) 

            try
            {
                AssociationType result = apiInstance.CustomObjectClassesAssociationTypesRetrieve(xAccountToken, customObjectClassId, id, includeRemoteData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssociationTypesApi.CustomObjectClassesAssociationTypesRetrieve: " + e.Message );
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

### Return type

[**AssociationType**](AssociationType.md)

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

