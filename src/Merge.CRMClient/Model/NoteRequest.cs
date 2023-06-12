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
    /// # The Note Object ### Description The &#x60;Note&#x60; object is used to represent a note on another object. ### Usage Example TODO
    /// </summary>
    [DataContract(Name = "NoteRequest")]
    public partial class NoteRequest : IEquatable<NoteRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoteRequest" /> class.
        /// </summary>
        /// <param name="owner">The note&#39;s owner..</param>
        /// <param name="content">The note&#39;s content..</param>
        /// <param name="contact">The note&#39;s contact..</param>
        /// <param name="account">The note&#39;s account..</param>
        /// <param name="opportunity">The note&#39;s opportunity..</param>
        /// <param name="integrationParams">integrationParams.</param>
        /// <param name="linkedAccountParams">linkedAccountParams.</param>
        /// <param name="remoteFields">remoteFields.</param>
        public NoteRequest(Guid? owner = default(Guid?), string content = default(string), Guid? contact = default(Guid?), Guid? account = default(Guid?), Guid? opportunity = default(Guid?), Dictionary<string, Object> integrationParams = default(Dictionary<string, Object>), Dictionary<string, Object> linkedAccountParams = default(Dictionary<string, Object>), List<RemoteFieldRequest> remoteFields = default(List<RemoteFieldRequest>))
        {
            this.Owner = owner;
            this.Content = content;
            this.Contact = contact;
            this.Account = account;
            this.Opportunity = opportunity;
            this.IntegrationParams = integrationParams;
            this.LinkedAccountParams = linkedAccountParams;
            this.RemoteFields = remoteFields;
        }

        /// <summary>
        /// The note&#39;s owner.
        /// </summary>
        /// <value>The note&#39;s owner.</value>
        [DataMember(Name = "owner", EmitDefaultValue = true)]
        public Guid? Owner { get; set; }

        /// <summary>
        /// The note&#39;s content.
        /// </summary>
        /// <value>The note&#39;s content.</value>
        [DataMember(Name = "content", EmitDefaultValue = true)]
        public string Content { get; set; }

        /// <summary>
        /// The note&#39;s contact.
        /// </summary>
        /// <value>The note&#39;s contact.</value>
        [DataMember(Name = "contact", EmitDefaultValue = true)]
        public Guid? Contact { get; set; }

        /// <summary>
        /// The note&#39;s account.
        /// </summary>
        /// <value>The note&#39;s account.</value>
        [DataMember(Name = "account", EmitDefaultValue = true)]
        public Guid? Account { get; set; }

        /// <summary>
        /// The note&#39;s opportunity.
        /// </summary>
        /// <value>The note&#39;s opportunity.</value>
        [DataMember(Name = "opportunity", EmitDefaultValue = true)]
        public Guid? Opportunity { get; set; }

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
            sb.Append("class NoteRequest {\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Opportunity: ").Append(Opportunity).Append("\n");
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
            return this.Equals(input as NoteRequest);
        }

        /// <summary>
        /// Returns true if NoteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of NoteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NoteRequest input)
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
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Opportunity == input.Opportunity ||
                    (this.Opportunity != null &&
                    this.Opportunity.Equals(input.Opportunity))
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
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Opportunity != null)
                    hashCode = hashCode * 59 + this.Opportunity.GetHashCode();
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
