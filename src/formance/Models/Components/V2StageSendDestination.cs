//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace formance.Models.Components
{
    using Newtonsoft.Json;
    using formance.Models.Components;
    using formance.Utils;
    
    public class V2StageSendDestination
    {

        [JsonProperty("wallet")]
        public V2StageSendDestinationWallet? Wallet { get; set; }

        [JsonProperty("account")]
        public V2StageSendDestinationAccount? Account { get; set; }

        [JsonProperty("payment")]
        public V2StageSendDestinationPayment? Payment { get; set; }
    }
}