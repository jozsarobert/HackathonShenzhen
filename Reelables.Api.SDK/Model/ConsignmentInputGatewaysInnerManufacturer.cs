
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Reelables.Api.SDK.Model;

[JsonConverter(typeof(ConsignmentInputGatewaysInnerManufacturerJsonConverter))]
[DataContract(Name = "ConsignmentInput_gateways_inner_manufacturer")]
public class ConsignmentInputGatewaysInnerManufacturer : AbstractOpenAPISchema
{
    public ConsignmentInputGatewaysInnerManufacturer(string actualInstance)
    {
        this.IsNullable = false;
        this.SchemaType= "oneOf";
        this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }


    private Object _actualInstance;

    public override Object ActualInstance
    {
        get
        {
            return _actualInstance;
        }
        set
        {
            if (value.GetType() == typeof(string))
            {
                this._actualInstance = value;
            }
            else
            {
                throw new ArgumentException("Invalid instance found. Must be the following types: string");
            }
        }
    }

    public string GetString()
    {
        return (string)this.ActualInstance;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConsignmentInputGatewaysInnerManufacturer {\n");
        sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    public override string ToJson()
    {
        return JsonConvert.SerializeObject(this.ActualInstance, ConsignmentInputGatewaysInnerManufacturer.SerializerSettings);
    }

    public static ConsignmentInputGatewaysInnerManufacturer FromJson(string jsonString)
    {
        ConsignmentInputGatewaysInnerManufacturer newConsignmentInputGatewaysInnerManufacturer = null;

        if (string.IsNullOrEmpty(jsonString))
        {
            return newConsignmentInputGatewaysInnerManufacturer;
        }
        int match = 0;
        List<string> matchedTypes = new List<string>();

        try
        {
            // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
            if (typeof(string).GetProperty("AdditionalProperties") == null)
            {
                newConsignmentInputGatewaysInnerManufacturer = new ConsignmentInputGatewaysInnerManufacturer(JsonConvert.DeserializeObject<string>(jsonString, ConsignmentInputGatewaysInnerManufacturer.SerializerSettings));
            }
            else
            {
                newConsignmentInputGatewaysInnerManufacturer = new ConsignmentInputGatewaysInnerManufacturer(JsonConvert.DeserializeObject<string>(jsonString, ConsignmentInputGatewaysInnerManufacturer.AdditionalPropertiesSerializerSettings));
            }
            matchedTypes.Add("string");
            match++;
        }
        catch (Exception exception)
        {
            // deserialization failed, try the next one
            System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into string: {1}", jsonString, exception.ToString()));
        }

        if (match == 0)
        {
            throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
        }
        else if (match > 1)
        {
            throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
        }

        // deserialization is considered successful at this point if no exception has been thrown.
        return newConsignmentInputGatewaysInnerManufacturer;
    }


}

/// <summary>
/// Custom JSON converter for ConsignmentInputGatewaysInnerManufacturer
/// </summary>
public class ConsignmentInputGatewaysInnerManufacturerJsonConverter : JsonConverter
{
    /// <summary>
    /// To write the JSON string
    /// </summary>
    /// <param name="writer">JSON writer</param>
    /// <param name="value">Object to be converted into a JSON string</param>
    /// <param name="serializer">JSON Serializer</param>
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        writer.WriteRawValue((string)(typeof(ConsignmentInputGatewaysInnerManufacturer).GetMethod("ToJson").Invoke(value, null)));
    }

    /// <summary>
    /// To convert a JSON string into an object
    /// </summary>
    /// <param name="reader">JSON reader</param>
    /// <param name="objectType">Object type</param>
    /// <param name="existingValue">Existing value</param>
    /// <param name="serializer">JSON Serializer</param>
    /// <returns>The object converted from the JSON string</returns>
    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        if(reader.TokenType != JsonToken.Null)
        {
            return ConsignmentInputGatewaysInnerManufacturer.FromJson(JObject.Load(reader).ToString(Formatting.None));
        }
        return null;
    }

    /// <summary>
    /// Check if the object can be converted
    /// </summary>
    /// <param name="objectType">Object type</param>
    /// <returns>True if the object can be converted</returns>
    public override bool CanConvert(Type objectType)
    {
        return false;
    }
}