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
    using formance.Models.Components;
    using formance.Utils;
    
    public class WorkflowInstanceHistory
    {

        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        [JsonProperty("input")]
        public Stage Input { get; set; } = default!;

        [JsonProperty("error")]
        public string? Error { get; set; }

        [JsonProperty("terminated")]
        public bool Terminated { get; set; } = default!;

        [JsonProperty("startedAt")]
        public DateTime StartedAt { get; set; } = default!;

        [JsonProperty("terminatedAt")]
        public DateTime? TerminatedAt { get; set; }
    }
}