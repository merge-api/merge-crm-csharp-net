# Merge.CRMClient.Model.Note
# The Note Object ### Description The `Note` object is used to represent a note on another object. ### Usage Example TODO

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Owner** | **Guid?** | The note&#39;s owner. | [optional] 
**Content** | **string** | The note&#39;s content. | [optional] 
**Contact** | **Guid?** | The note&#39;s contact. | [optional] 
**Account** | **Guid?** | The note&#39;s account. | [optional] 
**Opportunity** | **Guid?** | The note&#39;s opportunity. | [optional] 
**RemoteUpdatedAt** | **DateTime?** | When the third party&#39;s lead was updated. | [optional] 
**RemoteCreatedAt** | **DateTime?** | When the third party&#39;s lead was created. | [optional] 
**RemoteWasDeleted** | **bool** |  | [optional] [readonly] 
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**FieldMappings** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 
**ModifiedAt** | **DateTime** | This is the datetime that this object was last updated by Merge | [optional] [readonly] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**RemoteFields** | [**List&lt;RemoteField&gt;**](RemoteField.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

