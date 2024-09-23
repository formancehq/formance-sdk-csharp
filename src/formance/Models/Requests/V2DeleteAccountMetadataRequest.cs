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
    using formance.Utils;
    
    public class V2DeleteAccountMetadataRequest
    {

        /// <summary>
        /// Name of the ledger.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=ledger")]
        public string Ledger { get; set; } = default!;

        /// <summary>
        /// Account address
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=address")]
        public string Address { get; set; } = default!;

        /// <summary>
        /// The key to remove.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=key")]
        public string Key { get; set; } = default!;
    }
}