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
    using System.Collections.Generic;
    using System;
    using formance.Utils;
    
    public class V2ListAccountsRequest
    {

        /// <summary>
        /// Name of the ledger.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=ledger")]
        public string Ledger { get; set; } = default!;

        /// <summary>
        /// The maximum number of results to return per page.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=pageSize")]
        public long? PageSize { get; set; }

        /// <summary>
        /// Parameter used in pagination requests. Maximum page size is set to 15.<br/>
        /// 
        /// <remarks>
        /// Set to the value of next for the next page of results.<br/>
        /// Set to the value of previous for the previous page of results.<br/>
        /// No other parameters can be set when this parameter is set.<br/>
        /// 
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=cursor")]
        public string? Cursor { get; set; }

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=expand")]
        public string? Expand { get; set; }

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=pit")]
        public DateTime? Pit { get; set; }

        [SpeakeasyMetadata("request:mediaType=application/json")]
        public Dictionary<string, object>? RequestBody { get; set; }
    }
}