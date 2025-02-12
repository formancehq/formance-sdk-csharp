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
    
    public enum PaymentScheme
    {
        [JsonProperty("unknown")]
        Unknown,
        [JsonProperty("other")]
        Other,
        [JsonProperty("visa")]
        Visa,
        [JsonProperty("mastercard")]
        Mastercard,
        [JsonProperty("amex")]
        Amex,
        [JsonProperty("diners")]
        Diners,
        [JsonProperty("discover")]
        Discover,
        [JsonProperty("jcb")]
        Jcb,
        [JsonProperty("unionpay")]
        Unionpay,
        [JsonProperty("alipay")]
        Alipay,
        [JsonProperty("cup")]
        Cup,
        [JsonProperty("sepa debit")]
        SepaDebit,
        [JsonProperty("sepa credit")]
        SepaCredit,
        [JsonProperty("sepa")]
        Sepa,
        [JsonProperty("apple pay")]
        ApplePay,
        [JsonProperty("google pay")]
        GooglePay,
        [JsonProperty("doku")]
        Doku,
        [JsonProperty("dragonpay")]
        Dragonpay,
        [JsonProperty("maestro")]
        Maestro,
        [JsonProperty("molpay")]
        Molpay,
        [JsonProperty("a2a")]
        A2a,
        [JsonProperty("ach debit")]
        AchDebit,
        [JsonProperty("ach")]
        Ach,
        [JsonProperty("rtp")]
        Rtp,
    }

    public static class PaymentSchemeExtension
    {
        public static string Value(this PaymentScheme value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PaymentScheme ToEnum(this string value)
        {
            foreach(var field in typeof(PaymentScheme).GetFields())
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

                    if (enumVal is PaymentScheme)
                    {
                        return (PaymentScheme)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum PaymentScheme");
        }
    }

}