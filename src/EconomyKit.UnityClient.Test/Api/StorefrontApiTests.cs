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
    ///  Class for testing StorefrontApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class StorefrontApiTests
    {
        private StorefrontApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new StorefrontApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StorefrontApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' StorefrontApi
            //Assert.IsInstanceOf(typeof(StorefrontApi), instance);
        }

        
        /// <summary>
        /// Test GetStorefront
        /// </summary>
        [Test]
        public void GetStorefrontTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? storefront = null;
            //Guid? app = null;
            //Guid? player = null;
            //var response = instance.GetStorefront(storefront, app, player);
            //Assert.IsInstanceOf(typeof(StorefrontResult), response, "response is StorefrontResult");
        }
        
        /// <summary>
        /// Test GetStorefrontitem
        /// </summary>
        [Test]
        public void GetStorefrontitemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? id = null;
            //var response = instance.GetStorefrontitem(id);
            //Assert.IsInstanceOf(typeof(StorefrontItemResult), response, "response is StorefrontItemResult");
        }
        
    }

}
