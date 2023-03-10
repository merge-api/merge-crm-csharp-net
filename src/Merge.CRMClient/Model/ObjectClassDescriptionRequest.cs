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
    /// ObjectClassDescriptionRequest
    /// </summary>
    [DataContract(Name = "ObjectClassDescriptionRequest")]
    public partial class ObjectClassDescriptionRequest : IEquatable<ObjectClassDescriptionRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets OriginType
        /// </summary>
        [DataMember(Name = "origin_type", IsRequired = true, EmitDefaultValue = false)]
        public OriginTypeEnum OriginType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectClassDescriptionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ObjectClassDescriptionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectClassDescriptionRequest" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="originType">originType (required).</param>
        public ObjectClassDescriptionRequest(string id = default(string), OriginTypeEnum originType = default(OriginTypeEnum))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for ObjectClassDescriptionRequest and cannot be null");
            this.OriginType = originType;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjectClassDescriptionRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OriginType: ").Append(OriginType).Append("\n");
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
            return this.Equals(input as ObjectClassDescriptionRequest);
        }

        /// <summary>
        /// Returns true if ObjectClassDescriptionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ObjectClassDescriptionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectClassDescriptionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.OriginType == input.OriginType ||
                    this.OriginType.Equals(input.OriginType)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.OriginType.GetHashCode();
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
            // Id (string) minLength
            if(this.Id != null && this.Id.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be greater than 1.", new [] { "Id" });
            }

            yield break;
        }
    }

}
