/* 
 * configapi
 *
 * Config API lets you easily manage configuration at scale.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Cloudmersive.APIClient.NET.Configuration.Api;
using Cloudmersive.APIClient.NET.Configuration.Model;
using Cloudmersive.APIClient.NET.Configuration.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Cloudmersive.APIClient.NET.Configuration.Test
{
    /// <summary>
    ///  Class for testing ListSettingsRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ListSettingsRequestTests
    {
        // TODO uncomment below to declare an instance variable for ListSettingsRequest
        //private ListSettingsRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ListSettingsRequest
            //instance = new ListSettingsRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ListSettingsRequest
        /// </summary>
        [Test]
        public void ListSettingsRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ListSettingsRequest
            //Assert.IsInstanceOfType<ListSettingsRequest> (instance, "variable 'instance' is a ListSettingsRequest");
        }


        /// <summary>
        /// Test the property 'BucketID'
        /// </summary>
        [Test]
        public void BucketIDTest()
        {
            // TODO unit test for the property 'BucketID'
        }
        /// <summary>
        /// Test the property 'BucketSecretKey'
        /// </summary>
        [Test]
        public void BucketSecretKeyTest()
        {
            // TODO unit test for the property 'BucketSecretKey'
        }

    }

}
