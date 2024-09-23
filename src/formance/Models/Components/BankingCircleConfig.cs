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
    
    public class BankingCircleConfig
    {

        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        [JsonProperty("username")]
        public string Username { get; set; } = default!;

        [JsonProperty("password")]
        public string Password { get; set; } = default!;

        [JsonProperty("endpoint")]
        public string Endpoint { get; set; } = default!;

        [JsonProperty("authorizationEndpoint")]
        public string AuthorizationEndpoint { get; set; } = default!;

        [JsonProperty("userCertificate")]
        public string UserCertificate { get; set; } = default!;

        [JsonProperty("userCertificateKey")]
        public string UserCertificateKey { get; set; } = default!;

        /// <summary>
        /// The frequency at which the connector will try to fetch new BalanceTransaction objects from Banking Circle API.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("pollingPeriod")]
        public string? PollingPeriod { get; set; } = "120s";
    }
}