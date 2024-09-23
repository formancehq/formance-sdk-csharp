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
    
    public class GetBalancesAggregatedRequest
    {

        /// <summary>
        /// Name of the ledger.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=ledger")]
        public string Ledger { get; set; } = default!;

        /// <summary>
        /// Filter balances involving given account, either as source or destination.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=address")]
        public string? Address { get; set; }

        /// <summary>
        /// Use insertion date instead of effective date
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=useInsertionDate")]
        public bool? UseInsertionDate { get; set; }
    }
}