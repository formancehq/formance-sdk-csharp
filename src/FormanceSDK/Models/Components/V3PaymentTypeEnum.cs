//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace FormanceSDK.Models.Components
{
    using FormanceSDK.Utils;
    using Newtonsoft.Json;
    using System;
    
    public enum V3PaymentTypeEnum
    {
        [JsonProperty("UNKNOWN")]
        Unknown,
        [JsonProperty("PAY-IN")]
        PayIn,
        [JsonProperty("PAYOUT")]
        Payout,
        [JsonProperty("TRANSFER")]
        Transfer,
        [JsonProperty("OTHER")]
        Other,
    }

    public static class V3PaymentTypeEnumExtension
    {
        public static string Value(this V3PaymentTypeEnum value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static V3PaymentTypeEnum ToEnum(this string value)
        {
            foreach(var field in typeof(V3PaymentTypeEnum).GetFields())
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

                    if (enumVal is V3PaymentTypeEnum)
                    {
                        return (V3PaymentTypeEnum)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum V3PaymentTypeEnum");
        }
    }

}