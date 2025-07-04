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
    
    public enum V3PaymentInitiationStatusEnum
    {
        [JsonProperty("UNKNOWN")]
        Unknown,
        [JsonProperty("WAITING_FOR_VALIDATION")]
        WaitingForValidation,
        [JsonProperty("SCHEDULED_FOR_PROCESSING")]
        ScheduledForProcessing,
        [JsonProperty("PROCESSING")]
        Processing,
        [JsonProperty("PROCESSED")]
        Processed,
        [JsonProperty("FAILED")]
        Failed,
        [JsonProperty("REJECTED")]
        Rejected,
        [JsonProperty("REVERSE_PROCESSING")]
        ReverseProcessing,
        [JsonProperty("REVERSE_FAILED")]
        ReverseFailed,
        [JsonProperty("REVERSED")]
        Reversed,
    }

    public static class V3PaymentInitiationStatusEnumExtension
    {
        public static string Value(this V3PaymentInitiationStatusEnum value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static V3PaymentInitiationStatusEnum ToEnum(this string value)
        {
            foreach(var field in typeof(V3PaymentInitiationStatusEnum).GetFields())
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

                    if (enumVal is V3PaymentInitiationStatusEnum)
                    {
                        return (V3PaymentInitiationStatusEnum)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum V3PaymentInitiationStatusEnum");
        }
    }

}