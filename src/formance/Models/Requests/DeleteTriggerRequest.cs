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
    
    public class DeleteTriggerRequest
    {

        /// <summary>
        /// The trigger id
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=triggerID")]
        public string TriggerID { get; set; } = default!;
    }
}