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
    
    public class V3InitiatePaymentRequest
    {

        /// <summary>
        /// If set to true, the request will not have to be validated. This is useful if we want to directly forward the request to the PSP.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=noValidation")]
        public bool? NoValidation { get; set; } = false;

        [SpeakeasyMetadata("request:mediaType=application/json")]
        public Models.Components.V3InitiatePaymentRequest? V3InitiatePaymentRequestValue { get; set; }
    }
}