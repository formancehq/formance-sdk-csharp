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
    
    public class UpdateTransferInitiationStatusRequest
    {

        /// <summary>
        /// The transfer ID.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=transferId")]
        public string TransferId { get; set; } = default!;

        [SpeakeasyMetadata("request:mediaType=application/json")]
        public Models.Components.UpdateTransferInitiationStatusRequest UpdateTransferInitiationStatusRequestValue { get; set; } = default!;
    }
}