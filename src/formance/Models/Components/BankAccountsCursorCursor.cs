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
    using formance.Models.Components;
    using formance.Utils;
    
    public class BankAccountsCursorCursor
    {

        [JsonProperty("pageSize")]
        public long PageSize { get; set; } = default!;

        [JsonProperty("hasMore")]
        public bool HasMore { get; set; } = default!;

        [JsonProperty("previous")]
        public string? Previous { get; set; }

        [JsonProperty("next")]
        public string? Next { get; set; }

        [JsonProperty("data")]
        public List<BankAccount> Data { get; set; } = default!;
    }
}