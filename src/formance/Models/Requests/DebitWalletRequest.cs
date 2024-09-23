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
    using formance.Models.Components;
    using formance.Utils;
    
    public class DebitWalletRequest
    {

        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Use an idempotency key
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=Idempotency-Key")]
        public string? IdempotencyKey { get; set; }

        [SpeakeasyMetadata("request:mediaType=application/json")]
        public Models.Components.DebitWalletRequest? DebitWalletRequestValue { get; set; }
    }
}