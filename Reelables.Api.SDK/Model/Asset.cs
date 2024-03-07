using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    [DataContract(Name = "Asset")]
    public partial class Asset
    {

        [JsonConstructorAttribute]
        protected Asset() { }
       
        [DataMember(Name = "inSpaces", EmitDefaultValue = false)]
        public List<AssetInSpace> InSpaces { get; set; }

        [DataMember(Name = "temperatures", EmitDefaultValue = false)]
        public AssetTemperatures Temperatures { get; set; }

        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        [DataMember(Name = "locations", EmitDefaultValue = false)]
        public AssetLocations Locations { get; set; }

        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        [DataMember(Name = "label", EmitDefaultValue = false)]
        public AssetLabel Label { get; set; }

        [DataMember(Name = "createdOn", EmitDefaultValue = false)]
        public DateTime CreatedOn { get; set; }

        [DataMember(Name = "workspaceId", IsRequired = true, EmitDefaultValue = true)]
        public Guid WorkspaceId { get; set; }
    }

}
