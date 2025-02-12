//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace FormanceSDK.Models.Errors
{
    using FormanceSDK.Utils;
    using Newtonsoft.Json;
    using System;
    
    public enum ErrorCode
    {
        [JsonProperty("VALIDATION")]
        Validation,
        [JsonProperty("INTERNAL_ERROR")]
        InternalError,
        [JsonProperty("INSUFFICIENT_FUND")]
        InsufficientFund,
        [JsonProperty("HOLD_CLOSED")]
        HoldClosed,
    }

    public static class ErrorCodeExtension
    {
        public static string Value(this ErrorCode value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ErrorCode ToEnum(this string value)
        {
            foreach(var field in typeof(ErrorCode).GetFields())
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

                    if (enumVal is ErrorCode)
                    {
                        return (ErrorCode)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ErrorCode");
        }
    }

}