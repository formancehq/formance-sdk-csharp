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
    using System.Collections.Generic;
    
    public class V2GetWorkflowInstanceHistoryResponse
    {

        [JsonProperty("data")]
        public List<V2WorkflowInstanceHistory> Data { get; set; } = default!;
    }
}