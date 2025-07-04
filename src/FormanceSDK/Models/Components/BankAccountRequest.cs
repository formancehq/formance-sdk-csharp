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
    
    public class BankAccountRequest
    {

        [JsonProperty("country")]
        public string Country { get; set; } = default!;

        [JsonProperty("connectorID")]
        public string? ConnectorID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        [JsonProperty("accountNumber")]
        public string? AccountNumber { get; set; }

        [JsonProperty("iban")]
        public string? Iban { get; set; }

        [JsonProperty("swiftBicCode")]
        public string? SwiftBicCode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string>? Metadata { get; set; } = null;
    }
}