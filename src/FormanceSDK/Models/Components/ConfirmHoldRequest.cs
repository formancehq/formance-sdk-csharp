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
    using System.Numerics;
    
    public class ConfirmHoldRequest
    {

        /// <summary>
        /// Define the amount to transfer.
        /// </summary>
        [JsonProperty("amount")]
        public BigInteger? Amount { get; set; }

        /// <summary>
        /// Define a final confirmation. Remaining funds will be returned to the wallet.
        /// </summary>
        [JsonProperty("final")]
        public bool? Final { get; set; }
    }
}