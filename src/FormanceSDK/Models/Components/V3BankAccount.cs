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
    
    public class V3BankAccount
    {

        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; } = default!;

        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        [JsonProperty("accountNumber")]
        public string? AccountNumber { get; set; } = null;

        [JsonProperty("iban")]
        public string? Iban { get; set; } = null;

        [JsonProperty("swiftBicCode")]
        public string? SwiftBicCode { get; set; } = null;

        [JsonProperty("metadata")]
        public Dictionary<string, string>? Metadata { get; set; } = null;

        [JsonProperty("relatedAccounts")]
        public List<V3BankAccountRelatedAccount>? RelatedAccounts { get; set; }
    }
}