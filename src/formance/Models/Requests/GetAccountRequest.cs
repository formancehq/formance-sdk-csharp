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
    using formance.Utils;
    
    public class GetAccountRequest
    {

        /// <summary>
        /// Name of the ledger.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=ledger")]
        public string Ledger { get; set; } = default!;

        /// <summary>
        /// Exact address of the account. It must match the following regular expressions pattern:<br/>
        /// 
        /// <remarks>
        /// ```<br/>
        /// ^\w+(:\w+)*$<br/>
        /// ```<br/>
        /// 
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=address")]
        public string Address { get; set; } = default!;
    }
}