# Merge.CRMClient.Model.Task
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
**Status** | **TaskStatusEnum** | The task&#39;s status. | [optional] 
**RemoteWasDeleted** | **bool** | Indicates whether or not this object has been deleted by third party webhooks. | [optional] [readonly] 
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**FieldMappings** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**RemoteFields** | [**List&lt;RemoteField&gt;**](RemoteField.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

