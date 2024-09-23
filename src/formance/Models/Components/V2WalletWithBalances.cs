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
    
    public class V2WalletWithBalances
    {

        /// <summary>
        /// The unique ID of the wallet.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Metadata associated with the wallet.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; } = default!;

        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; } = default!;

        [JsonProperty("balances")]
        public V2WalletWithBalancesBalances Balances { get; set; } = default!;

        [JsonProperty("ledger")]
        public string Ledger { get; set; } = default!;
    }
}