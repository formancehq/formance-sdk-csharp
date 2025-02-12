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
    using FormanceSDK.Models.Components;
    using FormanceSDK.Utils;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Reflection;
    

    public class TaskResponseDataType
    {
        private TaskResponseDataType(string value) { Value = value; }

        public string Value { get; private set; }
        public static TaskResponseDataType TaskStripe { get { return new TaskResponseDataType("TaskStripe"); } }
        
        public static TaskResponseDataType TaskWise { get { return new TaskResponseDataType("TaskWise"); } }
        
        public static TaskResponseDataType TaskCurrencyCloud { get { return new TaskResponseDataType("TaskCurrencyCloud"); } }
        
        public static TaskResponseDataType TaskDummyPay { get { return new TaskResponseDataType("TaskDummyPay"); } }
        
        public static TaskResponseDataType TaskModulr { get { return new TaskResponseDataType("TaskModulr"); } }
        
        public static TaskResponseDataType TaskBankingCircle { get { return new TaskResponseDataType("TaskBankingCircle"); } }
        
        public static TaskResponseDataType TaskMangoPay { get { return new TaskResponseDataType("TaskMangoPay"); } }
        
        public static TaskResponseDataType TaskMoneycorp { get { return new TaskResponseDataType("TaskMoneycorp"); } }
        
        public static TaskResponseDataType Null { get { return new TaskResponseDataType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(TaskResponseDataType v) { return v.Value; }
        public static TaskResponseDataType FromString(string v) {
            switch(v) {
                case "TaskStripe": return TaskStripe;
                case "TaskWise": return TaskWise;
                case "TaskCurrencyCloud": return TaskCurrencyCloud;
                case "TaskDummyPay": return TaskDummyPay;
                case "TaskModulr": return TaskModulr;
                case "TaskBankingCircle": return TaskBankingCircle;
                case "TaskMangoPay": return TaskMangoPay;
                case "TaskMoneycorp": return TaskMoneycorp;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for TaskResponseDataType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((TaskResponseDataType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(TaskResponseData.TaskResponseDataConverter))]
    public class TaskResponseData {
        public TaskResponseData(TaskResponseDataType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public TaskStripe? TaskStripe { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public TaskWise? TaskWise { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public TaskCurrencyCloud? TaskCurrencyCloud { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public TaskDummyPay? TaskDummyPay { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public TaskModulr? TaskModulr { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public TaskBankingCircle? TaskBankingCircle { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public TaskMangoPay? TaskMangoPay { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public TaskMoneycorp? TaskMoneycorp { get; set; }

        public TaskResponseDataType Type { get; set; }


        public static TaskResponseData CreateTaskStripe(TaskStripe taskStripe) {
            TaskResponseDataType typ = TaskResponseDataType.TaskStripe;

            TaskResponseData res = new TaskResponseData(typ);
            res.TaskStripe = taskStripe;
            return res;
        }

        public static TaskResponseData CreateTaskWise(TaskWise taskWise) {
            TaskResponseDataType typ = TaskResponseDataType.TaskWise;

            TaskResponseData res = new TaskResponseData(typ);
            res.TaskWise = taskWise;
            return res;
        }

        public static TaskResponseData CreateTaskCurrencyCloud(TaskCurrencyCloud taskCurrencyCloud) {
            TaskResponseDataType typ = TaskResponseDataType.TaskCurrencyCloud;

            TaskResponseData res = new TaskResponseData(typ);
            res.TaskCurrencyCloud = taskCurrencyCloud;
            return res;
        }

        public static TaskResponseData CreateTaskDummyPay(TaskDummyPay taskDummyPay) {
            TaskResponseDataType typ = TaskResponseDataType.TaskDummyPay;

            TaskResponseData res = new TaskResponseData(typ);
            res.TaskDummyPay = taskDummyPay;
            return res;
        }

        public static TaskResponseData CreateTaskModulr(TaskModulr taskModulr) {
            TaskResponseDataType typ = TaskResponseDataType.TaskModulr;

            TaskResponseData res = new TaskResponseData(typ);
            res.TaskModulr = taskModulr;
            return res;
        }

        public static TaskResponseData CreateTaskBankingCircle(TaskBankingCircle taskBankingCircle) {
            TaskResponseDataType typ = TaskResponseDataType.TaskBankingCircle;

            TaskResponseData res = new TaskResponseData(typ);
            res.TaskBankingCircle = taskBankingCircle;
            return res;
        }

        public static TaskResponseData CreateTaskMangoPay(TaskMangoPay taskMangoPay) {
            TaskResponseDataType typ = TaskResponseDataType.TaskMangoPay;

            TaskResponseData res = new TaskResponseData(typ);
            res.TaskMangoPay = taskMangoPay;
            return res;
        }

        public static TaskResponseData CreateTaskMoneycorp(TaskMoneycorp taskMoneycorp) {
            TaskResponseDataType typ = TaskResponseDataType.TaskMoneycorp;

            TaskResponseData res = new TaskResponseData(typ);
            res.TaskMoneycorp = taskMoneycorp;
            return res;
        }

        public static TaskResponseData CreateNull() {
            TaskResponseDataType typ = TaskResponseDataType.Null;
            return new TaskResponseData(typ);
        }

        public class TaskResponseDataConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(TaskResponseData);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            {
                var json = JRaw.Create(reader).ToString();
                if (json == "null")
                {
                    return null;
                }

                var fallbackCandidates = new List<(System.Type, object, string)>();

                try
                {
                    return new TaskResponseData(TaskResponseDataType.TaskStripe)
                    {
                        TaskStripe = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<TaskStripe>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(TaskStripe), new TaskResponseData(TaskResponseDataType.TaskStripe), "TaskStripe"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
                }

                try
                {
                    return new TaskResponseData(TaskResponseDataType.TaskWise)
                    {
                        TaskWise = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<TaskWise>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(TaskWise), new TaskResponseData(TaskResponseDataType.TaskWise), "TaskWise"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
                }

                try
                {
                    return new TaskResponseData(TaskResponseDataType.TaskCurrencyCloud)
                    {
                        TaskCurrencyCloud = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<TaskCurrencyCloud>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(TaskCurrencyCloud), new TaskResponseData(TaskResponseDataType.TaskCurrencyCloud), "TaskCurrencyCloud"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
                }

                try
                {
                    return new TaskResponseData(TaskResponseDataType.TaskDummyPay)
                    {
                        TaskDummyPay = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<TaskDummyPay>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(TaskDummyPay), new TaskResponseData(TaskResponseDataType.TaskDummyPay), "TaskDummyPay"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
                }

                try
                {
                    return new TaskResponseData(TaskResponseDataType.TaskModulr)
                    {
                        TaskModulr = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<TaskModulr>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(TaskModulr), new TaskResponseData(TaskResponseDataType.TaskModulr), "TaskModulr"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
                }

                try
                {
                    return new TaskResponseData(TaskResponseDataType.TaskBankingCircle)
                    {
                        TaskBankingCircle = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<TaskBankingCircle>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(TaskBankingCircle), new TaskResponseData(TaskResponseDataType.TaskBankingCircle), "TaskBankingCircle"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
                }

                try
                {
                    return new TaskResponseData(TaskResponseDataType.TaskMangoPay)
                    {
                        TaskMangoPay = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<TaskMangoPay>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(TaskMangoPay), new TaskResponseData(TaskResponseDataType.TaskMangoPay), "TaskMangoPay"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
                }

                try
                {
                    return new TaskResponseData(TaskResponseDataType.TaskMoneycorp)
                    {
                        TaskMoneycorp = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<TaskMoneycorp>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(TaskMoneycorp), new TaskResponseData(TaskResponseDataType.TaskMoneycorp), "TaskMoneycorp"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
                }

                if (fallbackCandidates.Count > 0)
                {
                    fallbackCandidates.Sort((a, b) => ResponseBodyDeserializer.CompareFallbackCandidates(a.Item1, b.Item1, json));
                    foreach(var (deserializationType, returnObject, propertyName) in fallbackCandidates)
                    {
                        try
                        {
                            return ResponseBodyDeserializer.DeserializeUndiscriminatedUnionFallback(deserializationType, returnObject, propertyName, json);
                        }
                        catch (ResponseBodyDeserializer.DeserializationException)
                        {
                            // try next fallback option
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }

                throw new InvalidOperationException("Could not deserialize into any supported types.");
            }

            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                if (value == null) {
                    writer.WriteRawValue("null");
                    return;
                }
                TaskResponseData res = (TaskResponseData)value;
                if (TaskResponseDataType.FromString(res.Type).Equals(TaskResponseDataType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.TaskStripe != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.TaskStripe));
                    return;
                }
                if (res.TaskWise != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.TaskWise));
                    return;
                }
                if (res.TaskCurrencyCloud != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.TaskCurrencyCloud));
                    return;
                }
                if (res.TaskDummyPay != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.TaskDummyPay));
                    return;
                }
                if (res.TaskModulr != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.TaskModulr));
                    return;
                }
                if (res.TaskBankingCircle != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.TaskBankingCircle));
                    return;
                }
                if (res.TaskMangoPay != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.TaskMangoPay));
                    return;
                }
                if (res.TaskMoneycorp != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.TaskMoneycorp));
                    return;
                }

            }

        }

    }
}