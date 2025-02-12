//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace FormanceSDK.Models.Components
{
    using FormanceSDK.Utils;
    using Newtonsoft.Json;
    
    public class V3InitiatePaymentResponseData
    {

        /// <summary>
        /// Related payment initiation object ID created.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("paymentInitiationID")]
        public string? PaymentInitiationID { get; set; }

        /// <summary>
        /// Will be filled if the noValidation query parameter is set to true. Since this call is asynchronous, the response will contain the ID of the task that was created to create the payment on the PSP. You can use the task API to check the status of the task and get the resulting payment ID<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("taskID")]
        public string? TaskID { get; set; }
    }
}