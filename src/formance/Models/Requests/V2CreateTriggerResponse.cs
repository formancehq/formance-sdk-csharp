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
    
    public class V2CreateTriggerResponse
    {

        [JsonProperty("-")]
        public HTTPMetadata HttpMeta { get; set; } = default!;

        /// <summary>
        /// Created trigger
        /// </summary>
        public Models.Components.V2CreateTriggerResponse? V2CreateTriggerResponseValue { get; set; }
    }
}