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
    
    public class GetAccountBalancesRequest
    {

        /// <summary>
        /// The account ID.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=accountId")]
        public string AccountId { get; set; } = default!;

        /// <summary>
        /// The maximum number of results to return per page.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=limit")]
        public long? Limit { get; set; }

        /// <summary>
        /// Filter balances by currency.<br/>
        /// 
        /// <remarks>
        /// If not specified, all account&apos;s balances will be returned.<br/>
        /// 
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=asset")]
        public string? Asset { get; set; }

        /// <summary>
        /// Filter balances by date.<br/>
        /// 
        /// <remarks>
        /// If not specified, all account&apos;s balances will be returned.<br/>
        /// 
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=from")]
        public DateTime? From { get; set; }

        /// <summary>
        /// Filter balances by date.<br/>
        /// 
        /// <remarks>
        /// If not specified, default will be set to now.<br/>
        /// 
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=to")]
        public DateTime? To { get; set; }

        /// <summary>
        /// The maximum number of results to return per page.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=pageSize")]
        public long? PageSize { get; set; } = 15;

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

        /// <summary>
        /// Fields used to sort payments (default is date:desc).
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=sort")]
        public List<string>? Sort { get; set; }
    }
}