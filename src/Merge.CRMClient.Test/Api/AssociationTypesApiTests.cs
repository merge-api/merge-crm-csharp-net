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
    ///  Class for testing AssociationTypesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AssociationTypesApiTests : IDisposable
    {
        private AssociationTypesApi instance;

        public AssociationTypesApiTests()
        {
            instance = new AssociationTypesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AssociationTypesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AssociationTypesApi
            //Assert.IsType<AssociationTypesApi>(instance);
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
    }
}
