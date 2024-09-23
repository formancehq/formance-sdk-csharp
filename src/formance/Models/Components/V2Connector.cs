//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace formance.Models.Components
{
    using Newtonsoft.Json;
    using System;
    using formance.Utils;
    
    public enum V2Connector
    {
        [JsonProperty("STRIPE")]
        Stripe,
        [JsonProperty("DUMMY-PAY")]
        DummyPay,
        [JsonProperty("WISE")]
        Wise,
        [JsonProperty("MODULR")]
        Modulr,
        [JsonProperty("CURRENCY-CLOUD")]
        CurrencyCloud,
        [JsonProperty("BANKING-CIRCLE")]
        BankingCircle,
        [JsonProperty("MANGOPAY")]
        Mangopay,
        [JsonProperty("MONEYCORP")]
        Moneycorp,
    }

    public static class V2ConnectorExtension
    {
        public static string Value(this V2Connector value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static V2Connector ToEnum(this string value)
        {
            foreach(var field in typeof(V2Connector).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is V2Connector)
                    {
                        return (V2Connector)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum V2Connector");
        }
    }

}