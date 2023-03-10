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
    /// WarningValidationProblem
    /// </summary>
    [DataContract(Name = "WarningValidationProblem")]
    public partial class WarningValidationProblem : IEquatable<WarningValidationProblem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WarningValidationProblem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WarningValidationProblem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WarningValidationProblem" /> class.
        /// </summary>
        /// <param name="source">source.</param>
        /// <param name="title">title (required).</param>
        /// <param name="detail">detail (required).</param>
        /// <param name="problemType">problemType (required).</param>
        public WarningValidationProblem(ValidationProblemSource source = default(ValidationProblemSource), string title = default(string), string detail = default(string), string problemType = default(string))
        {
            // to ensure "title" is required (not null)
            this.Title = title ?? throw new ArgumentNullException("title is a required property for WarningValidationProblem and cannot be null");
            // to ensure "detail" is required (not null)
            this.Detail = detail ?? throw new ArgumentNullException("detail is a required property for WarningValidationProblem and cannot be null");
            // to ensure "problemType" is required (not null)
            this.ProblemType = problemType ?? throw new ArgumentNullException("problemType is a required property for WarningValidationProblem and cannot be null");
            this.Source = source;
        }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public ValidationProblemSource Source { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Detail
        /// </summary>
        [DataMember(Name = "detail", IsRequired = true, EmitDefaultValue = false)]
        public string Detail { get; set; }

        /// <summary>
        /// Gets or Sets ProblemType
        /// </summary>
        [DataMember(Name = "problem_type", IsRequired = true, EmitDefaultValue = false)]
        public string ProblemType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WarningValidationProblem {\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  ProblemType: ").Append(ProblemType).Append("\n");
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
            return this.Equals(input as WarningValidationProblem);
        }

        /// <summary>
        /// Returns true if WarningValidationProblem instances are equal
        /// </summary>
        /// <param name="input">Instance of WarningValidationProblem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WarningValidationProblem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
                ) && 
                (
                    this.ProblemType == input.ProblemType ||
                    (this.ProblemType != null &&
                    this.ProblemType.Equals(input.ProblemType))
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
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
                if (this.ProblemType != null)
                    hashCode = hashCode * 59 + this.ProblemType.GetHashCode();
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
