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
    using formance.Utils;
    
    public class TriggerData
    {

        [JsonProperty("event")]
        public string Event { get; set; } = default!;

        [JsonProperty("workflowID")]
        public string WorkflowID { get; set; } = default!;

        [JsonProperty("filter")]
        public string? Filter { get; set; }

        [JsonProperty("vars")]
        public Dictionary<string, object>? Vars { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}