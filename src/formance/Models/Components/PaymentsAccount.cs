//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace formance.Models.Components
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System;
    using formance.Models.Components;
    using formance.Utils;
    
    public class PaymentsAccount
    {

        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; } = default!;

        [JsonProperty("reference")]
        public string Reference { get; set; } = default!;

        [JsonProperty("connectorID")]
        public string ConnectorID { get; set; } = default!;

        [JsonProperty("provider")]
        public string? Provider { get; set; }

        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("defaultCurrency")]
        public string DefaultCurrency { get; set; } = default!;

        [JsonProperty("defaultAsset")]
        public string DefaultAsset { get; set; } = default!;

        [JsonProperty("accountName")]
        public string AccountName { get; set; } = default!;

        [JsonProperty("type")]
        public AccountType Type { get; set; } = default!;

        [JsonProperty("pools")]
        public List<string>? Pools { get; set; }

        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Include)]
        public Dictionary<string, string>? Metadata { get; set; }

        [JsonProperty("raw", NullValueHandling = NullValueHandling.Include)]
        public PaymentsAccountRaw? Raw { get; set; }
    }
}