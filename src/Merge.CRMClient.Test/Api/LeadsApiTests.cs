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
    ///  Class for testing LeadsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class LeadsApiTests : IDisposable
    {
        private LeadsApi instance;

        public LeadsApiTests()
        {
            instance = new LeadsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LeadsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' LeadsApi
            //Assert.IsType<LeadsApi>(instance);
        }

        /// <summary>
        /// Test LeadsCreate
        /// </summary>
        [Fact]
        public void LeadsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //LeadEndpointRequest leadEndpointRequest = null;
            //bool? isDebugMode = null;
            //bool? runAsync = null;
            //var response = instance.LeadsCreate(xAccountToken, leadEndpointRequest, isDebugMode, runAsync);
            //Assert.IsType<LeadResponse>(response);
        }

        /// <summary>
        /// Test LeadsList
        /// </summary>
        [Fact]
        public void LeadsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //string convertedAccountId = null;
            //string convertedContactId = null;
            //DateTime? createdAfter = null;
            //DateTime? createdBefore = null;
            //string cursor = null;
            //bool? includeDeletedData = null;
            //bool? includeRemoteData = null;
            //bool? includeRemoteFields = null;
            //DateTime? modifiedAfter = null;
            //DateTime? modifiedBefore = null;
            //string ownerId = null;
            //int? pageSize = null;
            //string remoteId = null;
            //var response = instance.LeadsList(xAccountToken, convertedAccountId, convertedContactId, createdAfter, createdBefore, cursor, includeDeletedData, includeRemoteData, includeRemoteFields, modifiedAfter, modifiedBefore, ownerId, pageSize, remoteId);
            //Assert.IsType<PaginatedLeadList>(response);
        }

        /// <summary>
        /// Test LeadsMetaPostRetrieve
        /// </summary>
        [Fact]
        public void LeadsMetaPostRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //var response = instance.LeadsMetaPostRetrieve(xAccountToken);
            //Assert.IsType<MetaResponse>(response);
        }

        /// <summary>
        /// Test LeadsRemoteFieldClassesList
        /// </summary>
        [Fact]
        public void LeadsRemoteFieldClassesListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //string cursor = null;
            //bool? includeDeletedData = null;
            //bool? includeRemoteData = null;
            //bool? includeRemoteFields = null;
            //int? pageSize = null;
            //var response = instance.LeadsRemoteFieldClassesList(xAccountToken, cursor, includeDeletedData, includeRemoteData, includeRemoteFields, pageSize);
            //Assert.IsType<PaginatedRemoteFieldClassList>(response);
        }

        /// <summary>
        /// Test LeadsRetrieve
        /// </summary>
        [Fact]
        public void LeadsRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid id = null;
            //bool? includeRemoteData = null;
            //bool? includeRemoteFields = null;
            //var response = instance.LeadsRetrieve(xAccountToken, id, includeRemoteData, includeRemoteFields);
            //Assert.IsType<Lead>(response);
        }
    }
}