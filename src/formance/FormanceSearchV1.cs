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
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;
    using formance.Hooks;
    using formance.Models.Components;
    using formance.Models.Errors;
    using formance.Models.Requests;
    using formance.Utils.Retries;
    using formance.Utils;

    public interface IFormanceSearchV1
    {

        /// <summary>
        /// Get server info
        /// </summary>
        Task<SearchgetServerInfoResponse> SearchgetServerInfoAsync();

        /// <summary>
        /// search.v1
        /// 
        /// <remarks>
        /// Elasticsearch.v1 query engine
        /// </remarks>
        /// </summary>
        Task<SearchResponse> SearchAsync(Query request);
    }

    public class FormanceSearchV1: IFormanceSearchV1
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.0.3";
        private const string _sdkGenVersion = "2.422.22";
        private const string _openapiDocVersion = "v2.1.0-beta.3";
        private const string _userAgent = "speakeasy-sdk/csharp 0.0.3 2.422.22 v2.1.0-beta.3 formance";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<formance.Models.Components.Security>? _securitySource;

        public FormanceSearchV1(ISpeakeasyHttpClient client, Func<formance.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<SearchgetServerInfoResponse> SearchgetServerInfoAsync()
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();

            var urlString = baseUrl + "/api/search/_info";

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("searchgetServerInfo", new List<string> { "auth:read", "search:read" }, _securitySource);

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
                    var obj = ResponseBodyDeserializer.Deserialize<ServerInfo>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new SearchgetServerInfoResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.ServerInfo = obj;
                    return response;
                }

                throw new Models.Errors.SDKException("Unknown content type received", httpRequest, httpResponse);
            }
            else
            {
                throw new Models.Errors.SDKException("API error occurred", httpRequest, httpResponse);
            }
        }

        public async Task<SearchResponse> SearchAsync(Query request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();

            var urlString = baseUrl + "/api/search/";

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "Request", "json", false, false);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("search", new List<string> { "auth:read", "search:write" }, _securitySource);

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
                    var obj = ResponseBodyDeserializer.Deserialize<Response>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new SearchResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.Response = obj;
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