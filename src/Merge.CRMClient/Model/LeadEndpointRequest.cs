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
    /// LeadEndpointRequest
    /// </summary>
    [DataContract(Name = "LeadEndpointRequest")]
    public partial class LeadEndpointRequest : IEquatable<LeadEndpointRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LeadEndpointRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LeadEndpointRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LeadEndpointRequest" /> class.
        /// </summary>
        /// <param name="model">model (required).</param>
        public LeadEndpointRequest(LeadRequest model = default(LeadRequest))
        {
            // to ensure "model" is required (not null)
            this.Model = model ?? throw new ArgumentNullException("model is a required property for LeadEndpointRequest and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name = "model", IsRequired = true, EmitDefaultValue = false)]
        public LeadRequest Model { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeadEndpointRequest {\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
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
            return this.Equals(input as LeadEndpointRequest);
        }

        /// <summary>
        /// Returns true if LeadEndpointRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LeadEndpointRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeadEndpointRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
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
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
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
