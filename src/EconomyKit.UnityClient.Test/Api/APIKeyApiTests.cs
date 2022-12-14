/*
 * EconomyKit API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * 
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using EconomyKit.UnityClient.Client;
using EconomyKit.UnityClient.Api;
using EconomyKit.UnityClient.Model;

namespace EconomyKit.UnityClient.Test
{
    /// <summary>
    ///  Class for testing APIKeyApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class APIKeyApiTests
    {
        private APIKeyApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new APIKeyApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of APIKeyApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' APIKeyApi
            //Assert.IsInstanceOf(typeof(APIKeyApi), instance);
        }

        
        /// <summary>
        /// Test ProvisionAPIKey
        /// </summary>
        [Test]
        public void ProvisionAPIKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProvisionAPIKeyBody provisionAPIKeyBody = null;
            //var response = instance.ProvisionAPIKey(provisionAPIKeyBody);
            //Assert.IsInstanceOf(typeof(ProvisionAPIKeyResponse), response, "response is ProvisionAPIKeyResponse");
        }
        
    }

}
