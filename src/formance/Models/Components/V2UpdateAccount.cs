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
    
    public class V2UpdateAccount
    {

        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; } = default!;

        [JsonProperty("ledger")]
        public string Ledger { get; set; } = default!;
    }
}