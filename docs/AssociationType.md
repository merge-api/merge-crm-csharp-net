# Merge.CRMClient.Model.AssociationType
# The AssociationType Object ### Description The `Association Type` object represents the relationship between two objects. ### Usage Example TODO

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceObjectClass** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 
**TargetObjectClasses** | [**List&lt;AssociationSubType&gt;**](AssociationSubType.md) |  | [optional] [readonly] 
**RemoteKeyName** | **string** |  | [optional] 
**DisplayName** | **string** |  | [optional] 
**Cardinality** | **CardinalityEnum** |  | [optional] 
**IsRequired** | **bool** |  | [optional] 
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**ModifiedAt** | **DateTime** | This is the datetime that this object was last updated by Merge | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

