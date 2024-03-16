using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

public abstract class EntityBase
{
    [DataMember(Name = "@id", EmitDefaultValue = false)]
    public string Id { get; set; }

    [DataMember(Name = "@type", EmitDefaultValue = false)]
    public List<string> Type { get; init; }

    public virtual string ToJson()
    {
        return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
    }
}
