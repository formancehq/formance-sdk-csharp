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
    
    public class V3GetPaymentResponse
    {

        [JsonProperty("-")]
        public HTTPMetadata HttpMeta { get; set; } = default!;

        /// <summary>
        /// OK
        /// </summary>
        public Models.Components.V3GetPaymentResponse? V3GetPaymentResponseValue { get; set; }
    }
}