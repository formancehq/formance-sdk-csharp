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
    using formance.Models.Components;
    using formance.Utils;
    
    public class ListRunsResponse
    {

        [JsonProperty("data")]
        public List<WorkflowInstance> Data { get; set; } = default!;
    }
}