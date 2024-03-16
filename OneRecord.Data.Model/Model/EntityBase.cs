using System.Runtime.Serialization;

namespace OneRecord.Data.Model.Model
{
    public abstract class EntityBase
    {
        public EntityBase()
        {
            Type = new List<string>
            {
               "cargo:LogisticsObject"
            };
        }

        [DataMember(Name = "@id", EmitDefaultValue = false)]
        public string NeonId { get; set; }

        public int Id { get; set; }

        [DataMember(Name = "@type", EmitDefaultValue = false)]
        public List<string> Type { get; init; }
    }
}
