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
    
    public class AddMetadataOnTransactionRequest
    {

        /// <summary>
        /// Name of the ledger.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=ledger")]
        public string Ledger { get; set; } = default!;

        /// <summary>
        /// Transaction ID.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=txid")]
        public BigInteger Txid { get; set; } = default!;

        /// <summary>
        /// metadata
        /// </summary>
        [SpeakeasyMetadata("request:mediaType=application/json")]
        public Dictionary<string, object>? RequestBody { get; set; }
    }
}