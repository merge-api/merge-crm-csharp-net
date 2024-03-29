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
    /// RemoteFieldClass
    /// </summary>
    [DataContract(Name = "RemoteFieldClass")]
    public partial class RemoteFieldClass : IEquatable<RemoteFieldClass>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets FieldType
        /// </summary>
        [DataMember(Name = "field_type", EmitDefaultValue = false)]
        public FieldTypeEnum? FieldType { get; set; }

        /// <summary>
        /// Gets or Sets FieldFormat
        /// </summary>
        [DataMember(Name = "field_format", EmitDefaultValue = false)]
        public FieldFormatEnum? FieldFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteFieldClass" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="remoteKeyName">remoteKeyName.</param>
        /// <param name="description">description.</param>
        /// <param name="isCustom">isCustom.</param>
        /// <param name="isRequired">isRequired.</param>
        /// <param name="fieldType">fieldType.</param>
        /// <param name="fieldFormat">fieldFormat.</param>
        /// <param name="fieldChoices">fieldChoices.</param>
        /// <param name="itemSchema">itemSchema.</param>
        public RemoteFieldClass(string id = default(string), string displayName = default(string), string remoteKeyName = default(string), string description = default(string), bool isCustom = default(bool), bool isRequired = default(bool), FieldTypeEnum? fieldType = default(FieldTypeEnum?), FieldFormatEnum? fieldFormat = default(FieldFormatEnum?), List<string> fieldChoices = default(List<string>), ItemSchema itemSchema = default(ItemSchema))
        {
            this.Id = id;
            this.DisplayName = displayName;
            this.RemoteKeyName = remoteKeyName;
            this.Description = description;
            this.IsCustom = isCustom;
            this.IsRequired = isRequired;
            this.FieldType = fieldType;
            this.FieldFormat = fieldFormat;
            this.FieldChoices = fieldChoices;
            this.ItemSchema = itemSchema;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "display_name", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets RemoteKeyName
        /// </summary>
        [DataMember(Name = "remote_key_name", EmitDefaultValue = false)]
        public string RemoteKeyName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets IsCustom
        /// </summary>
        [DataMember(Name = "is_custom", EmitDefaultValue = true)]
        public bool IsCustom { get; set; }

        /// <summary>
        /// Gets or Sets IsRequired
        /// </summary>
        [DataMember(Name = "is_required", EmitDefaultValue = true)]
        public bool IsRequired { get; set; }

        /// <summary>
        /// Gets or Sets FieldChoices
        /// </summary>
        [DataMember(Name = "field_choices", EmitDefaultValue = false)]
        public List<string> FieldChoices { get; set; }

        /// <summary>
        /// Gets or Sets ItemSchema
        /// </summary>
        [DataMember(Name = "item_schema", EmitDefaultValue = false)]
        public ItemSchema ItemSchema { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoteFieldClass {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  RemoteKeyName: ").Append(RemoteKeyName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsCustom: ").Append(IsCustom).Append("\n");
            sb.Append("  IsRequired: ").Append(IsRequired).Append("\n");
            sb.Append("  FieldType: ").Append(FieldType).Append("\n");
            sb.Append("  FieldFormat: ").Append(FieldFormat).Append("\n");
            sb.Append("  FieldChoices: ").Append(FieldChoices).Append("\n");
            sb.Append("  ItemSchema: ").Append(ItemSchema).Append("\n");
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
            return this.Equals(input as RemoteFieldClass);
        }

        /// <summary>
        /// Returns true if RemoteFieldClass instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoteFieldClass to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoteFieldClass input)
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
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.RemoteKeyName == input.RemoteKeyName ||
                    (this.RemoteKeyName != null &&
                    this.RemoteKeyName.Equals(input.RemoteKeyName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IsCustom == input.IsCustom ||
                    this.IsCustom.Equals(input.IsCustom)
                ) && 
                (
                    this.IsRequired == input.IsRequired ||
                    this.IsRequired.Equals(input.IsRequired)
                ) && 
                (
                    this.FieldType == input.FieldType ||
                    this.FieldType.Equals(input.FieldType)
                ) && 
                (
                    this.FieldFormat == input.FieldFormat ||
                    this.FieldFormat.Equals(input.FieldFormat)
                ) && 
                (
                    this.FieldChoices == input.FieldChoices ||
                    this.FieldChoices != null &&
                    input.FieldChoices != null &&
                    this.FieldChoices.SequenceEqual(input.FieldChoices)
                ) && 
                (
                    this.ItemSchema == input.ItemSchema ||
                    (this.ItemSchema != null &&
                    this.ItemSchema.Equals(input.ItemSchema))
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
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.RemoteKeyName != null)
                    hashCode = hashCode * 59 + this.RemoteKeyName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.IsCustom.GetHashCode();
                hashCode = hashCode * 59 + this.IsRequired.GetHashCode();
                hashCode = hashCode * 59 + this.FieldType.GetHashCode();
                hashCode = hashCode * 59 + this.FieldFormat.GetHashCode();
                if (this.FieldChoices != null)
                    hashCode = hashCode * 59 + this.FieldChoices.GetHashCode();
                if (this.ItemSchema != null)
                    hashCode = hashCode * 59 + this.ItemSchema.GetHashCode();
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
