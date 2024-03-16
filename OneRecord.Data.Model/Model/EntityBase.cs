using System.Runtime.Serialization;

namespace OneRecord.Data.Model.Model
{
    public abstract class EntityBase
    {
        [DataMember(Name = "@id", EmitDefaultValue = false)]
        public string Id { get; set; }

        [DataMember(Name = "@type", EmitDefaultValue = false)]
        public List<string> Type { get; init; }
    }
}
