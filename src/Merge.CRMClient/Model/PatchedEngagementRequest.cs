/*
 * Merge CRM API
 *
 * The unified API for building rich integrations with multiple CRM platforms.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: hello@merge.dev
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
using OpenAPIDateConverter = Merge.CRMClient.Client.OpenAPIDateConverter;

namespace Merge.CRMClient.Model
{
    /// <summary>
    /// # The Engagement Object ### Description The &#x60;Engagement&#x60; object is used to represent an interaction noted in a CRM system. ### Usage Example TODO
    /// </summary>
    [DataContract(Name = "PatchedEngagementRequest")]
    public partial class PatchedEngagementRequest : IEquatable<PatchedEngagementRequest>, IValidatableObject
    {

        /// <summary>
        /// The engagement&#39;s direction.  * &#x60;INBOUND&#x60; - INBOUND * &#x60;OUTBOUND&#x60; - OUTBOUND
        /// </summary>
        /// <value>The engagement&#39;s direction.  * &#x60;INBOUND&#x60; - INBOUND * &#x60;OUTBOUND&#x60; - OUTBOUND</value>
        [DataMember(Name = "direction", EmitDefaultValue = true)]
        public DirectionEnum? Direction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedEngagementRequest" /> class.
        /// </summary>
        /// <param name="owner">The engagement&#39;s owner..</param>
        /// <param name="content">The engagement&#39;s content..</param>
        /// <param name="subject">The engagement&#39;s subject..</param>
        /// <param name="direction">The engagement&#39;s direction.  * &#x60;INBOUND&#x60; - INBOUND * &#x60;OUTBOUND&#x60; - OUTBOUND.</param>
        /// <param name="engagementType">The engagement type of the engagement..</param>
        /// <param name="startTime">The time at which the engagement started..</param>
        /// <param name="endTime">The time at which the engagement ended..</param>
        /// <param name="account">The account of the engagement..</param>
        /// <param name="contacts">contacts.</param>
        /// <param name="integrationParams">integrationParams.</param>
        /// <param name="linkedAccountParams">linkedAccountParams.</param>
        /// <param name="remoteFields">remoteFields.</param>
        public PatchedEngagementRequest(Guid? owner = default(Guid?), string content = default(string), string subject = default(string), DirectionEnum? direction = default(DirectionEnum?), Guid? engagementType = default(Guid?), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), Guid? account = default(Guid?), List<Guid?> contacts = default(List<Guid?>), Dictionary<string, Object> integrationParams = default(Dictionary<string, Object>), Dictionary<string, Object> linkedAccountParams = default(Dictionary<string, Object>), List<RemoteFieldRequest> remoteFields = default(List<RemoteFieldRequest>))
        {
            this.Owner = owner;
            this.Content = content;
            this.Subject = subject;
            this.Direction = direction;
            this.EngagementType = engagementType;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Account = account;
            this.Contacts = contacts;
            this.IntegrationParams = integrationParams;
            this.LinkedAccountParams = linkedAccountParams;
            this.RemoteFields = remoteFields;
        }

        /// <summary>
        /// The engagement&#39;s owner.
        /// </summary>
        /// <value>The engagement&#39;s owner.</value>
        [DataMember(Name = "owner", EmitDefaultValue = true)]
        public Guid? Owner { get; set; }

        /// <summary>
        /// The engagement&#39;s content.
        /// </summary>
        /// <value>The engagement&#39;s content.</value>
        [DataMember(Name = "content", EmitDefaultValue = true)]
        public string Content { get; set; }

        /// <summary>
        /// The engagement&#39;s subject.
        /// </summary>
        /// <value>The engagement&#39;s subject.</value>
        [DataMember(Name = "subject", EmitDefaultValue = true)]
        public string Subject { get; set; }

        /// <summary>
        /// The engagement type of the engagement.
        /// </summary>
        /// <value>The engagement type of the engagement.</value>
        [DataMember(Name = "engagement_type", EmitDefaultValue = true)]
        public Guid? EngagementType { get; set; }

        /// <summary>
        /// The time at which the engagement started.
        /// </summary>
        /// <value>The time at which the engagement started.</value>
        [DataMember(Name = "start_time", EmitDefaultValue = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// The time at which the engagement ended.
        /// </summary>
        /// <value>The time at which the engagement ended.</value>
        [DataMember(Name = "end_time", EmitDefaultValue = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// The account of the engagement.
        /// </summary>
        /// <value>The account of the engagement.</value>
        [DataMember(Name = "account", EmitDefaultValue = true)]
        public Guid? Account { get; set; }

        /// <summary>
        /// Gets or Sets Contacts
        /// </summary>
        [DataMember(Name = "contacts", EmitDefaultValue = false)]
        public List<Guid?> Contacts { get; set; }

        /// <summary>
        /// Gets or Sets IntegrationParams
        /// </summary>
        [DataMember(Name = "integration_params", EmitDefaultValue = true)]
        public Dictionary<string, Object> IntegrationParams { get; set; }

        /// <summary>
        /// Gets or Sets LinkedAccountParams
        /// </summary>
        [DataMember(Name = "linked_account_params", EmitDefaultValue = true)]
        public Dictionary<string, Object> LinkedAccountParams { get; set; }

        /// <summary>
        /// Gets or Sets RemoteFields
        /// </summary>
        [DataMember(Name = "remote_fields", EmitDefaultValue = false)]
        public List<RemoteFieldRequest> RemoteFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatchedEngagementRequest {\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  EngagementType: ").Append(EngagementType).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  IntegrationParams: ").Append(IntegrationParams).Append("\n");
            sb.Append("  LinkedAccountParams: ").Append(LinkedAccountParams).Append("\n");
            sb.Append("  RemoteFields: ").Append(RemoteFields).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PatchedEngagementRequest);
        }

        /// <summary>
        /// Returns true if PatchedEngagementRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PatchedEngagementRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchedEngagementRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Direction == input.Direction ||
                    this.Direction.Equals(input.Direction)
                ) && 
                (
                    this.EngagementType == input.EngagementType ||
                    (this.EngagementType != null &&
                    this.EngagementType.Equals(input.EngagementType))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Contacts == input.Contacts ||
                    this.Contacts != null &&
                    input.Contacts != null &&
                    this.Contacts.SequenceEqual(input.Contacts)
                ) && 
                (
                    this.IntegrationParams == input.IntegrationParams ||
                    this.IntegrationParams != null &&
                    input.IntegrationParams != null &&
                    this.IntegrationParams.SequenceEqual(input.IntegrationParams)
                ) && 
                (
                    this.LinkedAccountParams == input.LinkedAccountParams ||
                    this.LinkedAccountParams != null &&
                    input.LinkedAccountParams != null &&
                    this.LinkedAccountParams.SequenceEqual(input.LinkedAccountParams)
                ) && 
                (
                    this.RemoteFields == input.RemoteFields ||
                    this.RemoteFields != null &&
                    input.RemoteFields != null &&
                    this.RemoteFields.SequenceEqual(input.RemoteFields)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.EngagementType != null)
                    hashCode = hashCode * 59 + this.EngagementType.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Contacts != null)
                    hashCode = hashCode * 59 + this.Contacts.GetHashCode();
                if (this.IntegrationParams != null)
                    hashCode = hashCode * 59 + this.IntegrationParams.GetHashCode();
                if (this.LinkedAccountParams != null)
                    hashCode = hashCode * 59 + this.LinkedAccountParams.GetHashCode();
                if (this.RemoteFields != null)
                    hashCode = hashCode * 59 + this.RemoteFields.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
