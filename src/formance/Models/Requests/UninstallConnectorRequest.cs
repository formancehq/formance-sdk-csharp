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
    
    public class UninstallConnectorRequest
    {

        /// <summary>
        /// The name of the connector.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=connector")]
        public Connector Connector { get; set; } = default!;
    }
}