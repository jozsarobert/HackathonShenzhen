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
    [DataContract(Name = "AssetInSpace")]
    public partial class AssetInSpace 
    {
        [JsonConstructorAttribute]
        protected AssetInSpace() { }
       
        [DataMember(Name = "spaceName", IsRequired = true, EmitDefaultValue = true)]
        public string SpaceName { get; set; }

        [DataMember(Name = "spaceId", IsRequired = true, EmitDefaultValue = true)]
        public string SpaceId { get; set; }

        [DataMember(Name = "hasExited", EmitDefaultValue = true)]
        public bool HasExited { get; set; }

        [DataMember(Name = "enteredOn", IsRequired = true, EmitDefaultValue = true)]
        public DateTime EnteredOn { get; set; }

        [DataMember(Name = "exitedOn", EmitDefaultValue = false)]
        public DateTime ExitedOn { get; set; }    
    }

}
