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
    using formance.Utils;
    
    public class V2BulkElementResultError
    {

        [JsonProperty("responseType")]
        public string ResponseType { get; set; } = default!;

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; } = default!;

        [JsonProperty("errorDescription")]
        public string ErrorDescription { get; set; } = default!;

        [JsonProperty("errorDetails")]
        public string? ErrorDetails { get; set; }
    }
}