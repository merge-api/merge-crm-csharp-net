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
