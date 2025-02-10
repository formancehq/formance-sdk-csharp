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
    using FormanceSDK.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Numerics;
    
    public class V3ReversePaymentInitiationRequest
    {

        [JsonProperty("reference")]
        public string Reference { get; set; } = default!;

        [JsonProperty("description")]
        public string Description { get; set; } = default!;

        [JsonProperty("amount")]
        public BigInteger Amount { get; set; } = default!;

        [JsonProperty("asset")]
        public string Asset { get; set; } = default!;

        [JsonProperty("metadata")]
        public Dictionary<string, string>? Metadata { get; set; } = null;
    }
}