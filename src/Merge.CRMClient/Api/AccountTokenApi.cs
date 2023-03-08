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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Merge.CRMClient.Client;
using Merge.CRMClient.Model;

namespace Merge.CRMClient.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccountTokenApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns the account token for the end user with the provided public token.
        /// </remarks>
        /// <exception cref="Merge.CRMClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicToken"></param>
        /// <returns>AccountToken</returns>
        AccountToken AccountTokenRetrieve(string publicToken);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns the account token for the end user with the provided public token.
        /// </remarks>
        /// <exception cref="Merge.CRMClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicToken"></param>
        /// <returns>ApiResponse of AccountToken</returns>
        ApiResponse<AccountToken> AccountTokenRetrieveWithHttpInfo(string publicToken);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccountTokenApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns the account token for the end user with the provided public token.
        /// </remarks>
        /// <exception cref="Merge.CRMClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicToken"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccountToken</returns>
        System.Threading.Tasks.Task<AccountToken> AccountTokenRetrieveAsync(string publicToken, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns the account token for the end user with the provided public token.
        /// </remarks>
        /// <exception cref="Merge.CRMClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicToken"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccountToken)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountToken>> AccountTokenRetrieveWithHttpInfoAsync(string publicToken, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccountTokenApi : IAccountTokenApiSync, IAccountTokenApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AccountTokenApi : IAccountTokenApi
    {
        private Merge.CRMClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTokenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountTokenApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTokenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountTokenApi(String basePath)
        {
            this.Configuration = Merge.CRMClient.Client.Configuration.MergeConfigurations(
                Merge.CRMClient.Client.GlobalConfiguration.Instance,
                new Merge.CRMClient.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Merge.CRMClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Merge.CRMClient.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Merge.CRMClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTokenApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AccountTokenApi(Merge.CRMClient.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Merge.CRMClient.Client.Configuration.MergeConfigurations(
                Merge.CRMClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Merge.CRMClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Merge.CRMClient.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Merge.CRMClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTokenApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AccountTokenApi(Merge.CRMClient.Client.ISynchronousClient client, Merge.CRMClient.Client.IAsynchronousClient asyncClient, Merge.CRMClient.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Merge.CRMClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Merge.CRMClient.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Merge.CRMClient.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Merge.CRMClient.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Merge.CRMClient.Client.ExceptionFactory ExceptionFactory
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
        ///  Returns the account token for the end user with the provided public token.
        /// </summary>
        /// <exception cref="Merge.CRMClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicToken"></param>
        /// <returns>AccountToken</returns>
        public AccountToken AccountTokenRetrieve(string publicToken)
        {
            Merge.CRMClient.Client.ApiResponse<AccountToken> localVarResponse = AccountTokenRetrieveWithHttpInfo(publicToken);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Returns the account token for the end user with the provided public token.
        /// </summary>
        /// <exception cref="Merge.CRMClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicToken"></param>
        /// <returns>ApiResponse of AccountToken</returns>
        public Merge.CRMClient.Client.ApiResponse<AccountToken> AccountTokenRetrieveWithHttpInfo(string publicToken)
        {
            // verify the required parameter 'publicToken' is set
            if (publicToken == null)
                throw new Merge.CRMClient.Client.ApiException(400, "Missing required parameter 'publicToken' when calling AccountTokenApi->AccountTokenRetrieve");

            Merge.CRMClient.Client.RequestOptions localVarRequestOptions = new Merge.CRMClient.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Merge.CRMClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Merge.CRMClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("public_token", Merge.CRMClient.Client.ClientUtils.ParameterToString(publicToken)); // path parameter

            // authentication (tokenAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<AccountToken>("/account-token/{public_token}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AccountTokenRetrieve", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Returns the account token for the end user with the provided public token.
        /// </summary>
        /// <exception cref="Merge.CRMClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicToken"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccountToken</returns>
        public async System.Threading.Tasks.Task<AccountToken> AccountTokenRetrieveAsync(string publicToken, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Merge.CRMClient.Client.ApiResponse<AccountToken> localVarResponse = await AccountTokenRetrieveWithHttpInfoAsync(publicToken, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Returns the account token for the end user with the provided public token.
        /// </summary>
        /// <exception cref="Merge.CRMClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicToken"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccountToken)</returns>
        public async System.Threading.Tasks.Task<Merge.CRMClient.Client.ApiResponse<AccountToken>> AccountTokenRetrieveWithHttpInfoAsync(string publicToken, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'publicToken' is set
            if (publicToken == null)
                throw new Merge.CRMClient.Client.ApiException(400, "Missing required parameter 'publicToken' when calling AccountTokenApi->AccountTokenRetrieve");


            Merge.CRMClient.Client.RequestOptions localVarRequestOptions = new Merge.CRMClient.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Merge.CRMClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Merge.CRMClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("public_token", Merge.CRMClient.Client.ClientUtils.ParameterToString(publicToken)); // path parameter

            // authentication (tokenAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<AccountToken>("/account-token/{public_token}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AccountTokenRetrieve", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
