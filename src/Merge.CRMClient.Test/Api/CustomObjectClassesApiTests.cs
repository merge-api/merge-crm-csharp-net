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
    ///  Class for testing CustomObjectClassesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CustomObjectClassesApiTests : IDisposable
    {
        private CustomObjectClassesApi instance;

        public CustomObjectClassesApiTests()
        {
            instance = new CustomObjectClassesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CustomObjectClassesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CustomObjectClassesApi
            //Assert.IsType<CustomObjectClassesApi>(instance);
        }

        /// <summary>
        /// Test CustomObjectClassesAssociationTypesCreate
        /// </summary>
        [Fact]
        public void CustomObjectClassesAssociationTypesCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid customObjectClassId = null;
            //CRMAssociationTypeEndpointRequest cRMAssociationTypeEndpointRequest = null;
            //bool? isDebugMode = null;
            //bool? runAsync = null;
            //var response = instance.CustomObjectClassesAssociationTypesCreate(xAccountToken, customObjectClassId, cRMAssociationTypeEndpointRequest, isDebugMode, runAsync);
            //Assert.IsType<CRMAssociationTypeResponse>(response);
        }

        /// <summary>
        /// Test CustomObjectClassesAssociationTypesList
        /// </summary>
        [Fact]
        public void CustomObjectClassesAssociationTypesListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid customObjectClassId = null;
            //DateTime? createdAfter = null;
            //DateTime? createdBefore = null;
            //string cursor = null;
            //bool? includeDeletedData = null;
            //bool? includeRemoteData = null;
            //DateTime? modifiedAfter = null;
            //DateTime? modifiedBefore = null;
            //int? pageSize = null;
            //string remoteId = null;
            //var response = instance.CustomObjectClassesAssociationTypesList(xAccountToken, customObjectClassId, createdAfter, createdBefore, cursor, includeDeletedData, includeRemoteData, modifiedAfter, modifiedBefore, pageSize, remoteId);
            //Assert.IsType<PaginatedAssociationTypeList>(response);
        }

        /// <summary>
        /// Test CustomObjectClassesAssociationTypesMetaPostRetrieve
        /// </summary>
        [Fact]
        public void CustomObjectClassesAssociationTypesMetaPostRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid customObjectClassId = null;
            //var response = instance.CustomObjectClassesAssociationTypesMetaPostRetrieve(xAccountToken, customObjectClassId);
            //Assert.IsType<MetaResponse>(response);
        }

        /// <summary>
        /// Test CustomObjectClassesAssociationTypesRetrieve
        /// </summary>
        [Fact]
        public void CustomObjectClassesAssociationTypesRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid customObjectClassId = null;
            //Guid id = null;
            //bool? includeRemoteData = null;
            //var response = instance.CustomObjectClassesAssociationTypesRetrieve(xAccountToken, customObjectClassId, id, includeRemoteData);
            //Assert.IsType<AssociationType>(response);
        }

        /// <summary>
        /// Test CustomObjectClassesCustomObjectsAssociationsList
        /// </summary>
        [Fact]
        public void CustomObjectClassesCustomObjectsAssociationsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid customObjectClassId = null;
            //Guid objectId = null;
            //string associationTypeId = null;
            //DateTime? createdAfter = null;
            //DateTime? createdBefore = null;
            //string cursor = null;
            //bool? includeDeletedData = null;
            //bool? includeRemoteData = null;
            //DateTime? modifiedAfter = null;
            //DateTime? modifiedBefore = null;
            //int? pageSize = null;
            //string remoteId = null;
            //var response = instance.CustomObjectClassesCustomObjectsAssociationsList(xAccountToken, customObjectClassId, objectId, associationTypeId, createdAfter, createdBefore, cursor, includeDeletedData, includeRemoteData, modifiedAfter, modifiedBefore, pageSize, remoteId);
            //Assert.IsType<PaginatedAssociationList>(response);
        }

        /// <summary>
        /// Test CustomObjectClassesCustomObjectsAssociationsUpdate
        /// </summary>
        [Fact]
        public void CustomObjectClassesCustomObjectsAssociationsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid associationTypeId = null;
            //Guid sourceClassId = null;
            //Guid sourceObjectId = null;
            //string targetClassId = null;
            //Guid targetObjectId = null;
            //bool? isDebugMode = null;
            //bool? runAsync = null;
            //var response = instance.CustomObjectClassesCustomObjectsAssociationsUpdate(xAccountToken, associationTypeId, sourceClassId, sourceObjectId, targetClassId, targetObjectId, isDebugMode, runAsync);
            //Assert.IsType<Association>(response);
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

        /// <summary>
        /// Test CustomObjectClassesGeneratorUpdate
        /// </summary>
        [Fact]
        public void CustomObjectClassesGeneratorUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid generatorId = null;
            //bool? isDebugMode = null;
            //bool? runAsync = null;
            //var response = instance.CustomObjectClassesGeneratorUpdate(xAccountToken, generatorId, isDebugMode, runAsync);
            //Assert.IsType<CustomObjectClass>(response);
        }

        /// <summary>
        /// Test CustomObjectClassesList
        /// </summary>
        [Fact]
        public void CustomObjectClassesListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //DateTime? createdAfter = null;
            //DateTime? createdBefore = null;
            //string cursor = null;
            //bool? includeDeletedData = null;
            //bool? includeRemoteData = null;
            //DateTime? modifiedAfter = null;
            //DateTime? modifiedBefore = null;
            //int? pageSize = null;
            //string remoteId = null;
            //var response = instance.CustomObjectClassesList(xAccountToken, createdAfter, createdBefore, cursor, includeDeletedData, includeRemoteData, modifiedAfter, modifiedBefore, pageSize, remoteId);
            //Assert.IsType<PaginatedCustomObjectClassList>(response);
        }

        /// <summary>
        /// Test CustomObjectClassesRetrieve
        /// </summary>
        [Fact]
        public void CustomObjectClassesRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid id = null;
            //bool? includeRemoteData = null;
            //var response = instance.CustomObjectClassesRetrieve(xAccountToken, id, includeRemoteData);
            //Assert.IsType<CustomObjectClass>(response);
        }
    }
}
