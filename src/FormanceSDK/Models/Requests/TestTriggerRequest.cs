//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace FormanceSDK.Models.Requests
{
    using FormanceSDK.Utils;
    using System.Collections.Generic;
    
    public class TestTriggerRequest
    {

        /// <summary>
        /// The trigger id
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=triggerID")]
        public string TriggerID { get; set; } = default!;

        [SpeakeasyMetadata("request:mediaType=application/json")]
        public Dictionary<string, object>? RequestBody { get; set; }
    }
}