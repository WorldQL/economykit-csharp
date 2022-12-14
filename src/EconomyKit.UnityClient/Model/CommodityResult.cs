/*
 * EconomyKit API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * 
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = EconomyKit.UnityClient.Client.OpenAPIDateConverter;

namespace EconomyKit.UnityClient.Model
{
    /// <summary>
    /// CommodityResult
    /// </summary>
    [DataContract]
    public partial class CommodityResult :  IEquatable<CommodityResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommodityResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommodityResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommodityResult" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="displayName">displayName (required).</param>
        /// <param name="metadata">Extra, free-form data attached to a commodity..</param>
        /// <param name="image">image (required).</param>
        public CommodityResult(Guid id = default(Guid), string displayName = default(string), Object metadata = default(Object), string image = default(string))
        {
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for CommodityResult and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }

            // to ensure "image" is required (not null)
            if (image == null)
            {
                throw new InvalidDataException("image is a required property for CommodityResult and cannot be null");
            }
            else
            {
                this.Image = image;
            }

            this.Id = id;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="display_name", EmitDefaultValue=true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Extra, free-form data attached to a commodity.
        /// </summary>
        /// <value>Extra, free-form data attached to a commodity.</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=true)]
        public string Image { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommodityResult {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
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
            return this.Equals(input as CommodityResult);
        }

        /// <summary>
        /// Returns true if CommodityResult instances are equal
        /// </summary>
        /// <param name="input">Instance of CommodityResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommodityResult input)
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
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
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
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
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
            // DisplayName (string) maxLength
            if(this.DisplayName != null && this.DisplayName.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DisplayName, length must be less than 256.", new [] { "DisplayName" });
            }


            yield break;
        }
    }

}
