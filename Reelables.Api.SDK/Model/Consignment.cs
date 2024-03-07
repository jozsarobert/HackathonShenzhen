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

    [DataContract(Name = "Consignment")]
    public partial class Consignment
    {
        [JsonConstructorAttribute]
        protected Consignment() { }

        [DataMember(Name = "pieces", EmitDefaultValue = false)]
        public ConsignmentPieces Pieces { get; set; }

        [DataMember(Name = "trackingRef", IsRequired = true, EmitDefaultValue = true)]
        public string TrackingRef { get; set; }

        [DataMember(Name = "gateways", EmitDefaultValue = false)]
        public ConsignmentGateways Gateways { get; set; }

        [DataMember(Name = "workspace", IsRequired = true, EmitDefaultValue = true)]
        public Workspace Workspace { get; set; }

        [DataMember(Name = "destination", EmitDefaultValue = false)]
        public ConsignmentDestination Destination { get; set; }

        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        [DataMember(Name = "isActive", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        [DataMember(Name = "deactivated", EmitDefaultValue = false)]
        public ConsignmentDeactivated Deactivated { get; set; }

        [DataMember(Name = "activated", EmitDefaultValue = false)]
        public ConsignmentActivated Activated { get; set; }

    }

}
