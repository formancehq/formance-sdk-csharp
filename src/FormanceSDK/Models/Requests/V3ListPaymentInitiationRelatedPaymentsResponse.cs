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
    using Newtonsoft.Json;
    
    public class V3ListPaymentInitiationRelatedPaymentsResponse
    {

        [JsonProperty("-")]
        public HTTPMetadata HttpMeta { get; set; } = default!;

        /// <summary>
        /// OK
        /// </summary>
        public V3PaymentInitiationRelatedPaymentsCursorResponse? V3PaymentInitiationRelatedPaymentsCursorResponse { get; set; }
    }
}