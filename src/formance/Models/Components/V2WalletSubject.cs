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
    using formance.Utils;
    
    public class V2WalletSubject
    {

        [JsonProperty("type")]
        public string Type { get; set; } = default!;

        [JsonProperty("identifier")]
        public string Identifier { get; set; } = default!;

        [JsonProperty("balance")]
        public string? Balance { get; set; }
    }
}