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
    
    public enum V3PaymentStatusEnum
    {
        [JsonProperty("UNKNOWN")]
        Unknown,
        [JsonProperty("PENDING")]
        Pending,
        [JsonProperty("SUCCEEDED")]
        Succeeded,
        [JsonProperty("CANCELLED")]
        Cancelled,
        [JsonProperty("FAILED")]
        Failed,
        [JsonProperty("EXPIRED")]
        Expired,
        [JsonProperty("REFUNDED")]
        Refunded,
        [JsonProperty("REFUNDED_FAILURE")]
        RefundedFailure,
        [JsonProperty("REFUND_REVERSED")]
        RefundReversed,
        [JsonProperty("DISPUTE")]
        Dispute,
        [JsonProperty("DISPUTE_WON")]
        DisputeWon,
        [JsonProperty("DISPUTE_LOST")]
        DisputeLost,
        [JsonProperty("AMOUNT_ADJUSTEMENT")]
        AmountAdjustement,
        [JsonProperty("AUTHORISATION")]
        Authorisation,
        [JsonProperty("CAPTURE")]
        Capture,
        [JsonProperty("CAPTURE_FAILED")]
        CaptureFailed,
        [JsonProperty("OTHER")]
        Other,
    }

    public static class V3PaymentStatusEnumExtension
    {
        public static string Value(this V3PaymentStatusEnum value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static V3PaymentStatusEnum ToEnum(this string value)
        {
            foreach(var field in typeof(V3PaymentStatusEnum).GetFields())
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

                    if (enumVal is V3PaymentStatusEnum)
                    {
                        return (V3PaymentStatusEnum)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum V3PaymentStatusEnum");
        }
    }

}