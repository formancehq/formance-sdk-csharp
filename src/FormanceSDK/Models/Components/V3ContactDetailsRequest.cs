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
    
    public class V3ContactDetailsRequest
    {

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("phoneNumber")]
        public string? PhoneNumber { get; set; }
    }
}