# Merge.CRMClient.Model.Lead
# The Lead Object ### Description The `Lead` object is used to represent an individual who is a potential customer. ### Usage Example TODO

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Owner** | **Guid?** | The lead&#39;s owner. | [optional] 
**LeadSource** | **string** | The lead&#39;s source. | [optional] 
**Title** | **string** | The lead&#39;s title. | [optional] 
**Company** | **string** | The lead&#39;s company. | [optional] 
**FirstName** | **string** | The lead&#39;s first name. | [optional] 
**LastName** | **string** | The lead&#39;s last name. | [optional] 
**Addresses** | [**List&lt;Address&gt;**](Address.md) |  | [optional] [readonly] 
**EmailAddresses** | [**List&lt;EmailAddress&gt;**](EmailAddress.md) |  | [optional] [readonly] 
**PhoneNumbers** | [**List&lt;PhoneNumber&gt;**](PhoneNumber.md) |  | [optional] [readonly] 
**RemoteUpdatedAt** | **DateTime?** | When the third party&#39;s lead was updated. | [optional] 
**RemoteCreatedAt** | **DateTime?** | When the third party&#39;s lead was created. | [optional] 
**ConvertedDate** | **DateTime?** | When the lead was converted. | [optional] 
**ConvertedContact** | **Guid?** | The contact of the converted lead. | [optional] 
**ConvertedAccount** | **Guid?** | The account of the converted lead. | [optional] 
**RemoteWasDeleted** | **bool** |  | [optional] [readonly] 
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**FieldMappings** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**RemoteFields** | [**List&lt;RemoteField&gt;**](RemoteField.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

