# Merge.CRMClient.Model.EngagementRequest
# The Engagement Object ### Description The `Engagement` object is used to represent an interaction noted in a CRM system. ### Usage Example TODO

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Owner** | **Guid?** | The engagement&#39;s owner. | [optional] 
**Content** | **string** | The engagement&#39;s content. | [optional] 
**Subject** | **string** | The engagement&#39;s subject. | [optional] 
**Direction** | **DirectionEnum** | The engagement&#39;s direction. | [optional] 
**EngagementType** | **Guid?** | The engagement type of the engagement. | [optional] 
**StartTime** | **DateTime?** | The time at which the engagement started. | [optional] 
**EndTime** | **DateTime?** | The time at which the engagement ended. | [optional] 
**Account** | **Guid?** | The account of the engagement. | [optional] 
**Contacts** | **List&lt;Guid?&gt;** |  | [optional] 
**IntegrationParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**LinkedAccountParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

