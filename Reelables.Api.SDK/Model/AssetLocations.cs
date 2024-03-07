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

    [DataContract(Name = "Asset_locations")]
    public partial class AssetLocations
    {

        [JsonConstructorAttribute]
        protected AssetLocations() { }
      
        [DataMember(Name = "nextToken", EmitDefaultValue = false)]
        public string NextToken { get; set; }

        [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = true)]
        public List<Location> Items { get; set; } 
    }

}
