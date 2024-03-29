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
    /// # The Opportunity Object ### Description The &#x60;Opportunity&#x60; object is used to represent a deal opportunity in a CRM system. ### Usage Example TODO
    /// </summary>
    [DataContract(Name = "Opportunity")]
    public partial class Opportunity : IEquatable<Opportunity>, IValidatableObject
    {

        /// <summary>
        /// The opportunity&#39;s status.  * &#x60;OPEN&#x60; - OPEN * &#x60;WON&#x60; - WON * &#x60;LOST&#x60; - LOST
        /// </summary>
        /// <value>The opportunity&#39;s status.  * &#x60;OPEN&#x60; - OPEN * &#x60;WON&#x60; - WON * &#x60;LOST&#x60; - LOST</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public OpportunityStatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Opportunity" /> class.
        /// </summary>
        /// <param name="name">The opportunity&#39;s name..</param>
        /// <param name="description">The opportunity&#39;s description..</param>
        /// <param name="amount">The opportunity&#39;s amount..</param>
        /// <param name="owner">The opportunity&#39;s owner..</param>
        /// <param name="account">The account of the opportunity..</param>
        /// <param name="stage">The stage of the opportunity..</param>
        /// <param name="status">The opportunity&#39;s status.  * &#x60;OPEN&#x60; - OPEN * &#x60;WON&#x60; - WON * &#x60;LOST&#x60; - LOST.</param>
        /// <param name="lastActivityAt">When the opportunity&#39;s last activity occurred..</param>
        /// <param name="closeDate">When the opportunity was closed..</param>
        /// <param name="remoteCreatedAt">When the third party&#39;s opportunity was created..</param>
        /// <param name="remoteId">The third-party API ID of the matching object..</param>
        public Opportunity(string name = default(string), string description = default(string), int? amount = default(int?), Guid? owner = default(Guid?), Guid? account = default(Guid?), Guid? stage = default(Guid?), OpportunityStatusEnum? status = default(OpportunityStatusEnum?), DateTime? lastActivityAt = default(DateTime?), DateTime? closeDate = default(DateTime?), DateTime? remoteCreatedAt = default(DateTime?), string remoteId = default(string))
        {
            this.Name = name;
            this.Description = description;
            this.Amount = amount;
            this.Owner = owner;
            this.Account = account;
            this.Stage = stage;
            this.Status = status;
            this.LastActivityAt = lastActivityAt;
            this.CloseDate = closeDate;
            this.RemoteCreatedAt = remoteCreatedAt;
            this.RemoteId = remoteId;
        }

        /// <summary>
        /// The opportunity&#39;s name.
        /// </summary>
        /// <value>The opportunity&#39;s name.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The opportunity&#39;s description.
        /// </summary>
        /// <value>The opportunity&#39;s description.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The opportunity&#39;s amount.
        /// </summary>
        /// <value>The opportunity&#39;s amount.</value>
        [DataMember(Name = "amount", EmitDefaultValue = true)]
        public int? Amount { get; set; }

        /// <summary>
        /// The opportunity&#39;s owner.
        /// </summary>
        /// <value>The opportunity&#39;s owner.</value>
        [DataMember(Name = "owner", EmitDefaultValue = true)]
        public Guid? Owner { get; set; }

        /// <summary>
        /// The account of the opportunity.
        /// </summary>
        /// <value>The account of the opportunity.</value>
        [DataMember(Name = "account", EmitDefaultValue = true)]
        public Guid? Account { get; set; }

        /// <summary>
        /// The stage of the opportunity.
        /// </summary>
        /// <value>The stage of the opportunity.</value>
        [DataMember(Name = "stage", EmitDefaultValue = true)]
        public Guid? Stage { get; set; }

        /// <summary>
        /// When the opportunity&#39;s last activity occurred.
        /// </summary>
        /// <value>When the opportunity&#39;s last activity occurred.</value>
        [DataMember(Name = "last_activity_at", EmitDefaultValue = true)]
        public DateTime? LastActivityAt { get; set; }

        /// <summary>
        /// When the opportunity was closed.
        /// </summary>
        /// <value>When the opportunity was closed.</value>
        [DataMember(Name = "close_date", EmitDefaultValue = true)]
        public DateTime? CloseDate { get; set; }

        /// <summary>
        /// When the third party&#39;s opportunity was created.
        /// </summary>
        /// <value>When the third party&#39;s opportunity was created.</value>
        [DataMember(Name = "remote_created_at", EmitDefaultValue = true)]
        public DateTime? RemoteCreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets RemoteWasDeleted
        /// </summary>
        [DataMember(Name = "remote_was_deleted", EmitDefaultValue = true)]
        public bool RemoteWasDeleted { get; private set; }

        /// <summary>
        /// Returns false as RemoteWasDeleted should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRemoteWasDeleted()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }

        /// <summary>
        /// The third-party API ID of the matching object.
        /// </summary>
        /// <value>The third-party API ID of the matching object.</value>
        [DataMember(Name = "remote_id", EmitDefaultValue = true)]
        public string RemoteId { get; set; }

        /// <summary>
        /// Gets or Sets FieldMappings
        /// </summary>
        [DataMember(Name = "field_mappings", EmitDefaultValue = true)]
        public Dictionary<string, Object> FieldMappings { get; private set; }

        /// <summary>
        /// Returns false as FieldMappings should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFieldMappings()
        {
            return false;
        }

        /// <summary>
        /// This is the datetime that this object was last updated by Merge
        /// </summary>
        /// <value>This is the datetime that this object was last updated by Merge</value>
        [DataMember(Name = "modified_at", EmitDefaultValue = false)]
        public DateTime ModifiedAt { get; private set; }

        /// <summary>
        /// Returns false as ModifiedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeModifiedAt()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets RemoteData
        /// </summary>
        [DataMember(Name = "remote_data", EmitDefaultValue = true)]
        public List<RemoteData> RemoteData { get; private set; }

        /// <summary>
        /// Returns false as RemoteData should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRemoteData()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets RemoteFields
        /// </summary>
        [DataMember(Name = "remote_fields", EmitDefaultValue = false)]
        public List<RemoteField> RemoteFields { get; private set; }

        /// <summary>
        /// Returns false as RemoteFields should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRemoteFields()
        {
            return false;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Opportunity {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Stage: ").Append(Stage).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  LastActivityAt: ").Append(LastActivityAt).Append("\n");
            sb.Append("  CloseDate: ").Append(CloseDate).Append("\n");
            sb.Append("  RemoteCreatedAt: ").Append(RemoteCreatedAt).Append("\n");
            sb.Append("  RemoteWasDeleted: ").Append(RemoteWasDeleted).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RemoteId: ").Append(RemoteId).Append("\n");
            sb.Append("  FieldMappings: ").Append(FieldMappings).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
            sb.Append("  RemoteData: ").Append(RemoteData).Append("\n");
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
            return this.Equals(input as Opportunity);
        }

        /// <summary>
        /// Returns true if Opportunity instances are equal
        /// </summary>
        /// <param name="input">Instance of Opportunity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Opportunity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Stage == input.Stage ||
                    (this.Stage != null &&
                    this.Stage.Equals(input.Stage))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.LastActivityAt == input.LastActivityAt ||
                    (this.LastActivityAt != null &&
                    this.LastActivityAt.Equals(input.LastActivityAt))
                ) && 
                (
                    this.CloseDate == input.CloseDate ||
                    (this.CloseDate != null &&
                    this.CloseDate.Equals(input.CloseDate))
                ) && 
                (
                    this.RemoteCreatedAt == input.RemoteCreatedAt ||
                    (this.RemoteCreatedAt != null &&
                    this.RemoteCreatedAt.Equals(input.RemoteCreatedAt))
                ) && 
                (
                    this.RemoteWasDeleted == input.RemoteWasDeleted ||
                    this.RemoteWasDeleted.Equals(input.RemoteWasDeleted)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RemoteId == input.RemoteId ||
                    (this.RemoteId != null &&
                    this.RemoteId.Equals(input.RemoteId))
                ) && 
                (
                    this.FieldMappings == input.FieldMappings ||
                    this.FieldMappings != null &&
                    input.FieldMappings != null &&
                    this.FieldMappings.SequenceEqual(input.FieldMappings)
                ) && 
                (
                    this.ModifiedAt == input.ModifiedAt ||
                    (this.ModifiedAt != null &&
                    this.ModifiedAt.Equals(input.ModifiedAt))
                ) && 
                (
                    this.RemoteData == input.RemoteData ||
                    this.RemoteData != null &&
                    input.RemoteData != null &&
                    this.RemoteData.SequenceEqual(input.RemoteData)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Stage != null)
                    hashCode = hashCode * 59 + this.Stage.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.LastActivityAt != null)
                    hashCode = hashCode * 59 + this.LastActivityAt.GetHashCode();
                if (this.CloseDate != null)
                    hashCode = hashCode * 59 + this.CloseDate.GetHashCode();
                if (this.RemoteCreatedAt != null)
                    hashCode = hashCode * 59 + this.RemoteCreatedAt.GetHashCode();
                hashCode = hashCode * 59 + this.RemoteWasDeleted.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RemoteId != null)
                    hashCode = hashCode * 59 + this.RemoteId.GetHashCode();
                if (this.FieldMappings != null)
                    hashCode = hashCode * 59 + this.FieldMappings.GetHashCode();
                if (this.ModifiedAt != null)
                    hashCode = hashCode * 59 + this.ModifiedAt.GetHashCode();
                if (this.RemoteData != null)
                    hashCode = hashCode * 59 + this.RemoteData.GetHashCode();
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
            // Amount (int?) maximum
            if(this.Amount > (int?)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, must be a value less than or equal to 2147483647.", new [] { "Amount" });
            }

            // Amount (int?) minimum
            if(this.Amount < (int?)-2147483648)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, must be a value greater than or equal to -2147483648.", new [] { "Amount" });
            }

            yield break;
        }
    }

}
