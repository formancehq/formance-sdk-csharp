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
    
    public class V2ErrorResponse
    {

        [JsonProperty("errorCode")]
        public V2ErrorsEnum ErrorCode { get; set; } = default!;

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; } = default!;

        [JsonProperty("details")]
        public string? Details { get; set; }
    }
}