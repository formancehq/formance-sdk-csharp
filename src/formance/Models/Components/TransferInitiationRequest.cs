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
    
    public class TransferInitiationRequest
    {

        [JsonProperty("reference")]
        public string Reference { get; set; } = default!;

        [JsonProperty("scheduledAt")]
        public DateTime ScheduledAt { get; set; } = default!;

        [JsonProperty("description")]
        public string Description { get; set; } = default!;

        [JsonProperty("sourceAccountID")]
        public string SourceAccountID { get; set; } = default!;

        [JsonProperty("destinationAccountID")]
        public string DestinationAccountID { get; set; } = default!;

        [JsonProperty("connectorID")]
        public string? ConnectorID { get; set; }

        [JsonProperty("provider")]
        public Connector? Provider { get; set; }

        [JsonProperty("type")]
        public TransferInitiationRequestType Type { get; set; } = default!;

        [JsonProperty("amount")]
        public BigInteger Amount { get; set; } = default!;

        [JsonProperty("asset")]
        public string Asset { get; set; } = default!;

        [JsonProperty("validated")]
        public bool Validated { get; set; } = default!;

        [JsonProperty("metadata")]
        public Dictionary<string, string>? Metadata { get; set; } = null;
    }
}