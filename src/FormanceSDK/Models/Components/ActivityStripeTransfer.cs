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
    using FormanceSDK.Models.Components;
    using FormanceSDK.Utils;
    using Newtonsoft.Json;
    using System.Numerics;
    
    public class ActivityStripeTransfer
    {

        [JsonProperty("connectorID")]
        public string? ConnectorID { get; set; }

        [JsonProperty("amount")]
        public BigInteger? Amount { get; set; }

        [JsonProperty("asset")]
        public string? Asset { get; set; }

        [JsonProperty("destination")]
        public string? Destination { get; set; }

        [JsonProperty("waitingValidation")]
        public bool? WaitingValidation { get; set; } = false;

        /// <summary>
        /// A set of key/value pairs that you can attach to a transfer object.<br/>
        /// 
        /// <remarks>
        /// It can be useful for storing additional information about the transfer in a structured format.<br/>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("metadata")]
        public Models.Components.Metadata? Metadata { get; set; }
    }
}