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
    using FormanceSDK.Models.Components;
    using FormanceSDK.Utils;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public class V2DebitWalletRequest
    {

        [JsonProperty("amount")]
        public V2Monetary Amount { get; set; } = default!;

        /// <summary>
        /// Set to true to create a pending hold. If false, the wallet will be debited immediately.
        /// </summary>
        [JsonProperty("pending")]
        public bool? Pending { get; set; }

        /// <summary>
        /// Metadata associated with the wallet.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; } = default!;

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("destination")]
        public V2Subject? Destination { get; set; }

        public V2LedgerAccountSubject? GetDestinationAccount()
        {
            return Destination != null ? Destination.V2LedgerAccountSubject : null;
        }

        public V2WalletSubject? GetDestinationWallet()
        {
            return Destination != null ? Destination.V2WalletSubject : null;
        }

        [JsonProperty("balances")]
        public List<string>? Balances { get; set; }

        /// <summary>
        /// cannot be used in conjunction with `pending` property
        /// </summary>
        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }
    }
}