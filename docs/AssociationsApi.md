# Merge.CRMClient.Api.AssociationsApi

All URIs are relative to *https://api.merge.dev/api/crm/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CustomObjectClassesCustomObjectsAssociationsList**](AssociationsApi.md#customobjectclassescustomobjectsassociationslist) | **GET** /custom-object-classes/{custom_object_class_id}/custom-objects/{object_id}/associations | 
[**CustomObjectClassesCustomObjectsAssociationsUpdate**](AssociationsApi.md#customobjectclassescustomobjectsassociationsupdate) | **PUT** /custom-object-classes/{source_class_id}/custom-objects/{source_object_id}/associations/{target_class_id}/{target_object_id}/{association_type_id} | 


<a name="customobjectclassescustomobjectsassociationslist"></a>
# **CustomObjectClassesCustomObjectsAssociationsList**
> PaginatedAssociationList CustomObjectClassesCustomObjectsAssociationsList (string xAccountToken, Guid customObjectClassId, Guid objectId, string associationTypeId = null, DateTime? createdAfter = null, DateTime? createdBefore = null, string cursor = null, bool? includeDeletedData = null, bool? includeRemoteData = null, DateTime? modifiedAfter = null, DateTime? modifiedBefore = null, int? pageSize = null, string remoteId = null)



Returns a list of `Association` objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.CRMClient.Api;
using Merge.CRMClient.Client;
using Merge.CRMClient.Model;

namespace Example
{
    public class CustomObjectClassesCustomObjectsAssociationsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/crm/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssociationsApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var customObjectClassId = new Guid(); // Guid | 
            var objectId = new Guid(); // Guid | 
            var associationTypeId = associationTypeId_example;  // string | If provided, will only return opportunities with this association_type. (optional) 
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
                PaginatedAssociationList result = apiInstance.CustomObjectClassesCustomObjectsAssociationsList(xAccountToken, customObjectClassId, objectId, associationTypeId, createdAfter, createdBefore, cursor, includeDeletedData, includeRemoteData, modifiedAfter, modifiedBefore, pageSize, remoteId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssociationsApi.CustomObjectClassesCustomObjectsAssociationsList: " + e.Message );
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
 **objectId** | [**Guid**](Guid.md)|  | 
 **associationTypeId** | **string**| If provided, will only return opportunities with this association_type. | [optional] 
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

[**PaginatedAssociationList**](PaginatedAssociationList.md)

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

<a name="customobjectclassescustomobjectsassociationsupdate"></a>
# **CustomObjectClassesCustomObjectsAssociationsUpdate**
> Association CustomObjectClassesCustomObjectsAssociationsUpdate (string xAccountToken, Guid associationTypeId, Guid sourceClassId, Guid sourceObjectId, string targetClassId, Guid targetObjectId, bool? isDebugMode = null, bool? runAsync = null)



Creates an Association between `source_object_id` and `target_object_id` of type `association_type_id`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.CRMClient.Api;
using Merge.CRMClient.Client;
using Merge.CRMClient.Model;

namespace Example
{
    public class CustomObjectClassesCustomObjectsAssociationsUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/crm/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssociationsApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var associationTypeId = new Guid(); // Guid | 
            var sourceClassId = new Guid(); // Guid | 
            var sourceObjectId = new Guid(); // Guid | 
            var targetClassId = targetClassId_example;  // string | 
            var targetObjectId = new Guid(); // Guid | 
            var isDebugMode = true;  // bool? | Whether to include debug fields (such as log file links) in the response. (optional) 
            var runAsync = true;  // bool? | Whether or not third-party updates should be run asynchronously. (optional) 

            try
            {
                Association result = apiInstance.CustomObjectClassesCustomObjectsAssociationsUpdate(xAccountToken, associationTypeId, sourceClassId, sourceObjectId, targetClassId, targetObjectId, isDebugMode, runAsync);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssociationsApi.CustomObjectClassesCustomObjectsAssociationsUpdate: " + e.Message );
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
 **associationTypeId** | [**Guid**](Guid.md)|  | 
 **sourceClassId** | [**Guid**](Guid.md)|  | 
 **sourceObjectId** | [**Guid**](Guid.md)|  | 
 **targetClassId** | **string**|  | 
 **targetObjectId** | [**Guid**](Guid.md)|  | 
 **isDebugMode** | **bool?**| Whether to include debug fields (such as log file links) in the response. | [optional] 
 **runAsync** | **bool?**| Whether or not third-party updates should be run asynchronously. | [optional] 

### Return type

[**Association**](Association.md)

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

