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
    
    public class V2WorkflowConfig
    {

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("stages")]
        public List<Dictionary<string, object>> Stages { get; set; } = default!;
    }
}