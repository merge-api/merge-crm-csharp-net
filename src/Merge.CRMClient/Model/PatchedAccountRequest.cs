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
    /// # The Account Object ### Description The &#x60;Account&#x60; object is used to represent a company in a CRM system. ### Usage Example TODO
    /// </summary>
    [DataContract(Name = "PatchedAccountRequest")]
    public partial class PatchedAccountRequest : IEquatable<PatchedAccountRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedAccountRequest" /> class.
        /// </summary>
        /// <param name="owner">The account&#39;s owner..</param>
        /// <param name="name">The account&#39;s name..</param>
        /// <param name="description">The account&#39;s description..</param>
        /// <param name="industry">The account&#39;s industry..</param>
        /// <param name="website">The account&#39;s website..</param>
        /// <param name="numberOfEmployees">The account&#39;s number of employees..</param>
        /// <param name="lastActivityAt">The last date (either most recent or furthest in the future) of when an activity occurs in an account..</param>
        /// <param name="integrationParams">integrationParams.</param>
        /// <param name="linkedAccountParams">linkedAccountParams.</param>
        public PatchedAccountRequest(Guid? owner = default(Guid?), string name = default(string), string description = default(string), string industry = default(string), string website = default(string), int? numberOfEmployees = default(int?), DateTime? lastActivityAt = default(DateTime?), Dictionary<string, Object> integrationParams = default(Dictionary<string, Object>), Dictionary<string, Object> linkedAccountParams = default(Dictionary<string, Object>))
        {
            this.Owner = owner;
            this.Name = name;
            this.Description = description;
            this.Industry = industry;
            this.Website = website;
            this.NumberOfEmployees = numberOfEmployees;
            this.LastActivityAt = lastActivityAt;
            this.IntegrationParams = integrationParams;
            this.LinkedAccountParams = linkedAccountParams;
        }

        /// <summary>
        /// The account&#39;s owner.
        /// </summary>
        /// <value>The account&#39;s owner.</value>
        [DataMember(Name = "owner", EmitDefaultValue = true)]
        public Guid? Owner { get; set; }

        /// <summary>
        /// The account&#39;s name.
        /// </summary>
        /// <value>The account&#39;s name.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The account&#39;s description.
        /// </summary>
        /// <value>The account&#39;s description.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The account&#39;s industry.
        /// </summary>
        /// <value>The account&#39;s industry.</value>
        [DataMember(Name = "industry", EmitDefaultValue = true)]
        public string Industry { get; set; }

        /// <summary>
        /// The account&#39;s website.
        /// </summary>
        /// <value>The account&#39;s website.</value>
        [DataMember(Name = "website", EmitDefaultValue = true)]
        public string Website { get; set; }

        /// <summary>
        /// The account&#39;s number of employees.
        /// </summary>
        /// <value>The account&#39;s number of employees.</value>
        [DataMember(Name = "number_of_employees", EmitDefaultValue = true)]
        public int? NumberOfEmployees { get; set; }

        /// <summary>
        /// The last date (either most recent or furthest in the future) of when an activity occurs in an account.
        /// </summary>
        /// <value>The last date (either most recent or furthest in the future) of when an activity occurs in an account.</value>
        [DataMember(Name = "last_activity_at", EmitDefaultValue = true)]
        public DateTime? LastActivityAt { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatchedAccountRequest {\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Industry: ").Append(Industry).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  NumberOfEmployees: ").Append(NumberOfEmployees).Append("\n");
            sb.Append("  LastActivityAt: ").Append(LastActivityAt).Append("\n");
            sb.Append("  IntegrationParams: ").Append(IntegrationParams).Append("\n");
            sb.Append("  LinkedAccountParams: ").Append(LinkedAccountParams).Append("\n");
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
            return this.Equals(input as PatchedAccountRequest);
        }

        /// <summary>
        /// Returns true if PatchedAccountRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PatchedAccountRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchedAccountRequest input)
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
                    this.Industry == input.Industry ||
                    (this.Industry != null &&
                    this.Industry.Equals(input.Industry))
                ) && 
                (
                    this.Website == input.Website ||
                    (this.Website != null &&
                    this.Website.Equals(input.Website))
                ) && 
                (
                    this.NumberOfEmployees == input.NumberOfEmployees ||
                    (this.NumberOfEmployees != null &&
                    this.NumberOfEmployees.Equals(input.NumberOfEmployees))
                ) && 
                (
                    this.LastActivityAt == input.LastActivityAt ||
                    (this.LastActivityAt != null &&
                    this.LastActivityAt.Equals(input.LastActivityAt))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Industry != null)
                    hashCode = hashCode * 59 + this.Industry.GetHashCode();
                if (this.Website != null)
                    hashCode = hashCode * 59 + this.Website.GetHashCode();
                if (this.NumberOfEmployees != null)
                    hashCode = hashCode * 59 + this.NumberOfEmployees.GetHashCode();
                if (this.LastActivityAt != null)
                    hashCode = hashCode * 59 + this.LastActivityAt.GetHashCode();
                if (this.IntegrationParams != null)
                    hashCode = hashCode * 59 + this.IntegrationParams.GetHashCode();
                if (this.LinkedAccountParams != null)
                    hashCode = hashCode * 59 + this.LinkedAccountParams.GetHashCode();
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
            // Website (string) maxLength
            if(this.Website != null && this.Website.Length > 2000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Website, length must be less than 2000.", new [] { "Website" });
            }

            // NumberOfEmployees (int?) maximum
            if(this.NumberOfEmployees > (int?)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NumberOfEmployees, must be a value less than or equal to 2147483647.", new [] { "NumberOfEmployees" });
            }

            // NumberOfEmployees (int?) minimum
            if(this.NumberOfEmployees < (int?)-2147483648)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NumberOfEmployees, must be a value greater than or equal to -2147483648.", new [] { "NumberOfEmployees" });
            }

            yield break;
        }
    }

}