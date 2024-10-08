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
    using formance.Models.Components;
    using formance.Utils;
    
    public class V2PaymentAdjustment
    {

        [JsonProperty("status")]
        public V2PaymentStatus Status { get; set; } = default!;

        [JsonProperty("amount")]
        public BigInteger Amount { get; set; } = default!;

        [JsonProperty("date")]
        public DateTime Date { get; set; } = default!;

        [JsonProperty("raw")]
        public V2PaymentAdjustmentRaw Raw { get; set; } = default!;

        [JsonProperty("absolute")]
        public bool Absolute { get; set; } = default!;
    }
}