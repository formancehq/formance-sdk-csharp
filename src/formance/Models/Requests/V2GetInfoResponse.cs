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
    
    public class V2GetInfoResponse
    {

        [JsonProperty("-")]
        public HTTPMetadata HttpMeta { get; set; } = default!;

        /// <summary>
        /// OK
        /// </summary>
        public V2ConfigInfoResponse? V2ConfigInfoResponse { get; set; }

        /// <summary>
        /// Error
        /// </summary>
        public Models.Components.V2ErrorResponse? V2ErrorResponse { get; set; }
    }
}