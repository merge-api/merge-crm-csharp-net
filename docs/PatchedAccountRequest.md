# Merge.CRMClient.Model.PatchedAccountRequest
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
**LastActivityAt** | **DateTime?** | The last date (either most recent or furthest in the future) of when an activity occurs in an account. | [optional] 
**IntegrationParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**LinkedAccountParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**RemoteFields** | [**List&lt;RemoteFieldRequest&gt;**](RemoteFieldRequest.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

