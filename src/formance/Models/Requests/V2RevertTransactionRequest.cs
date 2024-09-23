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
    using System.Numerics;
    using formance.Utils;
    
    public class V2RevertTransactionRequest
    {

        /// <summary>
        /// Name of the ledger.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=ledger")]
        public string Ledger { get; set; } = default!;

        /// <summary>
        /// Transaction ID.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=id")]
        public BigInteger Id { get; set; } = default!;

        /// <summary>
        /// Force revert
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=force")]
        public bool? Force { get; set; }

        /// <summary>
        /// Revert transaction at effective date of the original tx
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=atEffectiveDate")]
        public bool? AtEffectiveDate { get; set; }
    }
}