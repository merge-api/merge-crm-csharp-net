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
    /// # The Address Object ### Description The &#x60;Address&#x60; object is used to represent an entity&#39;s address. ### Usage Example TODO
    /// </summary>
    [DataContract(Name = "Address")]
    public partial class Address : IEquatable<Address>, IValidatableObject
    {

        /// <summary>
        /// The address&#39;s country.
        /// </summary>
        /// <value>The address&#39;s country.</value>
        [DataMember(Name = "country", EmitDefaultValue = true)]
        public CountryEnum? Country { get; set; }

        /// <summary>
        /// The address type.
        /// </summary>
        /// <value>The address type.</value>
        [DataMember(Name = "address_type", EmitDefaultValue = true)]
        public AddressTypeEnum? AddressType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        /// <param name="street1">Line 1 of the address&#39;s street..</param>
        /// <param name="street2">Line 2 of the address&#39;s street..</param>
        /// <param name="city">The address&#39;s city..</param>
        /// <param name="state">The address&#39;s state..</param>
        /// <param name="postalCode">The address&#39;s postal code..</param>
        /// <param name="country">The address&#39;s country..</param>
        /// <param name="addressType">The address type..</param>
        public Address(string street1 = default(string), string street2 = default(string), string city = default(string), string state = default(string), string postalCode = default(string), CountryEnum? country = default(CountryEnum?), AddressTypeEnum? addressType = default(AddressTypeEnum?))
        {
            this.Street1 = street1;
            this.Street2 = street2;
            this.City = city;
            this.State = state;
            this.PostalCode = postalCode;
            this.Country = country;
            this.AddressType = addressType;
        }

        /// <summary>
        /// Line 1 of the address&#39;s street.
        /// </summary>
        /// <value>Line 1 of the address&#39;s street.</value>
        [DataMember(Name = "street_1", EmitDefaultValue = true)]
        public string Street1 { get; set; }

        /// <summary>
        /// Line 2 of the address&#39;s street.
        /// </summary>
        /// <value>Line 2 of the address&#39;s street.</value>
        [DataMember(Name = "street_2", EmitDefaultValue = true)]
        public string Street2 { get; set; }

        /// <summary>
        /// The address&#39;s city.
        /// </summary>
        /// <value>The address&#39;s city.</value>
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// The address&#39;s state.
        /// </summary>
        /// <value>The address&#39;s state.</value>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// The address&#39;s postal code.
        /// </summary>
        /// <value>The address&#39;s postal code.</value>
        [DataMember(Name = "postal_code", EmitDefaultValue = true)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  Street1: ").Append(Street1).Append("\n");
            sb.Append("  Street2: ").Append(Street2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  AddressType: ").Append(AddressType).Append("\n");
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
            return this.Equals(input as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="input">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Street1 == input.Street1 ||
                    (this.Street1 != null &&
                    this.Street1.Equals(input.Street1))
                ) && 
                (
                    this.Street2 == input.Street2 ||
                    (this.Street2 != null &&
                    this.Street2.Equals(input.Street2))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.Country == input.Country ||
                    this.Country.Equals(input.Country)
                ) && 
                (
                    this.AddressType == input.AddressType ||
                    this.AddressType.Equals(input.AddressType)
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
                if (this.Street1 != null)
                    hashCode = hashCode * 59 + this.Street1.GetHashCode();
                if (this.Street2 != null)
                    hashCode = hashCode * 59 + this.Street2.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                hashCode = hashCode * 59 + this.Country.GetHashCode();
                hashCode = hashCode * 59 + this.AddressType.GetHashCode();
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
