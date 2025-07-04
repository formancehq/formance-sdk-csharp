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

    public interface IWebhooks
    {
        public IFormanceWebhooksV1 V1 { get; }
    }

    public class Webhooks: IWebhooks
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "1.1.0";
        private const string _sdkGenVersion = "2.630.9";
        private const string _openapiDocVersion = "v3.0.5";
        public IFormanceWebhooksV1 V1 { get; private set; }

        public Webhooks(SDKConfig config)
        {
            SDKConfiguration = config;
            V1 = new FormanceWebhooksV1(SDKConfiguration);
        }
    }
}