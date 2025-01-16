/*
 * Tagor API
 *
 * Release date: 29/09/2022  ## REQUIREMENTS This version __requires__ Tagor >= 2.00.0000B0. Use [`Config/Info`](#operation/ConfigInfo) to get the active API version.  ## CHANGELOG - New [`Dossier/CreateAgenda`](#operation/DossierCreateAgenda) endpoint. - New return values in GetAgenda 'TJOB_Id, TJOBM_Id, TUSER_Id, Manueel and IsGeblokkeerd' - In CreateLine you can now add if the line is fixed with 'IsFixed' - In CreateLine you can now add a subarray with the intrests  ## INFO - Using the download button at the top you can import this collection of endpoints in **Postman** - In general all TQ(...)_Id fields are default fields which you can translate with the [`Code/GetDescription`](#operation/CodeGetDescription) endpoint. If you need an id to post to one of the endpoints you can use the [`Code/GetList`](#operation/CodeGetList) endpoint to get all possible values or [`Code/GetDescription`](#operation/CodeGetDescription) to get a value by code. These id's will be marked as `code id` in the documentation. - We chose to return all ids as string because these are 64bit integers which are too big for javascript to handle. - All italic text below the endpoint description is meant for people with access to Tagor. - The user needs an email address configured in Tagor for the services to work properly. - Pass the `Accept` header with `application/json` as value to have the server return errors in json format. - Most endpoints can be batched/paged by passing a `BATCH-SIZE` and `BATCH-NUMBER` record in `dsWebContext`.  # AUTHENTICATION Pass your token via an `Authorization` header like this: `Authorization: {bearer_format} {token}`.  ex: `Authorization: TGR IcoQbVw7wE...PPUPda61ET` <!- - ReDoc-Inject: <security-definitions> - ->
 *
 * The version of the OpenAPI document: 2.00.0000B1
 * Contact: info@organi.be
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

using TagorClient.Client;
using TagorClient.Api;
// uncomment below to import models
//using TagorClient.Model;

namespace TagorClient.Test.Api
{
    /// <summary>
    ///  Class for testing UserApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UserApiTests : IDisposable
    {
        private UserApi instance;

        public UserApiTests()
        {
            instance = new UserApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UserApi
            //Assert.IsType<UserApi>(instance);
        }

        /// <summary>
        /// Test UserAdd
        /// </summary>
        [Fact]
        public void UserAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserAddRequest? userAddRequest = null;
            //var response = instance.UserAdd(userAddRequest);
            //Assert.IsType<UserAdd200Response>(response);
        }

        /// <summary>
        /// Test UserCanAccess
        /// </summary>
        [Fact]
        public void UserCanAccessTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CodeGetListRequest? codeGetListRequest = null;
            //var response = instance.UserCanAccess(codeGetListRequest);
            //Assert.IsType<UserCanAccess200Response>(response);
        }

        /// <summary>
        /// Test UserGet
        /// </summary>
        [Fact]
        public void UserGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserGetRequest? userGetRequest = null;
            //var response = instance.UserGet(userGetRequest);
            //Assert.IsType<UserGet200Response>(response);
        }

        /// <summary>
        /// Test UserGetPermissions
        /// </summary>
        [Fact]
        public void UserGetPermissionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CodeGetListRequest? codeGetListRequest = null;
            //var response = instance.UserGetPermissions(codeGetListRequest);
            //Assert.IsType<UserGetPermissions200Response>(response);
        }

        /// <summary>
        /// Test UserGetPermissionsList
        /// </summary>
        [Fact]
        public void UserGetPermissionsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CodeGetListRequest? codeGetListRequest = null;
            //var response = instance.UserGetPermissionsList(codeGetListRequest);
            //Assert.IsType<UserGetPermissionsList200Response>(response);
        }

        /// <summary>
        /// Test UserSavePermissions
        /// </summary>
        [Fact]
        public void UserSavePermissionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserSavePermissionsRequest? userSavePermissionsRequest = null;
            //var response = instance.UserSavePermissions(userSavePermissionsRequest);
            //Assert.IsType<UserGetPermissions200Response>(response);
        }

        /// <summary>
        /// Test UserSavePermissionsList
        /// </summary>
        [Fact]
        public void UserSavePermissionsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserSavePermissionsListRequest? userSavePermissionsListRequest = null;
            //var response = instance.UserSavePermissionsList(userSavePermissionsListRequest);
            //Assert.IsType<UserGetPermissionsList200Response>(response);
        }
    }
}