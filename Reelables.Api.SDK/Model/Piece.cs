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
    /// Piece
    /// </summary>
    [DataContract(Name = "Piece")]
    public partial class Piece : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Piece" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Piece() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Piece" /> class.
        /// </summary>
        /// <param name="trackingRef">The tracking reference that identifies the Piece in the user system (required).</param>
        /// <param name="inFacilities">inFacilities.</param>
        /// <param name="consignmentId">Unique identifier of the Consignment that the Piece belongs to. Example: &#39;d290f1ee-6c54-4b01-90e6-d701748f0851&#39; (required).</param>
        /// <param name="id">Unique identifier of the Piece. Example: &#39;00Es43YBJfNRXNSvLmni&#39; (required).</param>
        /// <param name="label">label.</param>
        /// <param name="createdOn">Date that the Piece was created, in UTC. Example: &#39;2019-07-21T17:32:28Z&#39;.</param>
        /// <param name="workspaceId">Unique identifier of the Workspace that the Piece belongs to. Example: &#39;d290f1ee-6c54-4b01-90e6-d701748f0851&#39; (required).</param>
        public Piece(string trackingRef = default(string), List<InFacility> inFacilities = default(List<InFacility>), Guid consignmentId = default(Guid), string id = default(string), AssetLabel label = default(AssetLabel), DateTime createdOn = default(DateTime), Guid workspaceId = default(Guid))
        {
            // to ensure "trackingRef" is required (not null)
            if (trackingRef == null)
            {
                throw new ArgumentNullException("trackingRef is a required property for Piece and cannot be null");
            }
            this.TrackingRef = trackingRef;
            this.ConsignmentId = consignmentId;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Piece and cannot be null");
            }
            this.Id = id;
            this.WorkspaceId = workspaceId;
            this.InFacilities = inFacilities;
            this.Label = label;
            this.CreatedOn = createdOn;
        }

        /// <summary>
        /// The tracking reference that identifies the Piece in the user system
        /// </summary>
        /// <value>The tracking reference that identifies the Piece in the user system</value>
        [DataMember(Name = "trackingRef", IsRequired = true, EmitDefaultValue = true)]
        public string TrackingRef { get; set; }

        /// <summary>
        /// Gets or Sets InFacilities
        /// </summary>
        [DataMember(Name = "inFacilities", EmitDefaultValue = false)]
        public List<InFacility> InFacilities { get; set; }

        /// <summary>
        /// Unique identifier of the Consignment that the Piece belongs to. Example: &#39;d290f1ee-6c54-4b01-90e6-d701748f0851&#39;
        /// </summary>
        /// <value>Unique identifier of the Consignment that the Piece belongs to. Example: &#39;d290f1ee-6c54-4b01-90e6-d701748f0851&#39;</value>
        [DataMember(Name = "consignmentId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ConsignmentId { get; set; }

        /// <summary>
        /// Unique identifier of the Piece. Example: &#39;00Es43YBJfNRXNSvLmni&#39;
        /// </summary>
        /// <value>Unique identifier of the Piece. Example: &#39;00Es43YBJfNRXNSvLmni&#39;</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public AssetLabel Label { get; set; }

        /// <summary>
        /// Date that the Piece was created, in UTC. Example: &#39;2019-07-21T17:32:28Z&#39;
        /// </summary>
        /// <value>Date that the Piece was created, in UTC. Example: &#39;2019-07-21T17:32:28Z&#39;</value>
        [DataMember(Name = "createdOn", EmitDefaultValue = false)]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Unique identifier of the Workspace that the Piece belongs to. Example: &#39;d290f1ee-6c54-4b01-90e6-d701748f0851&#39;
        /// </summary>
        /// <value>Unique identifier of the Workspace that the Piece belongs to. Example: &#39;d290f1ee-6c54-4b01-90e6-d701748f0851&#39;</value>
        [DataMember(Name = "workspaceId", IsRequired = true, EmitDefaultValue = true)]
        public Guid WorkspaceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Piece {\n");
            sb.Append("  TrackingRef: ").Append(TrackingRef).Append("\n");
            sb.Append("  InFacilities: ").Append(InFacilities).Append("\n");
            sb.Append("  ConsignmentId: ").Append(ConsignmentId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
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
            // TrackingRef (string) maxLength
            if (this.TrackingRef != null && this.TrackingRef.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TrackingRef, length must be less than 500.", new [] { "TrackingRef" });
            }

            // ConsignmentId (Guid) maxLength
            if (this.ConsignmentId != null && this.ConsignmentId.Length > 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ConsignmentId, length must be less than 36.", new [] { "ConsignmentId" });
            }

            if (this.ConsignmentId != null) {
                // ConsignmentId (Guid) pattern
                Regex regexConsignmentId = new Regex(@"^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$", RegexOptions.CultureInvariant);
                if (!regexConsignmentId.Match(this.ConsignmentId.ToString()).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ConsignmentId, must match a pattern of " + regexConsignmentId, new [] { "ConsignmentId" });
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
