//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace formance
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;
    using formance.Hooks;
    using formance.Models.Components;
    using formance.Models.Errors;
    using formance.Models.Requests;
    using formance.Utils.Retries;
    using formance.Utils;

    /// <summary>
    /// Formance Stack API: Open, modular foundation for unique payments flows<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// # Introduction<br/>
    /// This API is documented in **OpenAPI format**.<br/>
    /// <br/>
    /// # Authentication<br/>
    /// Formance Stack offers one forms of authentication:<br/>
    ///   - OAuth2<br/>
    /// OAuth2 - an open protocol to allow secure authorization in a simple<br/>
    /// and standard method from web, mobile and desktop applications.<br/>
    /// &lt;SecurityDefinitions /&gt;<br/>
    /// 
    /// </remarks>
    /// </summary>
    public interface IFormance
    {
        public IAuth Auth { get; }
        public ILedger Ledger { get; }
        public IPayments Payments { get; }
        public ISearch Search { get; }
        public IWebhooks Webhooks { get; }
        public IWallets Wallets { get; }
        public IOrchestration Orchestration { get; }
        public IReconciliation Reconciliation { get; }

        /// <summary>
        /// Show stack version information
        /// </summary>
        Task<Models.Requests.GetVersionsResponse> GetVersionsAsync();
    }

    public class SDKConfig
    {
        /// <summary>
        /// List of server URLs available to the SDK.
        /// </summary>
        public static readonly string[] ServerList = {
            "http://localhost",
            "https://{stack}.sandbox.formance.cloud",
        };

        public string ServerUrl = "";
        public int ServerIndex = 0;
        public SDKHooks Hooks = new SDKHooks();
        public RetryConfig? RetryConfig = null;

        public string GetTemplatedServerUrl()
        {
            if (!String.IsNullOrEmpty(this.ServerUrl))
            {
                return Utilities.TemplateUrl(Utilities.RemoveSuffix(this.ServerUrl, "/"), new Dictionary<string, string>());
            }
            return Utilities.TemplateUrl(SDKConfig.ServerList[this.ServerIndex], new Dictionary<string, string>());
        }

        public ISpeakeasyHttpClient InitHooks(ISpeakeasyHttpClient client)
        {
            string preHooksUrl = GetTemplatedServerUrl();
            var (postHooksUrl, postHooksClient) = this.Hooks.SDKInit(preHooksUrl, client);
            if (preHooksUrl != postHooksUrl)
            {
                this.ServerUrl = postHooksUrl;
            }
            return postHooksClient;
        }
    }

    /// <summary>
    /// Formance Stack API: Open, modular foundation for unique payments flows<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// # Introduction<br/>
    /// This API is documented in **OpenAPI format**.<br/>
    /// <br/>
    /// # Authentication<br/>
    /// Formance Stack offers one forms of authentication:<br/>
    ///   - OAuth2<br/>
    /// OAuth2 - an open protocol to allow secure authorization in a simple<br/>
    /// and standard method from web, mobile and desktop applications.<br/>
    /// &lt;SecurityDefinitions /&gt;<br/>
    /// 
    /// </remarks>
    /// </summary>
    public class Formance: IFormance
    {
        public SDKConfig SDKConfiguration { get; private set; }

        private const string _language = "csharp";
        private const string _sdkVersion = "0.0.1";
        private const string _sdkGenVersion = "2.421.3";
        private const string _openapiDocVersion = "v2.1.0-beta.2";
        private const string _userAgent = "speakeasy-sdk/csharp 0.0.1 2.421.3 v2.1.0-beta.2 formance";
        private string _serverUrl = "";
        private int _serverIndex = 0;
        private ISpeakeasyHttpClient _client;
        private Func<formance.Models.Components.Security>? _securitySource;
        public IAuth Auth { get; private set; }
        public ILedger Ledger { get; private set; }
        public IPayments Payments { get; private set; }
        public ISearch Search { get; private set; }
        public IWebhooks Webhooks { get; private set; }
        public IWallets Wallets { get; private set; }
        public IOrchestration Orchestration { get; private set; }
        public IReconciliation Reconciliation { get; private set; }

        public Formance(formance.Models.Components.Security? security = null, Func<formance.Models.Components.Security>? securitySource = null, int? serverIndex = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null, RetryConfig? retryConfig = null)
        {
            if (serverIndex != null)
            {
                if (serverIndex.Value < 0 || serverIndex.Value >= SDKConfig.ServerList.Length)
                {
                    throw new Exception($"Invalid server index {serverIndex.Value}");
                }
                _serverIndex = serverIndex.Value;
            }

            if (serverUrl != null)
            {
                if (urlParams != null)
                {
                    serverUrl = Utilities.TemplateUrl(serverUrl, urlParams);
                }
                _serverUrl = serverUrl;
            }

            _client = client ?? new SpeakeasyHttpClient();

            if(securitySource != null)
            {
                _securitySource = securitySource;
            }
            else if(security != null)
            {
                _securitySource = () => security;
            }
            else
            {
                throw new Exception("security and securitySource cannot both be null");
            }

            SDKConfiguration = new SDKConfig()
            {
                ServerIndex = _serverIndex,
                ServerUrl = _serverUrl,
                RetryConfig = retryConfig
            };

            _client = SDKConfiguration.InitHooks(_client);


            Auth = new Auth(_client, _securitySource, _serverUrl, SDKConfiguration);


            Ledger = new Ledger(_client, _securitySource, _serverUrl, SDKConfiguration);


            Payments = new Payments(_client, _securitySource, _serverUrl, SDKConfiguration);


            Search = new Search(_client, _securitySource, _serverUrl, SDKConfiguration);


            Webhooks = new Webhooks(_client, _securitySource, _serverUrl, SDKConfiguration);


            Wallets = new Wallets(_client, _securitySource, _serverUrl, SDKConfiguration);


            Orchestration = new Orchestration(_client, _securitySource, _serverUrl, SDKConfiguration);


            Reconciliation = new Reconciliation(_client, _securitySource, _serverUrl, SDKConfiguration);
        }

        public async Task<Models.Requests.GetVersionsResponse> GetVersionsAsync()
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();

            var urlString = baseUrl + "/versions";

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("getVersions", new List<string> { "auth:read" }, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _client.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == default)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<Models.Components.GetVersionsResponse>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new Models.Requests.GetVersionsResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.GetVersionsResponseValue = obj;
                    return response;
                }

                throw new Models.Errors.SDKException("Unknown content type received", httpRequest, httpResponse);
            }
            else
            {
                throw new Models.Errors.SDKException("API error occurred", httpRequest, httpResponse);
            }
        }
    }
}