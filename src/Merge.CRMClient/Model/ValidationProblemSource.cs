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
    /// ValidationProblemSource
    /// </summary>
    [DataContract(Name = "ValidationProblemSource")]
    public partial class ValidationProblemSource : IEquatable<ValidationProblemSource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationProblemSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ValidationProblemSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationProblemSource" /> class.
        /// </summary>
        /// <param name="pointer">pointer (required).</param>
        public ValidationProblemSource(string pointer = default(string))
        {
            // to ensure "pointer" is required (not null)
            this.Pointer = pointer ?? throw new ArgumentNullException("pointer is a required property for ValidationProblemSource and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Pointer
        /// </summary>
        [DataMember(Name = "pointer", IsRequired = true, EmitDefaultValue = false)]
        public string Pointer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidationProblemSource {\n");
            sb.Append("  Pointer: ").Append(Pointer).Append("\n");
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
            return this.Equals(input as ValidationProblemSource);
        }

        /// <summary>
        /// Returns true if ValidationProblemSource instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidationProblemSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidationProblemSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pointer == input.Pointer ||
                    (this.Pointer != null &&
                    this.Pointer.Equals(input.Pointer))
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
                if (this.Pointer != null)
                    hashCode = hashCode * 59 + this.Pointer.GetHashCode();
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
