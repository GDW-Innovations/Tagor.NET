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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using GDWInnovations.TagorClient.Client;
using GDWInnovations.TagorClient.Model;

namespace GDWInnovations.TagorClient.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICodeApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Code/GetDescription
        /// </summary>
        /// <remarks>
        /// Converts code ids. Pass &#x60;ttCodetabelIDs&#x60; records with either &#x60;Id&#x60; or &#x60;Code&#x60; fields filled in. This endpoint will update the other fields and return the data.
        /// </remarks>
        /// <exception cref="GDWInnovations.TagorClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeGetDescriptionRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CodeGetDescription200Response</returns>
        CodeGetDescription200Response CodeGetDescription(CodeGetDescriptionRequest? codeGetDescriptionRequest = default(CodeGetDescriptionRequest?), int operationIndex = 0);

        /// <summary>
        /// Code/GetDescription
        /// </summary>
        /// <remarks>
        /// Converts code ids. Pass &#x60;ttCodetabelIDs&#x60; records with either &#x60;Id&#x60; or &#x60;Code&#x60; fields filled in. This endpoint will update the other fields and return the data.
        /// </remarks>
        /// <exception cref="GDWInnovations.TagorClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeGetDescriptionRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CodeGetDescription200Response</returns>
        ApiResponse<CodeGetDescription200Response> CodeGetDescriptionWithHttpInfo(CodeGetDescriptionRequest? codeGetDescriptionRequest = default(CodeGetDescriptionRequest?), int operationIndex = 0);
        /// <summary>
        /// Code/GetList
        /// </summary>
        /// <remarks>
        /// Returns a whole list of code ids. This endpoint can be used to populate dropdown lists in a front-end application.
        /// </remarks>
        /// <exception cref="GDWInnovations.TagorClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeGetListRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CodeGetDescription200Response</returns>
        CodeGetDescription200Response CodeGetList(CodeGetListRequest? codeGetListRequest = default(CodeGetListRequest?), int operationIndex = 0);

        /// <summary>
        /// Code/GetList
        /// </summary>
        /// <remarks>
        /// Returns a whole list of code ids. This endpoint can be used to populate dropdown lists in a front-end application.
        /// </remarks>
        /// <exception cref="GDWInnovations.TagorClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeGetListRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CodeGetDescription200Response</returns>
        ApiResponse<CodeGetDescription200Response> CodeGetListWithHttpInfo(CodeGetListRequest? codeGetListRequest = default(CodeGetListRequest?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICodeApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Code/GetDescription
        /// </summary>
        /// <remarks>
        /// Converts code ids. Pass &#x60;ttCodetabelIDs&#x60; records with either &#x60;Id&#x60; or &#x60;Code&#x60; fields filled in. This endpoint will update the other fields and return the data.
        /// </remarks>
        /// <exception cref="GDWInnovations.TagorClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeGetDescriptionRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CodeGetDescription200Response</returns>
        System.Threading.Tasks.Task<CodeGetDescription200Response> CodeGetDescriptionAsync(CodeGetDescriptionRequest? codeGetDescriptionRequest = default(CodeGetDescriptionRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// Code/GetDescription
        /// </summary>
        /// <remarks>
        /// Converts code ids. Pass &#x60;ttCodetabelIDs&#x60; records with either &#x60;Id&#x60; or &#x60;Code&#x60; fields filled in. This endpoint will update the other fields and return the data.
        /// </remarks>
        /// <exception cref="GDWInnovations.TagorClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeGetDescriptionRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CodeGetDescription200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<CodeGetDescription200Response>> CodeGetDescriptionWithHttpInfoAsync(CodeGetDescriptionRequest? codeGetDescriptionRequest = default(CodeGetDescriptionRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        /// <summary>
        /// Code/GetList
        /// </summary>
        /// <remarks>
        /// Returns a whole list of code ids. This endpoint can be used to populate dropdown lists in a front-end application.
        /// </remarks>
        /// <exception cref="GDWInnovations.TagorClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeGetListRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CodeGetDescription200Response</returns>
        System.Threading.Tasks.Task<CodeGetDescription200Response> CodeGetListAsync(CodeGetListRequest? codeGetListRequest = default(CodeGetListRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// Code/GetList
        /// </summary>
        /// <remarks>
        /// Returns a whole list of code ids. This endpoint can be used to populate dropdown lists in a front-end application.
        /// </remarks>
        /// <exception cref="GDWInnovations.TagorClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeGetListRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CodeGetDescription200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<CodeGetDescription200Response>> CodeGetListWithHttpInfoAsync(CodeGetListRequest? codeGetListRequest = default(CodeGetListRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICodeApi : ICodeApiSync, ICodeApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CodeApi : ICodeApi
    {
        private GDWInnovations.TagorClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CodeApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CodeApi(string basePath)
        {
            this.Configuration = GDWInnovations.TagorClient.Client.Configuration.MergeConfigurations(
                GDWInnovations.TagorClient.Client.GlobalConfiguration.Instance,
                new GDWInnovations.TagorClient.Client.Configuration { BasePath = basePath }
            );
            this.Client = new GDWInnovations.TagorClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new GDWInnovations.TagorClient.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = GDWInnovations.TagorClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CodeApi(GDWInnovations.TagorClient.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = GDWInnovations.TagorClient.Client.Configuration.MergeConfigurations(
                GDWInnovations.TagorClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new GDWInnovations.TagorClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new GDWInnovations.TagorClient.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = GDWInnovations.TagorClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public CodeApi(GDWInnovations.TagorClient.Client.ISynchronousClient client, GDWInnovations.TagorClient.Client.IAsynchronousClient asyncClient, GDWInnovations.TagorClient.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = GDWInnovations.TagorClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public GDWInnovations.TagorClient.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public GDWInnovations.TagorClient.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public GDWInnovations.TagorClient.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public GDWInnovations.TagorClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Code/GetDescription Converts code ids. Pass &#x60;ttCodetabelIDs&#x60; records with either &#x60;Id&#x60; or &#x60;Code&#x60; fields filled in. This endpoint will update the other fields and return the data.
        /// </summary>
        /// <exception cref="GDWInnovations.TagorClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeGetDescriptionRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CodeGetDescription200Response</returns>
        public CodeGetDescription200Response CodeGetDescription(CodeGetDescriptionRequest? codeGetDescriptionRequest = default(CodeGetDescriptionRequest?), int operationIndex = 0)
        {
            GDWInnovations.TagorClient.Client.ApiResponse<CodeGetDescription200Response> localVarResponse = CodeGetDescriptionWithHttpInfo(codeGetDescriptionRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Code/GetDescription Converts code ids. Pass &#x60;ttCodetabelIDs&#x60; records with either &#x60;Id&#x60; or &#x60;Code&#x60; fields filled in. This endpoint will update the other fields and return the data.
        /// </summary>
        /// <exception cref="GDWInnovations.TagorClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeGetDescriptionRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CodeGetDescription200Response</returns>
        public GDWInnovations.TagorClient.Client.ApiResponse<CodeGetDescription200Response> CodeGetDescriptionWithHttpInfo(CodeGetDescriptionRequest? codeGetDescriptionRequest = default(CodeGetDescriptionRequest?), int operationIndex = 0)
        {
            GDWInnovations.TagorClient.Client.RequestOptions localVarRequestOptions = new GDWInnovations.TagorClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = GDWInnovations.TagorClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = GDWInnovations.TagorClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = codeGetDescriptionRequest;

            localVarRequestOptions.Operation = "CodeApi.CodeGetDescription";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Pin) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (Orng) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (Hash) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (Tgr) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<CodeGetDescription200Response>("/Code/GetDescription", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CodeGetDescription", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Code/GetDescription Converts code ids. Pass &#x60;ttCodetabelIDs&#x60; records with either &#x60;Id&#x60; or &#x60;Code&#x60; fields filled in. This endpoint will update the other fields and return the data.
        /// </summary>
        /// <exception cref="GDWInnovations.TagorClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeGetDescriptionRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CodeGetDescription200Response</returns>
        public async System.Threading.Tasks.Task<CodeGetDescription200Response> CodeGetDescriptionAsync(CodeGetDescriptionRequest? codeGetDescriptionRequest = default(CodeGetDescriptionRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            GDWInnovations.TagorClient.Client.ApiResponse<CodeGetDescription200Response> localVarResponse = await CodeGetDescriptionWithHttpInfoAsync(codeGetDescriptionRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Code/GetDescription Converts code ids. Pass &#x60;ttCodetabelIDs&#x60; records with either &#x60;Id&#x60; or &#x60;Code&#x60; fields filled in. This endpoint will update the other fields and return the data.
        /// </summary>
        /// <exception cref="GDWInnovations.TagorClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeGetDescriptionRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CodeGetDescription200Response)</returns>
        public async System.Threading.Tasks.Task<GDWInnovations.TagorClient.Client.ApiResponse<CodeGetDescription200Response>> CodeGetDescriptionWithHttpInfoAsync(CodeGetDescriptionRequest? codeGetDescriptionRequest = default(CodeGetDescriptionRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {

            GDWInnovations.TagorClient.Client.RequestOptions localVarRequestOptions = new GDWInnovations.TagorClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = GDWInnovations.TagorClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = GDWInnovations.TagorClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = codeGetDescriptionRequest;

            localVarRequestOptions.Operation = "CodeApi.CodeGetDescription";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Pin) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (Orng) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (Hash) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (Tgr) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<CodeGetDescription200Response>("/Code/GetDescription", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CodeGetDescription", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Code/GetList Returns a whole list of code ids. This endpoint can be used to populate dropdown lists in a front-end application.
        /// </summary>
        /// <exception cref="GDWInnovations.TagorClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeGetListRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CodeGetDescription200Response</returns>
        public CodeGetDescription200Response CodeGetList(CodeGetListRequest? codeGetListRequest = default(CodeGetListRequest?), int operationIndex = 0)
        {
            GDWInnovations.TagorClient.Client.ApiResponse<CodeGetDescription200Response> localVarResponse = CodeGetListWithHttpInfo(codeGetListRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Code/GetList Returns a whole list of code ids. This endpoint can be used to populate dropdown lists in a front-end application.
        /// </summary>
        /// <exception cref="GDWInnovations.TagorClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeGetListRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CodeGetDescription200Response</returns>
        public GDWInnovations.TagorClient.Client.ApiResponse<CodeGetDescription200Response> CodeGetListWithHttpInfo(CodeGetListRequest? codeGetListRequest = default(CodeGetListRequest?), int operationIndex = 0)
        {
            GDWInnovations.TagorClient.Client.RequestOptions localVarRequestOptions = new GDWInnovations.TagorClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = GDWInnovations.TagorClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = GDWInnovations.TagorClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = codeGetListRequest;

            localVarRequestOptions.Operation = "CodeApi.CodeGetList";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Orng) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (Tgr) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<CodeGetDescription200Response>("/Code/GetList", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CodeGetList", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Code/GetList Returns a whole list of code ids. This endpoint can be used to populate dropdown lists in a front-end application.
        /// </summary>
        /// <exception cref="GDWInnovations.TagorClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeGetListRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CodeGetDescription200Response</returns>
        public async System.Threading.Tasks.Task<CodeGetDescription200Response> CodeGetListAsync(CodeGetListRequest? codeGetListRequest = default(CodeGetListRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            GDWInnovations.TagorClient.Client.ApiResponse<CodeGetDescription200Response> localVarResponse = await CodeGetListWithHttpInfoAsync(codeGetListRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Code/GetList Returns a whole list of code ids. This endpoint can be used to populate dropdown lists in a front-end application.
        /// </summary>
        /// <exception cref="GDWInnovations.TagorClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeGetListRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CodeGetDescription200Response)</returns>
        public async System.Threading.Tasks.Task<GDWInnovations.TagorClient.Client.ApiResponse<CodeGetDescription200Response>> CodeGetListWithHttpInfoAsync(CodeGetListRequest? codeGetListRequest = default(CodeGetListRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {

            GDWInnovations.TagorClient.Client.RequestOptions localVarRequestOptions = new GDWInnovations.TagorClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = GDWInnovations.TagorClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = GDWInnovations.TagorClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = codeGetListRequest;

            localVarRequestOptions.Operation = "CodeApi.CodeGetList";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Orng) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (Tgr) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<CodeGetDescription200Response>("/Code/GetList", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CodeGetList", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}