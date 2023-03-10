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
    /// # The PhoneNumber Object ### Description The &#x60;PhoneNumber&#x60; object is used to represent an entity&#39;s phone number. ### Usage Example Fetch from the &#x60;GET Contact&#x60; endpoint and view their phone numbers.
    /// </summary>
    [DataContract(Name = "PhoneNumberRequest")]
    public partial class PhoneNumberRequest : IEquatable<PhoneNumberRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberRequest" /> class.
        /// </summary>
        /// <param name="phoneNumber">The phone number..</param>
        /// <param name="phoneNumberType">The phone number&#39;s type..</param>
        /// <param name="integrationParams">integrationParams.</param>
        /// <param name="linkedAccountParams">linkedAccountParams.</param>
        public PhoneNumberRequest(string phoneNumber = default(string), string phoneNumberType = default(string), Dictionary<string, Object> integrationParams = default(Dictionary<string, Object>), Dictionary<string, Object> linkedAccountParams = default(Dictionary<string, Object>))
        {
            this.PhoneNumber = phoneNumber;
            this.PhoneNumberType = phoneNumberType;
            this.IntegrationParams = integrationParams;
            this.LinkedAccountParams = linkedAccountParams;
        }

        /// <summary>
        /// The phone number.
        /// </summary>
        /// <value>The phone number.</value>
        [DataMember(Name = "phone_number", EmitDefaultValue = true)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The phone number&#39;s type.
        /// </summary>
        /// <value>The phone number&#39;s type.</value>
        [DataMember(Name = "phone_number_type", EmitDefaultValue = true)]
        public string PhoneNumberType { get; set; }

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
            sb.Append("class PhoneNumberRequest {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  PhoneNumberType: ").Append(PhoneNumberType).Append("\n");
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
            return this.Equals(input as PhoneNumberRequest);
        }

        /// <summary>
        /// Returns true if PhoneNumberRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PhoneNumberRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneNumberRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.PhoneNumberType == input.PhoneNumberType ||
                    (this.PhoneNumberType != null &&
                    this.PhoneNumberType.Equals(input.PhoneNumberType))
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
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.PhoneNumberType != null)
                    hashCode = hashCode * 59 + this.PhoneNumberType.GetHashCode();
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
            yield break;
        }
    }

}
