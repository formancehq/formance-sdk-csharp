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
    
    public class V2TriggerOccurrence
    {

        [JsonProperty("date")]
        public DateTime Date { get; set; } = default!;

        [JsonProperty("workflowInstanceID")]
        public string? WorkflowInstanceID { get; set; }

        [JsonProperty("workflowInstance")]
        public V2WorkflowInstance? WorkflowInstance { get; set; }

        [JsonProperty("triggerID")]
        public string TriggerID { get; set; } = default!;

        [JsonProperty("error")]
        public string? Error { get; set; }

        [JsonProperty("event")]
        public Dictionary<string, object> Event { get; set; } = default!;
    }
}