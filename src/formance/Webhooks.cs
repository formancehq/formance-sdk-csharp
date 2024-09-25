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
    using System;
    using formance.Models.Components;
    using formance.Models.Errors;
    using formance.Utils;

    public interface IWebhooks
    {
        public IFormanceWebhooksV1 V1 { get; }
    }

    public class Webhooks: IWebhooks
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
        public IFormanceWebhooksV1 V1 { get; private set; }

        public Webhooks(ISpeakeasyHttpClient client, Func<formance.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
            V1 = new FormanceWebhooksV1(_client, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}