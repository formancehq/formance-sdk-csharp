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
    using FormanceSDK.Models.Components;
    using FormanceSDK.Utils;
    
    public class V2CreateLedgerRequest
    {

        /// <summary>
        /// Name of the ledger.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=ledger")]
        public string Ledger { get; set; } = default!;

        [SpeakeasyMetadata("request:mediaType=application/json")]
        public Models.Components.V2CreateLedgerRequest V2CreateLedgerRequestValue { get; set; } = default!;
    }
}