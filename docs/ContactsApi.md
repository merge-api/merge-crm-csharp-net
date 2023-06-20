# Merge.CRMClient.Api.ContactsApi

All URIs are relative to *https://api.merge.dev/api/crm/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ContactsCreate**](ContactsApi.md#contactscreate) | **POST** /contacts | 
[**ContactsIgnoreCreate**](ContactsApi.md#contactsignorecreate) | **POST** /contacts/ignore/{model_id} | 
[**ContactsList**](ContactsApi.md#contactslist) | **GET** /contacts | 
[**ContactsMetaPatchRetrieve**](ContactsApi.md#contactsmetapatchretrieve) | **GET** /contacts/meta/patch/{id} | 
[**ContactsMetaPostRetrieve**](ContactsApi.md#contactsmetapostretrieve) | **GET** /contacts/meta/post | 
[**ContactsPartialUpdate**](ContactsApi.md#contactspartialupdate) | **PATCH** /contacts/{id} | 
[**ContactsRemoteFieldClassesList**](ContactsApi.md#contactsremotefieldclasseslist) | **GET** /contacts/remote-field-classes | 
[**ContactsRetrieve**](ContactsApi.md#contactsretrieve) | **GET** /contacts/{id} | 


<a name="contactscreate"></a>
# **ContactsCreate**
> CRMContactResponse ContactsCreate (string xAccountToken, CRMContactEndpointRequest cRMContactEndpointRequest, bool? isDebugMode = null, bool? runAsync = null)



Creates a `Contact` object with the given values.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.CRMClient.Api;
using Merge.CRMClient.Client;
using Merge.CRMClient.Model;

namespace Example
{
    public class ContactsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/crm/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContactsApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var cRMContactEndpointRequest = new CRMContactEndpointRequest(); // CRMContactEndpointRequest | 
            var isDebugMode = true;  // bool? | Whether to include debug fields (such as log file links) in the response. (optional) 
            var runAsync = true;  // bool? | Whether or not third-party updates should be run asynchronously. (optional) 

            try
            {
                CRMContactResponse result = apiInstance.ContactsCreate(xAccountToken, cRMContactEndpointRequest, isDebugMode, runAsync);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsCreate: " + e.Message );
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
 **cRMContactEndpointRequest** | [**CRMContactEndpointRequest**](CRMContactEndpointRequest.md)|  | 
 **isDebugMode** | **bool?**| Whether to include debug fields (such as log file links) in the response. | [optional] 
 **runAsync** | **bool?**| Whether or not third-party updates should be run asynchronously. | [optional] 

### Return type

[**CRMContactResponse**](CRMContactResponse.md)

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

<a name="contactsignorecreate"></a>
# **ContactsIgnoreCreate**
> void ContactsIgnoreCreate (string xAccountToken, Guid modelId, IgnoreCommonModelRequest ignoreCommonModelRequest)



Ignores a specific row based on the `model_id` in the url. These records will have their properties set to null, and will not be updated in future syncs. The \"reason\" and \"message\" fields in the request body will be stored for audit purposes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.CRMClient.Api;
using Merge.CRMClient.Client;
using Merge.CRMClient.Model;

namespace Example
{
    public class ContactsIgnoreCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/crm/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContactsApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var modelId = new Guid(); // Guid | 
            var ignoreCommonModelRequest = new IgnoreCommonModelRequest(); // IgnoreCommonModelRequest | 

            try
            {
                apiInstance.ContactsIgnoreCreate(xAccountToken, modelId, ignoreCommonModelRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsIgnoreCreate: " + e.Message );
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
 **modelId** | [**Guid**](Guid.md)|  | 
 **ignoreCommonModelRequest** | [**IgnoreCommonModelRequest**](IgnoreCommonModelRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | No response body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactslist"></a>
# **ContactsList**
> PaginatedContactList ContactsList (string xAccountToken, string accountId = null, DateTime? createdAfter = null, DateTime? createdBefore = null, string cursor = null, bool? includeDeletedData = null, bool? includeRemoteData = null, bool? includeRemoteFields = null, DateTime? modifiedAfter = null, DateTime? modifiedBefore = null, int? pageSize = null, string remoteId = null)



Returns a list of `Contact` objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.CRMClient.Api;
using Merge.CRMClient.Client;
using Merge.CRMClient.Model;

namespace Example
{
    public class ContactsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/crm/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContactsApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var accountId = accountId_example;  // string | If provided, will only return contacts with this account. (optional) 
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
                PaginatedContactList result = apiInstance.ContactsList(xAccountToken, accountId, createdAfter, createdBefore, cursor, includeDeletedData, includeRemoteData, includeRemoteFields, modifiedAfter, modifiedBefore, pageSize, remoteId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsList: " + e.Message );
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
 **accountId** | **string**| If provided, will only return contacts with this account. | [optional] 
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

[**PaginatedContactList**](PaginatedContactList.md)

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

<a name="contactsmetapatchretrieve"></a>
# **ContactsMetaPatchRetrieve**
> MetaResponse ContactsMetaPatchRetrieve (string xAccountToken, Guid id)



Returns metadata for `CRMContact` PATCHs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.CRMClient.Api;
using Merge.CRMClient.Client;
using Merge.CRMClient.Model;

namespace Example
{
    public class ContactsMetaPatchRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/crm/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContactsApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var id = new Guid(); // Guid | 

            try
            {
                MetaResponse result = apiInstance.ContactsMetaPatchRetrieve(xAccountToken, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsMetaPatchRetrieve: " + e.Message );
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

<a name="contactsmetapostretrieve"></a>
# **ContactsMetaPostRetrieve**
> MetaResponse ContactsMetaPostRetrieve (string xAccountToken)



Returns metadata for `CRMContact` POSTs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.CRMClient.Api;
using Merge.CRMClient.Client;
using Merge.CRMClient.Model;

namespace Example
{
    public class ContactsMetaPostRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/crm/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContactsApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.

            try
            {
                MetaResponse result = apiInstance.ContactsMetaPostRetrieve(xAccountToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsMetaPostRetrieve: " + e.Message );
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

<a name="contactspartialupdate"></a>
# **ContactsPartialUpdate**
> CRMContactResponse ContactsPartialUpdate (string xAccountToken, Guid id, PatchedCRMContactEndpointRequest patchedCRMContactEndpointRequest, bool? isDebugMode = null, bool? runAsync = null)



Updates a `Contact` object with the given `id`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.CRMClient.Api;
using Merge.CRMClient.Client;
using Merge.CRMClient.Model;

namespace Example
{
    public class ContactsPartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/crm/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContactsApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var id = new Guid(); // Guid | 
            var patchedCRMContactEndpointRequest = new PatchedCRMContactEndpointRequest(); // PatchedCRMContactEndpointRequest | 
            var isDebugMode = true;  // bool? | Whether to include debug fields (such as log file links) in the response. (optional) 
            var runAsync = true;  // bool? | Whether or not third-party updates should be run asynchronously. (optional) 

            try
            {
                CRMContactResponse result = apiInstance.ContactsPartialUpdate(xAccountToken, id, patchedCRMContactEndpointRequest, isDebugMode, runAsync);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsPartialUpdate: " + e.Message );
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
 **patchedCRMContactEndpointRequest** | [**PatchedCRMContactEndpointRequest**](PatchedCRMContactEndpointRequest.md)|  | 
 **isDebugMode** | **bool?**| Whether to include debug fields (such as log file links) in the response. | [optional] 
 **runAsync** | **bool?**| Whether or not third-party updates should be run asynchronously. | [optional] 

### Return type

[**CRMContactResponse**](CRMContactResponse.md)

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

<a name="contactsremotefieldclasseslist"></a>
# **ContactsRemoteFieldClassesList**
> PaginatedRemoteFieldClassList ContactsRemoteFieldClassesList (string xAccountToken, string cursor = null, bool? includeDeletedData = null, bool? includeRemoteData = null, bool? includeRemoteFields = null, int? pageSize = null)



Returns a list of `RemoteFieldClass` objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.CRMClient.Api;
using Merge.CRMClient.Client;
using Merge.CRMClient.Model;

namespace Example
{
    public class ContactsRemoteFieldClassesListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/crm/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContactsApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var cursor = cD0yMDIxLTAxLTA2KzAzJTNBMjQlM0E1My40MzQzMjYlMkIwMCUzQTAw;  // string | The pagination cursor value. (optional) 
            var includeDeletedData = true;  // bool? | Whether to include data that was marked as deleted by third party webhooks. (optional) 
            var includeRemoteData = true;  // bool? | Whether to include the original data Merge fetched from the third-party to produce these models. (optional) 
            var includeRemoteFields = true;  // bool? | Whether to include all remote fields, including fields that Merge did not map to common models, in a normalized format. (optional) 
            var pageSize = 56;  // int? | Number of results to return per page. (optional) 

            try
            {
                PaginatedRemoteFieldClassList result = apiInstance.ContactsRemoteFieldClassesList(xAccountToken, cursor, includeDeletedData, includeRemoteData, includeRemoteFields, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsRemoteFieldClassesList: " + e.Message );
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
 **cursor** | **string**| The pagination cursor value. | [optional] 
 **includeDeletedData** | **bool?**| Whether to include data that was marked as deleted by third party webhooks. | [optional] 
 **includeRemoteData** | **bool?**| Whether to include the original data Merge fetched from the third-party to produce these models. | [optional] 
 **includeRemoteFields** | **bool?**| Whether to include all remote fields, including fields that Merge did not map to common models, in a normalized format. | [optional] 
 **pageSize** | **int?**| Number of results to return per page. | [optional] 

### Return type

[**PaginatedRemoteFieldClassList**](PaginatedRemoteFieldClassList.md)

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

<a name="contactsretrieve"></a>
# **ContactsRetrieve**
> Contact ContactsRetrieve (string xAccountToken, Guid id, bool? includeRemoteData = null, bool? includeRemoteFields = null)



Returns a `Contact` object with the given `id`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.CRMClient.Api;
using Merge.CRMClient.Client;
using Merge.CRMClient.Model;

namespace Example
{
    public class ContactsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/crm/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContactsApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var id = new Guid(); // Guid | 
            var includeRemoteData = true;  // bool? | Whether to include the original data Merge fetched from the third-party to produce these models. (optional) 
            var includeRemoteFields = true;  // bool? | Whether to include all remote fields, including fields that Merge did not map to common models, in a normalized format. (optional) 

            try
            {
                Contact result = apiInstance.ContactsRetrieve(xAccountToken, id, includeRemoteData, includeRemoteFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsRetrieve: " + e.Message );
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
 **includeRemoteFields** | **bool?**| Whether to include all remote fields, including fields that Merge did not map to common models, in a normalized format. | [optional] 

### Return type

[**Contact**](Contact.md)

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

