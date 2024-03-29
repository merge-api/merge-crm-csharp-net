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
    ///  Class for testing UsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UsersApiTests : IDisposable
    {
        private UsersApi instance;

        public UsersApiTests()
        {
            instance = new UsersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UsersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UsersApi
            //Assert.IsType<UsersApi>(instance);
        }

        /// <summary>
        /// Test UsersIgnoreCreate
        /// </summary>
        [Fact]
        public void UsersIgnoreCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid modelId = null;
            //IgnoreCommonModelRequest ignoreCommonModelRequest = null;
            //instance.UsersIgnoreCreate(xAccountToken, modelId, ignoreCommonModelRequest);
        }

        /// <summary>
        /// Test UsersList
        /// </summary>
        [Fact]
        public void UsersListTest()
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
            //var response = instance.UsersList(xAccountToken, createdAfter, createdBefore, cursor, includeDeletedData, includeRemoteData, includeRemoteFields, modifiedAfter, modifiedBefore, pageSize, remoteId);
            //Assert.IsType<PaginatedUserList>(response);
        }

        /// <summary>
        /// Test UsersRemoteFieldClassesList
        /// </summary>
        [Fact]
        public void UsersRemoteFieldClassesListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //string cursor = null;
            //bool? includeDeletedData = null;
            //bool? includeRemoteData = null;
            //bool? includeRemoteFields = null;
            //int? pageSize = null;
            //var response = instance.UsersRemoteFieldClassesList(xAccountToken, cursor, includeDeletedData, includeRemoteData, includeRemoteFields, pageSize);
            //Assert.IsType<PaginatedRemoteFieldClassList>(response);
        }

        /// <summary>
        /// Test UsersRetrieve
        /// </summary>
        [Fact]
        public void UsersRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid id = null;
            //bool? includeRemoteData = null;
            //bool? includeRemoteFields = null;
            //var response = instance.UsersRetrieve(xAccountToken, id, includeRemoteData, includeRemoteFields);
            //Assert.IsType<User>(response);
        }
    }
}
