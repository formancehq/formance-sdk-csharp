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
    
    public class V3ListConnectorSchedulesRequest
    {

        /// <summary>
        /// The connector ID
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=connectorID")]
        public string ConnectorID { get; set; } = default!;

        /// <summary>
        /// The number of items to return
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=pageSize")]
        public long? PageSize { get; set; }

        /// <summary>
        /// Parameter used in pagination requests. Set to the value of next for the next page of results. Set to the value of previous for the previous page of results. No other parameters can be set when this parameter is set.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=cursor")]
        public string? Cursor { get; set; }

        [SpeakeasyMetadata("request:mediaType=application/json")]
        public Dictionary<string, object>? RequestBody { get; set; }
    }
}