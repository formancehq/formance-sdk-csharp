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
    
    public enum V3TaskStatusEnum
    {
        [JsonProperty("PROCESSING")]
        Processing,
        [JsonProperty("SUCCEEDED")]
        Succeeded,
        [JsonProperty("FAILED")]
        Failed,
    }

    public static class V3TaskStatusEnumExtension
    {
        public static string Value(this V3TaskStatusEnum value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static V3TaskStatusEnum ToEnum(this string value)
        {
            foreach(var field in typeof(V3TaskStatusEnum).GetFields())
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

                    if (enumVal is V3TaskStatusEnum)
                    {
                        return (V3TaskStatusEnum)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum V3TaskStatusEnum");
        }
    }

}