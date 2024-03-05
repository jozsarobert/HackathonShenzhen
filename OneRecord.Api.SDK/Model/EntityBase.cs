using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

public abstract class EntityBase
{
    [DataMember(Name = "@id", EmitDefaultValue = false)]
    public string Id { get; set; }

    [DataMember(Name = "@type", EmitDefaultValue = false)]
    public List<string> Type { get; set; }

    public virtual string ToJson()
    {
        return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
    }
}
