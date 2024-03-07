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
    [DataContract(Name = "AssetGroup")]
    public partial class AssetGroup
    {
        [JsonConstructorAttribute]
        protected AssetGroup() { }
      
        [DataMember(Name = "facilityId", EmitDefaultValue = false)]
        public Guid FacilityId { get; set; }

        [DataMember(Name = "availabilityThreshold", EmitDefaultValue = false)]
        public int AvailabilityThreshold { get; set; }

        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        [DataMember(Name = "available", EmitDefaultValue = true)]
        public bool Available { get; set; }

        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count { get; set; }

        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        [DataMember(Name = "workspaceId", IsRequired = true, EmitDefaultValue = true)]
        public Guid WorkspaceId { get; set; }
    }

}
