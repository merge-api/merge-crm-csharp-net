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
    ///  Class for testing CustomObjectsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CustomObjectsApiTests : IDisposable
    {
        private CustomObjectsApi instance;

        public CustomObjectsApiTests()
        {
            instance = new CustomObjectsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CustomObjectsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CustomObjectsApi
            //Assert.IsType<CustomObjectsApi>(instance);
        }

        /// <summary>
        /// Test CustomObjectClassesCustomObjectsCreate
        /// </summary>
        [Fact]
        public void CustomObjectClassesCustomObjectsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid customObjectClassId = null;
            //CRMCustomObjectEndpointRequest cRMCustomObjectEndpointRequest = null;
            //bool? isDebugMode = null;
            //bool? runAsync = null;
            //var response = instance.CustomObjectClassesCustomObjectsCreate(xAccountToken, customObjectClassId, cRMCustomObjectEndpointRequest, isDebugMode, runAsync);
            //Assert.IsType<CRMCustomObjectResponse>(response);
        }

        /// <summary>
        /// Test CustomObjectClassesCustomObjectsList
        /// </summary>
        [Fact]
        public void CustomObjectClassesCustomObjectsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid customObjectClassId = null;
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
            //var response = instance.CustomObjectClassesCustomObjectsList(xAccountToken, customObjectClassId, createdAfter, createdBefore, cursor, includeDeletedData, includeRemoteData, includeRemoteFields, modifiedAfter, modifiedBefore, pageSize, remoteId);
            //Assert.IsType<PaginatedCustomObjectList>(response);
        }

        /// <summary>
        /// Test CustomObjectClassesCustomObjectsMetaPatchRetrieve
        /// </summary>
        [Fact]
        public void CustomObjectClassesCustomObjectsMetaPatchRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid customObjectClassId = null;
            //Guid id = null;
            //var response = instance.CustomObjectClassesCustomObjectsMetaPatchRetrieve(xAccountToken, customObjectClassId, id);
            //Assert.IsType<MetaResponse>(response);
        }

        /// <summary>
        /// Test CustomObjectClassesCustomObjectsMetaPostRetrieve
        /// </summary>
        [Fact]
        public void CustomObjectClassesCustomObjectsMetaPostRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid customObjectClassId = null;
            //var response = instance.CustomObjectClassesCustomObjectsMetaPostRetrieve(xAccountToken, customObjectClassId);
            //Assert.IsType<MetaResponse>(response);
        }

        /// <summary>
        /// Test CustomObjectClassesCustomObjectsPartialUpdate
        /// </summary>
        [Fact]
        public void CustomObjectClassesCustomObjectsPartialUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid customObjectClassId = null;
            //Guid id = null;
            //PatchedCRMCustomObjectEndpointRequest patchedCRMCustomObjectEndpointRequest = null;
            //bool? isDebugMode = null;
            //bool? runAsync = null;
            //var response = instance.CustomObjectClassesCustomObjectsPartialUpdate(xAccountToken, customObjectClassId, id, patchedCRMCustomObjectEndpointRequest, isDebugMode, runAsync);
            //Assert.IsType<CRMCustomObjectResponse>(response);
        }

        /// <summary>
        /// Test CustomObjectClassesCustomObjectsRetrieve
        /// </summary>
        [Fact]
        public void CustomObjectClassesCustomObjectsRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid customObjectClassId = null;
            //Guid id = null;
            //bool? includeRemoteData = null;
            //bool? includeRemoteFields = null;
            //var response = instance.CustomObjectClassesCustomObjectsRetrieve(xAccountToken, customObjectClassId, id, includeRemoteData, includeRemoteFields);
            //Assert.IsType<CustomObject>(response);
        }
    }
}