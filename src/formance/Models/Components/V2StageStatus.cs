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
    using System;
    using formance.Utils;
    
    public class V2StageStatus
    {

        [JsonProperty("stage")]
        public double Stage { get; set; } = default!;

        [JsonProperty("instanceID")]
        public string InstanceID { get; set; } = default!;

        [JsonProperty("startedAt")]
        public DateTime StartedAt { get; set; } = default!;

        [JsonProperty("terminatedAt")]
        public DateTime? TerminatedAt { get; set; }

        [JsonProperty("error")]
        public string? Error { get; set; }
    }
}