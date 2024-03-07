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
    [DataContract(Name = "AssetLabel")]
    public partial class AssetLabel
    {

        [JsonConstructorAttribute]
        protected AssetLabel() { }
     
        [DataMember(Name = "bleId", IsRequired = true, EmitDefaultValue = true)]
        public int BleId { get; set; }

        [DataMember(Name = "nfcId", IsRequired = true, EmitDefaultValue = true)]
        public string NfcId { get; set; }

        [DataMember(Name = "addedOn", IsRequired = true, EmitDefaultValue = true)]
        public DateTime AddedOn { get; set; }
    }

}
