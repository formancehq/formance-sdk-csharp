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
    
    public class V3CreatePaymentRequest
    {

        [JsonProperty("reference")]
        public string Reference { get; set; } = default!;

        [JsonProperty("connectorID")]
        public string ConnectorID { get; set; } = default!;

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; } = default!;

        [JsonProperty("type")]
        public V3PaymentTypeEnum Type { get; set; } = default!;

        [JsonProperty("initialAmount")]
        public BigInteger InitialAmount { get; set; } = default!;

        [JsonProperty("amount")]
        public BigInteger Amount { get; set; } = default!;

        [JsonProperty("asset")]
        public string Asset { get; set; } = default!;

        [JsonProperty("scheme")]
        public string Scheme { get; set; } = default!;

        [JsonProperty("sourceAccountID")]
        public string? SourceAccountID { get; set; }

        [JsonProperty("destinationAccountID")]
        public string? DestinationAccountID { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string>? Metadata { get; set; } = null;

        [JsonProperty("adjustments")]
        public List<V3CreatePaymentAdjustmentRequest>? Adjustments { get; set; }
    }
}