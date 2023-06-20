# Merge.CRMClient.Model.PatchedTaskRequest
# The Task Object ### Description The `Task` object is used to represent a task, such as a to-do item. ### Usage Example TODO

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Subject** | **string** | The task&#39;s subject. | [optional] 
**Content** | **string** | The task&#39;s content. | [optional] 
**Owner** | **Guid?** | The task&#39;s owner. | [optional] 
**Account** | **Guid?** | The task&#39;s account. | [optional] 
**CompletedDate** | **DateTime?** | When the task is completed. | [optional] 
**DueDate** | **DateTime?** | When the task is due. | [optional] 
**Status** | **TaskStatusEnum** | The task&#39;s status.  * &#x60;OPEN&#x60; - OPEN * &#x60;CLOSED&#x60; - CLOSED | [optional] 
**IntegrationParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**LinkedAccountParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**RemoteFields** | [**List&lt;RemoteFieldRequest&gt;**](RemoteFieldRequest.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

