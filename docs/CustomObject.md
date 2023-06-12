# Merge.CRMClient.Model.CustomObject
# The CustomObject Object ### Description The `Custom Object` record refers to an instance of a Custom Object Class. ### Usage Example TODO

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectClass** | **Guid?** |  | [optional] 
**Fields** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**Id** | **Guid** |  | [optional] [readonly] 
**ModifiedAt** | **DateTime** | This is the datetime that this object was last updated by Merge | [optional] [readonly] 
**RemoteFields** | [**List&lt;RemoteField&gt;**](RemoteField.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

