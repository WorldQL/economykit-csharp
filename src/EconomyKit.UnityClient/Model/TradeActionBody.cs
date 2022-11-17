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
    /// TradeActionBody
    /// </summary>
    [DataContract]
    public partial class TradeActionBody :  IEquatable<TradeActionBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeActionBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TradeActionBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeActionBody" /> class.
        /// </summary>
        /// <param name="trade">trade (required).</param>
        public TradeActionBody(Guid trade = default(Guid))
        {
            // to ensure "trade" is required (not null)
            if (trade == null)
            {
                throw new InvalidDataException("trade is a required property for TradeActionBody and cannot be null");
            }
            else
            {
                this.Trade = trade;
            }

        }

        /// <summary>
        /// Gets or Sets Trade
        /// </summary>
        [DataMember(Name="trade", EmitDefaultValue=true)]
        public Guid Trade { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TradeActionBody {\n");
            sb.Append("  Trade: ").Append(Trade).Append("\n");
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
            return this.Equals(input as TradeActionBody);
        }

        /// <summary>
        /// Returns true if TradeActionBody instances are equal
        /// </summary>
        /// <param name="input">Instance of TradeActionBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TradeActionBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Trade == input.Trade ||
                    (this.Trade != null &&
                    this.Trade.Equals(input.Trade))
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
                if (this.Trade != null)
                    hashCode = hashCode * 59 + this.Trade.GetHashCode();
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