/*
 * Reelables API
 *
 * RESTful API for communicating with the Reelables Platform.
 *
 * The version of the OpenAPI document: 1.2.7
 * Contact: team@reelables.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


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
    /// <summary>
    /// Space
    /// </summary>
    [DataContract(Name = "Space")]
    public partial class Space : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Space" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Space() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Space" /> class.
        /// </summary>
        /// <param name="numberAssetsInSpace">The total number of Assets currently in the Space.</param>
        /// <param name="name">The name of the Space (required).</param>
        /// <param name="locations">locations.</param>
        /// <param name="id">Unique identifier of the Space. Example: &#39;00Es43YBJfNRXNSvLmni&#39; (required).</param>
        /// <param name="createdOn">Date that the Space was created, in UTC. Example: &#39;2019-07-21T17:32:28Z&#39;.</param>
        /// <param name="gateway">gateway.</param>
        /// <param name="workspaceId">Unique identifier of the Workspace that the Space belongs to. Example: &#39;d290f1ee-6c54-4b01-90e6-d701748f0851&#39; (required).</param>
        public Space(int numberAssetsInSpace = default(int), string name = default(string), AssetLocations locations = default(AssetLocations), string id = default(string), DateTime createdOn = default(DateTime), SpaceGateway gateway = default(SpaceGateway), Guid workspaceId = default(Guid))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Space and cannot be null");
            }
            this.Name = name;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Space and cannot be null");
            }
            this.Id = id;
            this.WorkspaceId = workspaceId;
            this.NumberAssetsInSpace = numberAssetsInSpace;
            this.Locations = locations;
            this.CreatedOn = createdOn;
            this.Gateway = gateway;
        }

        /// <summary>
        /// The total number of Assets currently in the Space
        /// </summary>
        /// <value>The total number of Assets currently in the Space</value>
        [DataMember(Name = "numberAssetsInSpace", EmitDefaultValue = false)]
        public int NumberAssetsInSpace { get; set; }

        /// <summary>
        /// The name of the Space
        /// </summary>
        /// <value>The name of the Space</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Locations
        /// </summary>
        [DataMember(Name = "locations", EmitDefaultValue = false)]
        public AssetLocations Locations { get; set; }

        /// <summary>
        /// Unique identifier of the Space. Example: &#39;00Es43YBJfNRXNSvLmni&#39;
        /// </summary>
        /// <value>Unique identifier of the Space. Example: &#39;00Es43YBJfNRXNSvLmni&#39;</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Date that the Space was created, in UTC. Example: &#39;2019-07-21T17:32:28Z&#39;
        /// </summary>
        /// <value>Date that the Space was created, in UTC. Example: &#39;2019-07-21T17:32:28Z&#39;</value>
        [DataMember(Name = "createdOn", EmitDefaultValue = false)]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Gets or Sets Gateway
        /// </summary>
        [DataMember(Name = "gateway", EmitDefaultValue = false)]
        public SpaceGateway Gateway { get; set; }

        /// <summary>
        /// Unique identifier of the Workspace that the Space belongs to. Example: &#39;d290f1ee-6c54-4b01-90e6-d701748f0851&#39;
        /// </summary>
        /// <value>Unique identifier of the Workspace that the Space belongs to. Example: &#39;d290f1ee-6c54-4b01-90e6-d701748f0851&#39;</value>
        [DataMember(Name = "workspaceId", IsRequired = true, EmitDefaultValue = true)]
        public Guid WorkspaceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Space {\n");
            sb.Append("  NumberAssetsInSpace: ").Append(NumberAssetsInSpace).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Locations: ").Append(Locations).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  Gateway: ").Append(Gateway).Append("\n");
            sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // NumberAssetsInSpace (int) maximum
            if (this.NumberAssetsInSpace > (int)1000000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NumberAssetsInSpace, must be a value less than or equal to 1000000.", new [] { "NumberAssetsInSpace" });
            }

            // NumberAssetsInSpace (int) minimum
            if (this.NumberAssetsInSpace < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NumberAssetsInSpace, must be a value greater than or equal to 0.", new [] { "NumberAssetsInSpace" });
            }

            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 500.", new [] { "Name" });
            }

            if (this.Name != null) {
                // Name (string) pattern
                Regex regexName = new Regex(@"^[a-zA-Z0-9!@#$&()\-`.+,/"" ]*$", RegexOptions.CultureInvariant);
                if (!regexName.Match(this.Name).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
                }
            }

            // Id (string) maxLength
            if (this.Id != null && this.Id.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be less than 20.", new [] { "Id" });
            }

            if (this.Id != null) {
                // Id (string) pattern
                Regex regexId = new Regex(@"^[-_A-Za-z0-9]*$", RegexOptions.CultureInvariant);
                if (!regexId.Match(this.Id).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
                }
            }

            // CreatedOn (DateTime) maxLength
            if (this.CreatedOn != null && this.CreatedOn.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CreatedOn, length must be less than 20.", new [] { "CreatedOn" });
            }

            if (this.CreatedOn != null) {
                // CreatedOn (DateTime) pattern
                Regex regexCreatedOn = new Regex(@"^[0-9TZ:-]*$", RegexOptions.CultureInvariant);
                if (!regexCreatedOn.Match(this.CreatedOn).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CreatedOn, must match a pattern of " + regexCreatedOn, new [] { "CreatedOn" });
                }
            }

            // WorkspaceId (Guid) maxLength
            if (this.WorkspaceId != null && this.WorkspaceId.Length > 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WorkspaceId, length must be less than 36.", new [] { "WorkspaceId" });
            }

            if (this.WorkspaceId != null) {
                // WorkspaceId (Guid) pattern
                Regex regexWorkspaceId = new Regex(@"^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$", RegexOptions.CultureInvariant);
                if (!regexWorkspaceId.Match(this.WorkspaceId.ToString()).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WorkspaceId, must match a pattern of " + regexWorkspaceId, new [] { "WorkspaceId" });
                }
            }

            yield break;
        }
    }

}
