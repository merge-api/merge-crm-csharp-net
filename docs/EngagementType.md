# Merge.CRMClient.Model.EngagementType
# The Engagement Type Object ### Description The `Engagement Type` object is used to represent an interaction activity. A given `Engagement` typically has an `Engagement Type` object represented in the engagement_type field. ### Usage Example TODO

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActivityType** | **ActivityTypeEnum** | The engagement type&#39;s activity type. | [optional] 
**Name** | **string** | The engagement type&#39;s name. | [optional] 
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**RemoteFields** | [**List&lt;RemoteField&gt;**](RemoteField.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

