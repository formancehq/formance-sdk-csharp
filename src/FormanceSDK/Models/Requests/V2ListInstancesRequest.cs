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
    
    public class V2ListInstancesRequest
    {

        /// <summary>
        /// Parameter used in pagination requests.<br/>
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
        /// The maximum number of results to return per page.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=pageSize")]
        public long? PageSize { get; set; }

        /// <summary>
        /// A workflow id
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=workflowID")]
        public string? WorkflowID { get; set; }

        /// <summary>
        /// Filter running instances
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=running")]
        public bool? Running { get; set; }
    }
}