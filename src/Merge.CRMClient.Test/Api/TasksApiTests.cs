/*
 * Merge CRM API
 *
 * The unified API for building rich integrations with multiple CRM platforms.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: hello@merge.dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Merge.CRMClient.Client;
using Merge.CRMClient.Api;
// uncomment below to import models
//using Merge.CRMClient.Model;

namespace Merge.CRMClient.Test.Api
{
    /// <summary>
    ///  Class for testing TasksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TasksApiTests : IDisposable
    {
        private TasksApi instance;

        public TasksApiTests()
        {
            instance = new TasksApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TasksApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TasksApi
            //Assert.IsType<TasksApi>(instance);
        }

        /// <summary>
        /// Test TasksCreate
        /// </summary>
        [Fact]
        public void TasksCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //TaskEndpointRequest taskEndpointRequest = null;
            //bool? isDebugMode = null;
            //bool? runAsync = null;
            //var response = instance.TasksCreate(xAccountToken, taskEndpointRequest, isDebugMode, runAsync);
            //Assert.IsType<TaskResponse>(response);
        }

        /// <summary>
        /// Test TasksList
        /// </summary>
        [Fact]
        public void TasksListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //DateTime? createdAfter = null;
            //DateTime? createdBefore = null;
            //string cursor = null;
            //bool? includeDeletedData = null;
            //bool? includeRemoteData = null;
            //bool? includeRemoteFields = null;
            //DateTime? modifiedAfter = null;
            //DateTime? modifiedBefore = null;
            //int? pageSize = null;
            //string remoteId = null;
            //var response = instance.TasksList(xAccountToken, createdAfter, createdBefore, cursor, includeDeletedData, includeRemoteData, includeRemoteFields, modifiedAfter, modifiedBefore, pageSize, remoteId);
            //Assert.IsType<PaginatedTaskList>(response);
        }

        /// <summary>
        /// Test TasksMetaPatchRetrieve
        /// </summary>
        [Fact]
        public void TasksMetaPatchRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid id = null;
            //var response = instance.TasksMetaPatchRetrieve(xAccountToken, id);
            //Assert.IsType<MetaResponse>(response);
        }

        /// <summary>
        /// Test TasksMetaPostRetrieve
        /// </summary>
        [Fact]
        public void TasksMetaPostRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //var response = instance.TasksMetaPostRetrieve(xAccountToken);
            //Assert.IsType<MetaResponse>(response);
        }

        /// <summary>
        /// Test TasksPartialUpdate
        /// </summary>
        [Fact]
        public void TasksPartialUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid id = null;
            //PatchedTaskEndpointRequest patchedTaskEndpointRequest = null;
            //bool? isDebugMode = null;
            //bool? runAsync = null;
            //var response = instance.TasksPartialUpdate(xAccountToken, id, patchedTaskEndpointRequest, isDebugMode, runAsync);
            //Assert.IsType<TaskResponse>(response);
        }

        /// <summary>
        /// Test TasksRemoteFieldClassesList
        /// </summary>
        [Fact]
        public void TasksRemoteFieldClassesListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //string cursor = null;
            //bool? includeDeletedData = null;
            //bool? includeRemoteData = null;
            //bool? includeRemoteFields = null;
            //int? pageSize = null;
            //var response = instance.TasksRemoteFieldClassesList(xAccountToken, cursor, includeDeletedData, includeRemoteData, includeRemoteFields, pageSize);
            //Assert.IsType<PaginatedRemoteFieldClassList>(response);
        }

        /// <summary>
        /// Test TasksRetrieve
        /// </summary>
        [Fact]
        public void TasksRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid id = null;
            //bool? includeRemoteData = null;
            //bool? includeRemoteFields = null;
            //var response = instance.TasksRetrieve(xAccountToken, id, includeRemoteData, includeRemoteFields);
            //Assert.IsType<Task>(response);
        }
    }
}
