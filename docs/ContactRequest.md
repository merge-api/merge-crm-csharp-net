# Merge.CRMClient.Model.ContactRequest
# The Contact Object ### Description The `Contact` object is used to represent an existing point of contact at a company in a CRM system. ### Usage Example TODO

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirstName** | **string** | The contact&#39;s first name. | [optional] 
**LastName** | **string** | The contact&#39;s last name. | [optional] 
**Account** | **Guid?** | The contact&#39;s account. | [optional] 
**Addresses** | [**List&lt;AddressRequest&gt;**](AddressRequest.md) |  | [optional] 
**EmailAddresses** | [**List&lt;EmailAddressRequest&gt;**](EmailAddressRequest.md) |  | [optional] 
**PhoneNumbers** | [**List&lt;PhoneNumberRequest&gt;**](PhoneNumberRequest.md) |  | [optional] 
**LastActivityAt** | **DateTime?** | When the contact&#39;s last activity occurred. | [optional] 
**IntegrationParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**LinkedAccountParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**RemoteFields** | [**List&lt;RemoteFieldRequest&gt;**](RemoteFieldRequest.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

