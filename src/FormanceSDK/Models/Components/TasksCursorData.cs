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
    

    public class TasksCursorDataType
    {
        private TasksCursorDataType(string value) { Value = value; }

        public string Value { get; private set; }
        public static TasksCursorDataType TaskStripe { get { return new TasksCursorDataType("TaskStripe"); } }
        
        public static TasksCursorDataType TaskWise { get { return new TasksCursorDataType("TaskWise"); } }
        
        public static TasksCursorDataType TaskCurrencyCloud { get { return new TasksCursorDataType("TaskCurrencyCloud"); } }
        
        public static TasksCursorDataType TaskDummyPay { get { return new TasksCursorDataType("TaskDummyPay"); } }
        
        public static TasksCursorDataType TaskModulr { get { return new TasksCursorDataType("TaskModulr"); } }
        
        public static TasksCursorDataType TaskBankingCircle { get { return new TasksCursorDataType("TaskBankingCircle"); } }
        
        public static TasksCursorDataType TaskMangoPay { get { return new TasksCursorDataType("TaskMangoPay"); } }
        
        public static TasksCursorDataType TaskMoneycorp { get { return new TasksCursorDataType("TaskMoneycorp"); } }
        
        public static TasksCursorDataType Null { get { return new TasksCursorDataType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(TasksCursorDataType v) { return v.Value; }
        public static TasksCursorDataType FromString(string v) {
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
                default: throw new ArgumentException("Invalid value for TasksCursorDataType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((TasksCursorDataType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(TasksCursorData.TasksCursorDataConverter))]
    public class TasksCursorData {
        public TasksCursorData(TasksCursorDataType type) {
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

        public TasksCursorDataType Type { get; set; }


        public static TasksCursorData CreateTaskStripe(TaskStripe taskStripe) {
            TasksCursorDataType typ = TasksCursorDataType.TaskStripe;

            TasksCursorData res = new TasksCursorData(typ);
            res.TaskStripe = taskStripe;
            return res;
        }

        public static TasksCursorData CreateTaskWise(TaskWise taskWise) {
            TasksCursorDataType typ = TasksCursorDataType.TaskWise;

            TasksCursorData res = new TasksCursorData(typ);
            res.TaskWise = taskWise;
            return res;
        }

        public static TasksCursorData CreateTaskCurrencyCloud(TaskCurrencyCloud taskCurrencyCloud) {
            TasksCursorDataType typ = TasksCursorDataType.TaskCurrencyCloud;

            TasksCursorData res = new TasksCursorData(typ);
            res.TaskCurrencyCloud = taskCurrencyCloud;
            return res;
        }

        public static TasksCursorData CreateTaskDummyPay(TaskDummyPay taskDummyPay) {
            TasksCursorDataType typ = TasksCursorDataType.TaskDummyPay;

            TasksCursorData res = new TasksCursorData(typ);
            res.TaskDummyPay = taskDummyPay;
            return res;
        }

        public static TasksCursorData CreateTaskModulr(TaskModulr taskModulr) {
            TasksCursorDataType typ = TasksCursorDataType.TaskModulr;

            TasksCursorData res = new TasksCursorData(typ);
            res.TaskModulr = taskModulr;
            return res;
        }

        public static TasksCursorData CreateTaskBankingCircle(TaskBankingCircle taskBankingCircle) {
            TasksCursorDataType typ = TasksCursorDataType.TaskBankingCircle;

            TasksCursorData res = new TasksCursorData(typ);
            res.TaskBankingCircle = taskBankingCircle;
            return res;
        }

        public static TasksCursorData CreateTaskMangoPay(TaskMangoPay taskMangoPay) {
            TasksCursorDataType typ = TasksCursorDataType.TaskMangoPay;

            TasksCursorData res = new TasksCursorData(typ);
            res.TaskMangoPay = taskMangoPay;
            return res;
        }

        public static TasksCursorData CreateTaskMoneycorp(TaskMoneycorp taskMoneycorp) {
            TasksCursorDataType typ = TasksCursorDataType.TaskMoneycorp;

            TasksCursorData res = new TasksCursorData(typ);
            res.TaskMoneycorp = taskMoneycorp;
            return res;
        }

        public static TasksCursorData CreateNull() {
            TasksCursorDataType typ = TasksCursorDataType.Null;
            return new TasksCursorData(typ);
        }

        public class TasksCursorDataConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(TasksCursorData);

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
                    return new TasksCursorData(TasksCursorDataType.TaskStripe)
                    {
                        TaskStripe = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<TaskStripe>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(TaskStripe), new TasksCursorData(TasksCursorDataType.TaskStripe), "TaskStripe"));
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
                    return new TasksCursorData(TasksCursorDataType.TaskWise)
                    {
                        TaskWise = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<TaskWise>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(TaskWise), new TasksCursorData(TasksCursorDataType.TaskWise), "TaskWise"));
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
                    return new TasksCursorData(TasksCursorDataType.TaskCurrencyCloud)
                    {
                        TaskCurrencyCloud = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<TaskCurrencyCloud>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(TaskCurrencyCloud), new TasksCursorData(TasksCursorDataType.TaskCurrencyCloud), "TaskCurrencyCloud"));
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
                    return new TasksCursorData(TasksCursorDataType.TaskDummyPay)
                    {
                        TaskDummyPay = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<TaskDummyPay>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(TaskDummyPay), new TasksCursorData(TasksCursorDataType.TaskDummyPay), "TaskDummyPay"));
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
                    return new TasksCursorData(TasksCursorDataType.TaskModulr)
                    {
                        TaskModulr = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<TaskModulr>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(TaskModulr), new TasksCursorData(TasksCursorDataType.TaskModulr), "TaskModulr"));
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
                    return new TasksCursorData(TasksCursorDataType.TaskBankingCircle)
                    {
                        TaskBankingCircle = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<TaskBankingCircle>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(TaskBankingCircle), new TasksCursorData(TasksCursorDataType.TaskBankingCircle), "TaskBankingCircle"));
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
                    return new TasksCursorData(TasksCursorDataType.TaskMangoPay)
                    {
                        TaskMangoPay = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<TaskMangoPay>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(TaskMangoPay), new TasksCursorData(TasksCursorDataType.TaskMangoPay), "TaskMangoPay"));
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
                    return new TasksCursorData(TasksCursorDataType.TaskMoneycorp)
                    {
                        TaskMoneycorp = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<TaskMoneycorp>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(TaskMoneycorp), new TasksCursorData(TasksCursorDataType.TaskMoneycorp), "TaskMoneycorp"));
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
                TasksCursorData res = (TasksCursorData)value;
                if (TasksCursorDataType.FromString(res.Type).Equals(TasksCursorDataType.Null))
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