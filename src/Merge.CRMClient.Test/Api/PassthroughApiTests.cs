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
    ///  Class for testing PassthroughApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PassthroughApiTests : IDisposable
    {
        private PassthroughApi instance;

        public PassthroughApiTests()
        {
            instance = new PassthroughApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PassthroughApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PassthroughApi
            //Assert.IsType<PassthroughApi>(instance);
        }

        /// <summary>
        /// Test PassthroughCreate
        /// </summary>
        [Fact]
        public void PassthroughCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //DataPassthroughRequest dataPassthroughRequest = null;
            //var response = instance.PassthroughCreate(xAccountToken, dataPassthroughRequest);
            //Assert.IsType<RemoteResponse>(response);
        }
    }
}
