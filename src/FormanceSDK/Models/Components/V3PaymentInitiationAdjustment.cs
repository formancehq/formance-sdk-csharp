//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace FormanceSDK.Models.Components
{
    using FormanceSDK.Models.Components;
    using FormanceSDK.Utils;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    
    public class V3PaymentInitiationAdjustment
    {

        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; } = default!;

        [JsonProperty("status")]
        public V3PaymentInitiationStatusEnum Status { get; set; } = default!;

        [JsonProperty("amount")]
        public BigInteger? Amount { get; set; }

        [JsonProperty("asset")]
        public string? Asset { get; set; }

        [JsonProperty("error")]
        public string? Error { get; set; } = null;

        [JsonProperty("metadata")]
        public Dictionary<string, string>? Metadata { get; set; } = null;
    }
}