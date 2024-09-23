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
    
    public enum ErrorsEnum
    {
        [JsonProperty("INTERNAL")]
        Internal,
        [JsonProperty("INSUFFICIENT_FUND")]
        InsufficientFund,
        [JsonProperty("VALIDATION")]
        Validation,
        [JsonProperty("CONFLICT")]
        Conflict,
        [JsonProperty("NO_SCRIPT")]
        NoScript,
        [JsonProperty("COMPILATION_FAILED")]
        CompilationFailed,
        [JsonProperty("METADATA_OVERRIDE")]
        MetadataOverride,
        [JsonProperty("NOT_FOUND")]
        NotFound,
    }

    public static class ErrorsEnumExtension
    {
        public static string Value(this ErrorsEnum value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ErrorsEnum ToEnum(this string value)
        {
            foreach(var field in typeof(ErrorsEnum).GetFields())
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

                    if (enumVal is ErrorsEnum)
                    {
                        return (ErrorsEnum)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ErrorsEnum");
        }
    }

}