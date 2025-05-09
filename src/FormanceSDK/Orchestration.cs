//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace FormanceSDK
{
    using FormanceSDK.Models.Components;
    using FormanceSDK.Models.Errors;
    using FormanceSDK.Utils;
    using System;

    public interface IOrchestration
    {
        public IFormanceOrchestrationV1 V1 { get; }
        public IFormanceV2 V2 { get; }
    }

    public class Orchestration: IOrchestration
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "1.0.3";
        private const string _sdkGenVersion = "2.558.5";
        private const string _openapiDocVersion = "v3.0.3";
        private const string _userAgent = "speakeasy-sdk/csharp 1.0.3 2.558.5 v3.0.3 FormanceSDK";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<FormanceSDK.Models.Components.Security>? _securitySource;
        public IFormanceOrchestrationV1 V1 { get; private set; }
        public IFormanceV2 V2 { get; private set; }

        public Orchestration(ISpeakeasyHttpClient client, Func<FormanceSDK.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
            V1 = new FormanceOrchestrationV1(_client, _securitySource, _serverUrl, SDKConfiguration);
            V2 = new FormanceV2(_client, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}