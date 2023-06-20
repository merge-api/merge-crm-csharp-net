# Merge.CRMClient.Model.Account
# The Account Object ### Description The `Account` object is used to represent a company in a CRM system. ### Usage Example TODO

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Owner** | **Guid?** | The account&#39;s owner. | [optional] 
**Name** | **string** | The account&#39;s name. | [optional] 
**Description** | **string** | The account&#39;s description. | [optional] 
**Industry** | **string** | The account&#39;s industry. | [optional] 
**Website** | **string** | The account&#39;s website. | [optional] 
**NumberOfEmployees** | **int?** | The account&#39;s number of employees. | [optional] 
**Addresses** | [**List&lt;Address&gt;**](Address.md) |  | [optional] [readonly] 
**PhoneNumbers** | [**List&lt;PhoneNumber&gt;**](PhoneNumber.md) |  | [optional] [readonly] 
**LastActivityAt** | **DateTime?** | The last date (either most recent or furthest in the future) of when an activity occurs in an account. | [optional] 
**RemoteUpdatedAt** | **DateTime?** | When the CRM system account data was last modified by a user with a login. | [optional] 
**RemoteCreatedAt** | **DateTime?** | When the third party&#39;s account was created. | [optional] 
**RemoteWasDeleted** | **bool** |  | [optional] [readonly] 
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**FieldMappings** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 
**ModifiedAt** | **DateTime** | This is the datetime that this object was last updated by Merge | [optional] [readonly] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**RemoteFields** | [**List&lt;RemoteField&gt;**](RemoteField.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

