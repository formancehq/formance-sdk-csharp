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
    
    public class LedgerStorage
    {

        [JsonProperty("driver")]
        public string Driver { get; set; } = default!;

        [JsonProperty("ledgers")]
        public List<string> Ledgers { get; set; } = default!;
    }
}