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
    
    public class PostTransaction
    {

        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }

        [JsonProperty("postings")]
        public List<Posting>? Postings { get; set; }

        [JsonProperty("script")]
        public PostTransactionScript? Script { get; set; }

        [JsonProperty("reference")]
        public string? Reference { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, object>? Metadata { get; set; } = null;
    }
}