# Merge.CRMClient.Model.Opportunity
# The Opportunity Object ### Description The `Opportunity` object is used to represent a deal opportunity in a CRM system. ### Usage Example TODO

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The opportunity&#39;s name. | [optional] 
**Description** | **string** | The opportunity&#39;s description. | [optional] 
**Amount** | **int?** | The opportunity&#39;s amount. | [optional] 
**Owner** | **Guid?** | The opportunity&#39;s owner. | [optional] 
**Account** | **Guid?** | The account of the opportunity. | [optional] 
**Stage** | **Guid?** | The stage of the opportunity. | [optional] 
**Status** | **OpportunityStatusEnum** | The opportunity&#39;s status.  * &#x60;OPEN&#x60; - OPEN * &#x60;WON&#x60; - WON * &#x60;LOST&#x60; - LOST | [optional] 
**LastActivityAt** | **DateTime?** | When the opportunity&#39;s last activity occurred. | [optional] 
**CloseDate** | **DateTime?** | When the opportunity was closed. | [optional] 
**RemoteCreatedAt** | **DateTime?** | When the third party&#39;s opportunity was created. | [optional] 
**RemoteWasDeleted** | **bool** |  | [optional] [readonly] 
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**FieldMappings** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 
**ModifiedAt** | **DateTime** | This is the datetime that this object was last updated by Merge | [optional] [readonly] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**RemoteFields** | [**List&lt;RemoteField&gt;**](RemoteField.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

