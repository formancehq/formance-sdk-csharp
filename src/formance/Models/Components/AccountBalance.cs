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
    using System.Numerics;
    using System;
    using formance.Utils;
    
    public class AccountBalance
    {

        [JsonProperty("accountId")]
        public string AccountId { get; set; } = default!;

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; } = default!;

        [JsonProperty("lastUpdatedAt")]
        public DateTime LastUpdatedAt { get; set; } = default!;

        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("currency")]
        public string Currency { get; set; } = default!;

        [JsonProperty("asset")]
        public string Asset { get; set; } = default!;

        [JsonProperty("balance")]
        public BigInteger Balance { get; set; } = default!;
    }
}