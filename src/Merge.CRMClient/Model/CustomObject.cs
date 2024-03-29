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
    /// # The CustomObject Object ### Description The &#x60;Custom Object&#x60; record refers to an instance of a Custom Object Class. ### Usage Example TODO
    /// </summary>
    [DataContract(Name = "CustomObject")]
    public partial class CustomObject : IEquatable<CustomObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomObject" /> class.
        /// </summary>
        /// <param name="objectClass">objectClass.</param>
        /// <param name="remoteId">The third-party API ID of the matching object..</param>
        public CustomObject(Guid? objectClass = default(Guid?), string remoteId = default(string))
        {
            this.ObjectClass = objectClass;
            this.RemoteId = remoteId;
        }

        /// <summary>
        /// Gets or Sets ObjectClass
        /// </summary>
        [DataMember(Name = "object_class", EmitDefaultValue = true)]
        public Guid? ObjectClass { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name = "fields", EmitDefaultValue = false)]
        public Dictionary<string, Object> Fields { get; private set; }

        /// <summary>
        /// Returns false as Fields should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFields()
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
            sb.Append("class CustomObject {\n");
            sb.Append("  ObjectClass: ").Append(ObjectClass).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  RemoteId: ").Append(RemoteId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
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
            return this.Equals(input as CustomObject);
        }

        /// <summary>
        /// Returns true if CustomObject instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectClass == input.ObjectClass ||
                    (this.ObjectClass != null &&
                    this.ObjectClass.Equals(input.ObjectClass))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.RemoteId == input.RemoteId ||
                    (this.RemoteId != null &&
                    this.RemoteId.Equals(input.RemoteId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ModifiedAt == input.ModifiedAt ||
                    (this.ModifiedAt != null &&
                    this.ModifiedAt.Equals(input.ModifiedAt))
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
                if (this.ObjectClass != null)
                    hashCode = hashCode * 59 + this.ObjectClass.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.RemoteId != null)
                    hashCode = hashCode * 59 + this.RemoteId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ModifiedAt != null)
                    hashCode = hashCode * 59 + this.ModifiedAt.GetHashCode();
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
