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

using GDWInnovations.TagorClient.Client;
using GDWInnovations.TagorClient.Api;
// uncomment below to import models
//using GDWInnovations.TagorClient.Model;

namespace GDWInnovations.TagorClient.Test.Api
{
    /// <summary>
    ///  Class for testing DossierApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DossierApiTests : IDisposable
    {
        private DossierApi instance;

        public DossierApiTests()
        {
            instance = new DossierApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DossierApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DossierApi
            //Assert.IsType<DossierApi>(instance);
        }

        /// <summary>
        /// Test DossierAddAttachment
        /// </summary>
        [Fact]
        public void DossierAddAttachmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DossierAddAttachmentRequest? dossierAddAttachmentRequest = null;
            //var response = instance.DossierAddAttachment(dossierAddAttachmentRequest);
            //Assert.IsType<DossierAddAttachment200Response>(response);
        }

        /// <summary>
        /// Test DossierCreateAgenda
        /// </summary>
        [Fact]
        public void DossierCreateAgendaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DossierCreateAgendaRequest? dossierCreateAgendaRequest = null;
            //var response = instance.DossierCreateAgenda(dossierCreateAgendaRequest);
            //Assert.IsType<DossierCreateAgenda200Response>(response);
        }

        /// <summary>
        /// Test DossierCreateInfoLine
        /// </summary>
        [Fact]
        public void DossierCreateInfoLineTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DossierCreateInfoLineRequest? dossierCreateInfoLineRequest = null;
            //var response = instance.DossierCreateInfoLine(dossierCreateInfoLineRequest);
            //Assert.IsType<DossierCreateInfoLine200Response>(response);
        }

        /// <summary>
        /// Test DossierCreateLine
        /// </summary>
        [Fact]
        public void DossierCreateLineTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DossierCreateLineRequest? dossierCreateLineRequest = null;
            //var response = instance.DossierCreateLine(dossierCreateLineRequest);
            //Assert.IsType<DossierCreateLine200Response>(response);
        }

        /// <summary>
        /// Test DossierGet
        /// </summary>
        [Fact]
        public void DossierGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocumentGetRequest? documentGetRequest = null;
            //var response = instance.DossierGet(documentGetRequest);
            //Assert.IsType<DossierGet200Response>(response);
        }

        /// <summary>
        /// Test DossierGetAgenda
        /// </summary>
        [Fact]
        public void DossierGetAgendaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocumentGetRequest? documentGetRequest = null;
            //var response = instance.DossierGetAgenda(documentGetRequest);
            //Assert.IsType<DossierGetAgenda200Response>(response);
        }

        /// <summary>
        /// Test DossierGetAppearance
        /// </summary>
        [Fact]
        public void DossierGetAppearanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocumentGetRequest? documentGetRequest = null;
            //var response = instance.DossierGetAppearance(documentGetRequest);
            //Assert.IsType<DossierGetAppearance200Response>(response);
        }

        /// <summary>
        /// Test DossierGetBalances
        /// </summary>
        [Fact]
        public void DossierGetBalancesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocumentGetRequest? documentGetRequest = null;
            //var response = instance.DossierGetBalances(documentGetRequest);
            //Assert.IsType<DossierGetBalances200Response>(response);
        }

        /// <summary>
        /// Test DossierGetByDefendant
        /// </summary>
        [Fact]
        public void DossierGetByDefendantTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DossierGetByDefendantRequest? dossierGetByDefendantRequest = null;
            //var response = instance.DossierGetByDefendant(dossierGetByDefendantRequest);
            //Assert.IsType<DossierGetByDefendant200Response>(response);
        }

        /// <summary>
        /// Test DossierGetCorrespondence
        /// </summary>
        [Fact]
        public void DossierGetCorrespondenceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocumentGetRequest? documentGetRequest = null;
            //var response = instance.DossierGetCorrespondence(documentGetRequest);
            //Assert.IsType<DossierGetCorrespondence200Response>(response);
        }

        /// <summary>
        /// Test DossierGetInfo
        /// </summary>
        [Fact]
        public void DossierGetInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocumentGetRequest? documentGetRequest = null;
            //var response = instance.DossierGetInfo(documentGetRequest);
            //Assert.IsType<DossierGetInfo200Response>(response);
        }

        /// <summary>
        /// Test DossierGetLines
        /// </summary>
        [Fact]
        public void DossierGetLinesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CodeGetListRequest? codeGetListRequest = null;
            //var response = instance.DossierGetLines(codeGetListRequest);
            //Assert.IsType<DossierGetLines200Response>(response);
        }

        /// <summary>
        /// Test DossierGetParties
        /// </summary>
        [Fact]
        public void DossierGetPartiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocumentGetRequest? documentGetRequest = null;
            //var response = instance.DossierGetParties(documentGetRequest);
            //Assert.IsType<ConfigInfo200Response>(response);
        }

        /// <summary>
        /// Test DossierGetPaymentPlans
        /// </summary>
        [Fact]
        public void DossierGetPaymentPlansTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocumentGetRequest? documentGetRequest = null;
            //var response = instance.DossierGetPaymentPlans(documentGetRequest);
            //Assert.IsType<DossierGetPaymentPlans200Response>(response);
        }

        /// <summary>
        /// Test DossierGetSub
        /// </summary>
        [Fact]
        public void DossierGetSubTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocumentGetRequest? documentGetRequest = null;
            //var response = instance.DossierGetSub(documentGetRequest);
            //Assert.IsType<DossierGetSub200Response>(response);
        }

        /// <summary>
        /// Test DossierGetTitle
        /// </summary>
        [Fact]
        public void DossierGetTitleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocumentGetRequest? documentGetRequest = null;
            //var response = instance.DossierGetTitle(documentGetRequest);
            //Assert.IsType<DossierGetTitle200Response>(response);
        }

        /// <summary>
        /// Test DossierSearch
        /// </summary>
        [Fact]
        public void DossierSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DossierSearchRequest? dossierSearchRequest = null;
            //var response = instance.DossierSearch(dossierSearchRequest);
            //Assert.IsType<DossierSearch200Response>(response);
        }

        /// <summary>
        /// Test DossierStop
        /// </summary>
        [Fact]
        public void DossierStopTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocumentGetRequest? documentGetRequest = null;
            //var response = instance.DossierStop(documentGetRequest);
            //Assert.IsType<DossierGet200Response>(response);
        }
    }
}