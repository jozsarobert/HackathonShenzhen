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
    [DataContract(Name = "AssetTemperatures")]
    public partial class AssetTemperatures
    {
        [JsonConstructorAttribute]
        protected AssetTemperatures() { }
       
        [DataMember(Name = "nextToken", EmitDefaultValue = false)]
        public string NextToken { get; set; }

        [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = true)]
        public List<Temperature> Items { get; set; }

     
    }

}
