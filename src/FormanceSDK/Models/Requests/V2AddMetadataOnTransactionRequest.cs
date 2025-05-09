//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace FormanceSDK.Models.Requests
{
    using FormanceSDK.Utils;
    using System.Collections.Generic;
    using System.Numerics;
    
    public class V2AddMetadataOnTransactionRequest
    {

        /// <summary>
        /// Name of the ledger.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=ledger")]
        public string Ledger { get; set; } = default!;

        /// <summary>
        /// Transaction ID.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=id")]
        public BigInteger Id { get; set; } = default!;

        /// <summary>
        /// Set the dryRun mode. Dry run mode doesn&apos;t add the logs to the database or publish a message to the message broker.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=dryRun")]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Use an idempotency key
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=Idempotency-Key")]
        public string? IdempotencyKey { get; set; }

        /// <summary>
        /// metadata
        /// </summary>
        [SpeakeasyMetadata("request:mediaType=application/json")]
        public Dictionary<string, string> RequestBody { get; set; } = default!;
    }
}