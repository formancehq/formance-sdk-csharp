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
    
    public class AtlarConfig
    {

        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        [JsonProperty("provider")]
        public string? Provider { get; set; } = "Atlar";

        /// <summary>
        /// The base URL the client uses for making requests towards the Atlar API.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("baseUrl")]
        public string? BaseUrl { get; set; } = "https://api.atlar.com";

        /// <summary>
        /// The frequency at which the connector tries to fetch new Transaction objects from the Atlar API.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("pollingPeriod")]
        public string? PollingPeriod { get; set; } = "120s";

        /// <summary>
        /// The frequency at which the connector tries to fetch the status of payment initiations from the Atlar API.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("transferInitiationStatusPollingPeriod")]
        public string? TransferInitiationStatusPollingPeriod { get; set; } = "120s";

        /// <summary>
        /// The access key used by the connector for authorizing requests to the Atlar API.<br/>
        /// 
        /// <remarks>
        /// You can obtain it along with the associated secret from the Atlar dashboard.<br/>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("accessKey")]
        public string AccessKey { get; set; } = default!;

        /// <summary>
        /// The secret used by the connector for authorizing requests to the Atlar API.<br/>
        /// 
        /// <remarks>
        /// You can obtain it along with the associated access key from the Atlar dashboard.<br/>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("secret")]
        public string Secret { get; set; } = default!;

        /// <summary>
        /// Number of items to fetch when querying paginated APIs.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("pageSize")]
        public long? PageSize { get; set; } = 25;
    }
}