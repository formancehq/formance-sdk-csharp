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
    
    public class V2Transaction
    {

        [JsonProperty("insertedAt")]
        public DateTime? InsertedAt { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; } = default!;

        [JsonProperty("postings")]
        public List<V2Posting> Postings { get; set; } = default!;

        [JsonProperty("reference")]
        public string? Reference { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; } = default!;

        [JsonProperty("id")]
        public BigInteger Id { get; set; } = default!;

        [JsonProperty("reverted")]
        public bool Reverted { get; set; } = default!;

        [JsonProperty("revertedAt")]
        public DateTime? RevertedAt { get; set; }

        [JsonProperty("preCommitVolumes")]
        public Dictionary<string, Dictionary<string, V2Volume>>? PreCommitVolumes { get; set; }

        [JsonProperty("postCommitVolumes")]
        public Dictionary<string, Dictionary<string, V2Volume>>? PostCommitVolumes { get; set; }

        [JsonProperty("preCommitEffectiveVolumes")]
        public Dictionary<string, Dictionary<string, V2Volume>>? PreCommitEffectiveVolumes { get; set; }

        [JsonProperty("postCommitEffectiveVolumes")]
        public Dictionary<string, Dictionary<string, V2Volume>>? PostCommitEffectiveVolumes { get; set; }
    }
}