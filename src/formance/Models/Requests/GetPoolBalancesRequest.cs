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
    using System;
    using formance.Utils;
    
    public class GetPoolBalancesRequest
    {

        /// <summary>
        /// The pool ID.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=poolId")]
        public string PoolId { get; set; } = default!;

        /// <summary>
        /// Filter balances by date.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=at")]
        public DateTime At { get; set; } = default!;
    }
}