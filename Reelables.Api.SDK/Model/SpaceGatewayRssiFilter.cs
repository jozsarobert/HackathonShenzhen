using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Reelables.Api.SDK.Model;

[JsonConverter(typeof(SpaceGatewayRssiFilterJsonConverter))]
[DataContract(Name = "SpaceGateway_rssiFilter")]
public class SpaceGatewayRssiFilter : AbstractOpenAPISchema
{
    public SpaceGatewayRssiFilter(string actualInstance)
    {
        this.IsNullable = false;
        this.SchemaType= "oneOf";
        this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }

    public SpaceGatewayRssiFilter(int actualInstance)
    {
        this.IsNullable = false;
        this.SchemaType= "oneOf";
        this.ActualInstance = actualInstance;
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
            if (value.GetType() == typeof(int))
            {
                this._actualInstance = value;
            }
            else if (value.GetType() == typeof(string))
            {
                this._actualInstance = value;
            }
            else
            {
                throw new ArgumentException("Invalid instance found. Must be the following types: int, string");
            }
        }
    }

    public string GetString()
    {
        return (string)this.ActualInstance;
    }

    public int GetInt()
    {
        return (int)this.ActualInstance;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SpaceGatewayRssiFilter {\n");
        sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    public override string ToJson()
    {
        return JsonConvert.SerializeObject(this.ActualInstance, SpaceGatewayRssiFilter.SerializerSettings);
    }

    public static SpaceGatewayRssiFilter FromJson(string jsonString)
    {
        SpaceGatewayRssiFilter newSpaceGatewayRssiFilter = null;

        if (string.IsNullOrEmpty(jsonString))
        {
            return newSpaceGatewayRssiFilter;
        }
        int match = 0;
        List<string> matchedTypes = new List<string>();

        try
        {
            // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
            if (typeof(int).GetProperty("AdditionalProperties") == null)
            {
                newSpaceGatewayRssiFilter = new SpaceGatewayRssiFilter(JsonConvert.DeserializeObject<int>(jsonString, SpaceGatewayRssiFilter.SerializerSettings));
            }
            else
            {
                newSpaceGatewayRssiFilter = new SpaceGatewayRssiFilter(JsonConvert.DeserializeObject<int>(jsonString, SpaceGatewayRssiFilter.AdditionalPropertiesSerializerSettings));
            }
            matchedTypes.Add("int");
            match++;
        }
        catch (Exception exception)
        {
            // deserialization failed, try the next one
            System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into int: {1}", jsonString, exception.ToString()));
        }

        try
        {
            // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
            if (typeof(string).GetProperty("AdditionalProperties") == null)
            {
                newSpaceGatewayRssiFilter = new SpaceGatewayRssiFilter(JsonConvert.DeserializeObject<string>(jsonString, SpaceGatewayRssiFilter.SerializerSettings));
            }
            else
            {
                newSpaceGatewayRssiFilter = new SpaceGatewayRssiFilter(JsonConvert.DeserializeObject<string>(jsonString, SpaceGatewayRssiFilter.AdditionalPropertiesSerializerSettings));
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
        return newSpaceGatewayRssiFilter;
    }

}


public class SpaceGatewayRssiFilterJsonConverter : JsonConverter
{

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        writer.WriteRawValue((string)(typeof(SpaceGatewayRssiFilter).GetMethod("ToJson").Invoke(value, null)));
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        if(reader.TokenType != JsonToken.Null)
        {
            return SpaceGatewayRssiFilter.FromJson(JObject.Load(reader).ToString(Formatting.None));
        }
        return null;
    }

    public override bool CanConvert(Type objectType)
    {
        return false;
    }
}