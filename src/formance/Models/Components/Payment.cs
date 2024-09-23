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
    using System.Numerics;
    using System;
    using formance.Models.Components;
    using formance.Utils;
    
    public class Payment
    {

        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        [JsonProperty("reference")]
        public string Reference { get; set; } = default!;

        [JsonProperty("sourceAccountID")]
        public string SourceAccountID { get; set; } = default!;

        [JsonProperty("destinationAccountID")]
        public string DestinationAccountID { get; set; } = default!;

        [JsonProperty("connectorID")]
        public string ConnectorID { get; set; } = default!;

        [JsonProperty("provider")]
        public Connector? Provider { get; set; }

        [JsonProperty("type")]
        public PaymentType Type { get; set; } = default!;

        [JsonProperty("status")]
        public PaymentStatus Status { get; set; } = default!;

        [JsonProperty("initialAmount")]
        public BigInteger InitialAmount { get; set; } = default!;

        [JsonProperty("amount")]
        public BigInteger Amount { get; set; } = default!;

        [JsonProperty("scheme")]
        public PaymentScheme Scheme { get; set; } = default!;

        [JsonProperty("asset")]
        public string Asset { get; set; } = default!;

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; } = default!;

        [JsonProperty("raw", NullValueHandling = NullValueHandling.Include)]
        public Raw? Raw { get; set; }

        [JsonProperty("adjustments")]
        public List<PaymentAdjustment> Adjustments { get; set; } = default!;

        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Include)]
        public Dictionary<string, string>? Metadata { get; set; }
    }
}