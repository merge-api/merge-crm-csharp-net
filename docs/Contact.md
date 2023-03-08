# Merge.CRMClient.Model.Contact
# The Contact Object ### Description The `Contact` object is used to represent an existing point of contact at a company in a CRM system. ### Usage Example TODO

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirstName** | **string** | The contact&#39;s first name. | [optional] 
**LastName** | **string** | The contact&#39;s last name. | [optional] 
**Account** | **Guid?** | The contact&#39;s account. | [optional] 
**Addresses** | [**List&lt;Address&gt;**](Address.md) |  | [optional] 
**EmailAddresses** | [**List&lt;EmailAddress&gt;**](EmailAddress.md) |  | [optional] 
**PhoneNumbers** | [**List&lt;PhoneNumber&gt;**](PhoneNumber.md) |  | [optional] 
**LastActivityAt** | **DateTime?** | When the contact&#39;s last activity occurred. | [optional] 
**RemoteCreatedAt** | **DateTime?** | When the third party&#39;s contact was created. | [optional] 
**RemoteWasDeleted** | **bool** |  | [optional] [readonly] 
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**FieldMappings** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**RemoteFields** | [**List&lt;RemoteField&gt;**](RemoteField.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

