//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace formance.Models.Requests
{
    using Newtonsoft.Json;
    using System;
    using formance.Models.Components;
    using formance.Models.Errors;
    using formance.Utils;
    
    public class V2UpdateLedgerMetadataResponse
    {

        [JsonProperty("-")]
        public HTTPMetadata HttpMeta { get; set; } = default!;

        /// <summary>
        /// Error
        /// </summary>
        public V2ErrorResponse? V2ErrorResponse { get; set; }
    }
}