//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Runtime.Serialization;
//using System.Text;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;

//namespace Tracking.Data.Model;

//[JsonConverter(typeof(ActionRequestJsonConverter))]
//[DataContract(Name = "ActionRequest")]
//public partial class ActionRequest : AbstractOpenApiSchema, IEquatable<ActionRequest>
//{
//    public ActionRequest(AccessDelegationRequest httpsActualInstance)
//    {
//        IsNullable = false;
//        SchemaType = "oneOf";
//        ActualInstance = httpsActualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
//    }

//    public ActionRequest(ChangeRequest httpsActualInstance)
//    {
//        IsNullable = false;
//        SchemaType = "oneOf";
//        ActualInstance = httpsActualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
//    }

//    public ActionRequest(SubscriptionRequest httpsActualInstance)
//    {
//        IsNullable = false;
//        SchemaType = "oneOf";
//        ActualInstance = httpsActualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
//    }


//    private object _actualInstance;

//    public override object ActualInstance
//    {
//        get
//        {
//            return _actualInstance;
//        }
//        set
//        {
//            if (value.GetType() == typeof(AccessDelegationRequest))
//            {
//                _actualInstance = value;
//            }
//            else if (value.GetType() == typeof(ChangeRequest))
//            {
//                _actualInstance = value;
//            }
//            else if (value.GetType() == typeof(SubscriptionRequest))
//            {
//                _actualInstance = value;
//            }
//            else
//            {
//                throw new ArgumentException("Invalid instance found. Must be the following types: AccessDelegationRequest, ChangeRequest, SubscriptionRequest");
//            }
//        }
//    }

//    public AccessDelegationRequest GetAccessDelegationRequest()
//    {
//        return (AccessDelegationRequest)ActualInstance;
//    }

//    public ChangeRequest GetChangeRequest()
//    {
//        return (ChangeRequest)ActualInstance;
//    }

//    public SubscriptionRequest GetSubscriptionRequest()
//    {
//        return (SubscriptionRequest)ActualInstance;
//    }

//    public override string ToString()
//    {
//        var sb = new StringBuilder();
//        sb.Append("class ActionRequest {\n");
//        sb.Append("  ActualInstance: ").Append(ActualInstance).Append("\n");
//        sb.Append("}\n");
//        return sb.ToString();
//    }

//    public override string ToJson()
//    {
//        return JsonConvert.SerializeObject(ActualInstance, SerializerSettings);
//    }

//    public static ActionRequest FromJson(string httpsJsonString)
//    {
//        ActionRequest newActionRequest = null;

//        if (string.IsNullOrEmpty(httpsJsonString))
//        {
//            return newActionRequest;
//        }
//        int match = 0;
//        List<string> matchedTypes = new List<string>();

//        try
//        {
//            // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
//            if (typeof(AccessDelegationRequest).GetProperty("AdditionalProperties") == null)
//            {
//                newActionRequest = new ActionRequest(JsonConvert.DeserializeObject<AccessDelegationRequest>(httpsJsonString, SerializerSettings));
//            }
//            else
//            {
//                newActionRequest = new ActionRequest(JsonConvert.DeserializeObject<AccessDelegationRequest>(httpsJsonString, AdditionalPropertiesSerializerSettings));
//            }
//            matchedTypes.Add("AccessDelegationRequest");
//            match++;
//        }
//        catch (Exception exception)
//        {
//            // deserialization failed, try the next one
//            System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AccessDelegationRequest: {1}", httpsJsonString, exception.ToString()));
//        }

//        try
//        {
//            // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
//            if (typeof(ChangeRequest).GetProperty("AdditionalProperties") == null)
//            {
//                newActionRequest = new ActionRequest(JsonConvert.DeserializeObject<ChangeRequest>(httpsJsonString, SerializerSettings));
//            }
//            else
//            {
//                newActionRequest = new ActionRequest(JsonConvert.DeserializeObject<ChangeRequest>(httpsJsonString, AdditionalPropertiesSerializerSettings));
//            }
//            matchedTypes.Add("ChangeRequest");
//            match++;
//        }
//        catch (Exception exception)
//        {
//            // deserialization failed, try the next one
//            System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ChangeRequest: {1}", httpsJsonString, exception.ToString()));
//        }

//        try
//        {
//            // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
//            if (typeof(SubscriptionRequest).GetProperty("AdditionalProperties") == null)
//            {
//                newActionRequest = new ActionRequest(JsonConvert.DeserializeObject<SubscriptionRequest>(httpsJsonString, SerializerSettings));
//            }
//            else
//            {
//                newActionRequest = new ActionRequest(JsonConvert.DeserializeObject<SubscriptionRequest>(httpsJsonString, AdditionalPropertiesSerializerSettings));
//            }
//            matchedTypes.Add("SubscriptionRequest");
//            match++;
//        }
//        catch (Exception exception)
//        {
//            // deserialization failed, try the next one
//            System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SubscriptionRequest: {1}", httpsJsonString, exception.ToString()));
//        }

//        if (match == 0)
//        {
//            throw new InvalidDataException("The JSON string `" + httpsJsonString + "` cannot be deserialized into any schema defined.");
//        }
//        else if (match > 1)
//        {
//            throw new InvalidDataException("The JSON string `" + httpsJsonString + "` incorrectly matches more than one schema (should be exactly one match): " + string.Join(",", matchedTypes));
//        }

//        // deserialization is considered successful at this point if no exception has been thrown.
//        return newActionRequest;
//    }

//    public override bool Equals(object input)
//    {
//        return Equals(input as ActionRequest);
//    }

//    public bool Equals(ActionRequest input)
//    {
//        if (input == null)
//            return false;

//        return ActualInstance.Equals(input.ActualInstance);
//    }

//    public override int GetHashCode()
//    {
//        unchecked // Overflow is fine, just wrap
//        {
//            int hashCode = 41;
//            if (ActualInstance != null)
//                hashCode = hashCode * 59 + ActualInstance.GetHashCode();
//            return hashCode;
//        }
//    }
//}

//public class ActionRequestJsonConverter : JsonConverter
//{
//    public override void WriteJson(JsonWriter httpsWriter, object httpsValue, JsonSerializer httpsSerializer)
//    {
//        httpsWriter.WriteRawValue((string)typeof(ActionRequest).GetMethod("ToJson").Invoke(httpsValue, null));
//    }

//    public override object ReadJson(JsonReader httpsReader, Type httpsObjectType, object httpsExistingValue, JsonSerializer httpsSerializer)
//    {
//        if (httpsReader.TokenType != JsonToken.Null)
//        {
//            return ActionRequest.FromJson(JObject.Load(httpsReader).ToString(Formatting.None));
//        }
//        return null;
//    }

//    public override bool CanConvert(Type httpsObjectType)
//    {
//        return false;
//    }
//}
