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
    using Newtonsoft.Json;
    using formance.Models.Components;
    using formance.Utils;
    
    public class ConnectorsTransferResponse
    {

        [JsonProperty("-")]
        public HTTPMetadata HttpMeta { get; set; } = default!;

        /// <summary>
        /// OK
        /// </summary>
        public TransferResponse? TransferResponse { get; set; }
    }
}