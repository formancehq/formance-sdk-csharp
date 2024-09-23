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
    using System;
    using formance.Models.Components;
    using formance.Utils;
    
    public class OrchestrationCreditWalletRequest
    {

        [JsonProperty("amount")]
        public Monetary Amount { get; set; } = default!;

        /// <summary>
        /// Metadata associated with the wallet.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; } = default!;

        [JsonProperty("reference")]
        public string? Reference { get; set; }

        [JsonProperty("sources")]
        public List<Subject> Sources { get; set; } = default!;

        /// <summary>
        /// The balance to credit
        /// </summary>
        [JsonProperty("balance")]
        public string? Balance { get; set; }

        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }
    }
}