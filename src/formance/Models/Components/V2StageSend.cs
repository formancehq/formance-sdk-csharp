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
    
    public class V2StageSend
    {

        [JsonProperty("amount")]
        public V2Monetary? Amount { get; set; }

        [JsonProperty("destination")]
        public V2StageSendDestination? Destination { get; set; }

        [JsonProperty("source")]
        public V2StageSendSource? Source { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string>? Metadata { get; set; }

        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }
    }
}