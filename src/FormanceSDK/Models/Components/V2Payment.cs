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
    
    public class V2Payment
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
        public V2Connector? Provider { get; set; }

        [JsonProperty("type")]
        public V2PaymentType Type { get; set; } = default!;

        [JsonProperty("status")]
        public V2PaymentStatus Status { get; set; } = default!;

        [JsonProperty("initialAmount")]
        public BigInteger InitialAmount { get; set; } = default!;

        [JsonProperty("scheme")]
        public V2PaymentScheme Scheme { get; set; } = default!;

        [JsonProperty("asset")]
        public string Asset { get; set; } = default!;

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; } = default!;

        [JsonProperty("raw", NullValueHandling = NullValueHandling.Include)]
        public V2PaymentRaw? Raw { get; set; }

        [JsonProperty("adjustments")]
        public List<V2PaymentAdjustment> Adjustments { get; set; } = default!;

        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Include)]
        public V2PaymentMetadata? Metadata { get; set; }
    }
}