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
    
    public class V3ResetConnectorRequest
    {

        /// <summary>
        /// The connector ID
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=connectorID")]
        public string ConnectorID { get; set; } = default!;
    }
}