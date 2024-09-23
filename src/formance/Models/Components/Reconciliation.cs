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
    using System.Numerics;
    using System;
    using formance.Utils;
    
    public class Reconciliation
    {

        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        [JsonProperty("policyID")]
        public string PolicyID { get; set; } = default!;

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; } = default!;

        [JsonProperty("reconciledAtLedger")]
        public DateTime ReconciledAtLedger { get; set; } = default!;

        [JsonProperty("reconciledAtPayments")]
        public DateTime ReconciledAtPayments { get; set; } = default!;

        [JsonProperty("status")]
        public string Status { get; set; } = default!;

        [JsonProperty("paymentsBalances")]
        public Dictionary<string, BigInteger> PaymentsBalances { get; set; } = default!;

        [JsonProperty("ledgerBalances")]
        public Dictionary<string, BigInteger> LedgerBalances { get; set; } = default!;

        [JsonProperty("driftBalances")]
        public Dictionary<string, BigInteger> DriftBalances { get; set; } = default!;

        [JsonProperty("error")]
        public string? Error { get; set; }
    }
}