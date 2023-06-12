# Merge.CRMClient.Model.CustomObjectClass
# The Custom Object Class Object ### Description The `Custom Object Class` object is used to represent a Custom Object Schema in the remote system. ### Usage Example TODO

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Labels** | **Dictionary&lt;string, string&gt;** |  | [optional] [readonly] 
**Fields** | [**List&lt;RemoteFieldClassForCustomObjectClass&gt;**](RemoteFieldClassForCustomObjectClass.md) |  | [optional] [readonly] 
**AssociationTypes** | **List&lt;Dictionary&lt;string, Object&gt;&gt;** |  | [optional] [readonly] 
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**ModifiedAt** | **DateTime** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

