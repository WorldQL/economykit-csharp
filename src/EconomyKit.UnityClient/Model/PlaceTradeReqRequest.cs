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
    /// PlaceTradeReqRequest
    /// </summary>
    [DataContract]
    public partial class PlaceTradeReqRequest :  IEquatable<PlaceTradeReqRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceTradeReqRequest" /> class.
        /// </summary>
        /// <param name="sender">sender.</param>
        /// <param name="recipient">recipient.</param>
        /// <param name="sentCommodities">sentCommodities.</param>
        /// <param name="sentUniqueItems">sentUniqueItems.</param>
        /// <param name="receivedCommodities">receivedCommodities.</param>
        /// <param name="receivedUniqueItems">receivedUniqueItems.</param>
        public PlaceTradeReqRequest(Guid sender = default(Guid), Guid recipient = default(Guid), List<CommodityEntry> sentCommodities = default(List<CommodityEntry>), List<Guid> sentUniqueItems = default(List<Guid>), List<CommodityEntry> receivedCommodities = default(List<CommodityEntry>), List<Guid> receivedUniqueItems = default(List<Guid>))
        {
            this.Sender = sender;
            this.Recipient = recipient;
            this.SentCommodities = sentCommodities;
            this.SentUniqueItems = sentUniqueItems;
            this.ReceivedCommodities = receivedCommodities;
            this.ReceivedUniqueItems = receivedUniqueItems;
        }

        /// <summary>
        /// Gets or Sets Sender
        /// </summary>
        [DataMember(Name="sender", EmitDefaultValue=false)]
        public Guid Sender { get; set; }

        /// <summary>
        /// Gets or Sets Recipient
        /// </summary>
        [DataMember(Name="recipient", EmitDefaultValue=false)]
        public Guid Recipient { get; set; }

        /// <summary>
        /// Gets or Sets SentCommodities
        /// </summary>
        [DataMember(Name="sent_commodities", EmitDefaultValue=false)]
        public List<CommodityEntry> SentCommodities { get; set; }

        /// <summary>
        /// Gets or Sets SentUniqueItems
        /// </summary>
        [DataMember(Name="sent_unique_items", EmitDefaultValue=false)]
        public List<Guid> SentUniqueItems { get; set; }

        /// <summary>
        /// Gets or Sets ReceivedCommodities
        /// </summary>
        [DataMember(Name="received_commodities", EmitDefaultValue=false)]
        public List<CommodityEntry> ReceivedCommodities { get; set; }

        /// <summary>
        /// Gets or Sets ReceivedUniqueItems
        /// </summary>
        [DataMember(Name="received_unique_items", EmitDefaultValue=false)]
        public List<Guid> ReceivedUniqueItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlaceTradeReqRequest {\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  SentCommodities: ").Append(SentCommodities).Append("\n");
            sb.Append("  SentUniqueItems: ").Append(SentUniqueItems).Append("\n");
            sb.Append("  ReceivedCommodities: ").Append(ReceivedCommodities).Append("\n");
            sb.Append("  ReceivedUniqueItems: ").Append(ReceivedUniqueItems).Append("\n");
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
            return this.Equals(input as PlaceTradeReqRequest);
        }

        /// <summary>
        /// Returns true if PlaceTradeReqRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PlaceTradeReqRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlaceTradeReqRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.Recipient == input.Recipient ||
                    (this.Recipient != null &&
                    this.Recipient.Equals(input.Recipient))
                ) && 
                (
                    this.SentCommodities == input.SentCommodities ||
                    this.SentCommodities != null &&
                    input.SentCommodities != null &&
                    this.SentCommodities.SequenceEqual(input.SentCommodities)
                ) && 
                (
                    this.SentUniqueItems == input.SentUniqueItems ||
                    this.SentUniqueItems != null &&
                    input.SentUniqueItems != null &&
                    this.SentUniqueItems.SequenceEqual(input.SentUniqueItems)
                ) && 
                (
                    this.ReceivedCommodities == input.ReceivedCommodities ||
                    this.ReceivedCommodities != null &&
                    input.ReceivedCommodities != null &&
                    this.ReceivedCommodities.SequenceEqual(input.ReceivedCommodities)
                ) && 
                (
                    this.ReceivedUniqueItems == input.ReceivedUniqueItems ||
                    this.ReceivedUniqueItems != null &&
                    input.ReceivedUniqueItems != null &&
                    this.ReceivedUniqueItems.SequenceEqual(input.ReceivedUniqueItems)
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
                if (this.Sender != null)
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                if (this.Recipient != null)
                    hashCode = hashCode * 59 + this.Recipient.GetHashCode();
                if (this.SentCommodities != null)
                    hashCode = hashCode * 59 + this.SentCommodities.GetHashCode();
                if (this.SentUniqueItems != null)
                    hashCode = hashCode * 59 + this.SentUniqueItems.GetHashCode();
                if (this.ReceivedCommodities != null)
                    hashCode = hashCode * 59 + this.ReceivedCommodities.GetHashCode();
                if (this.ReceivedUniqueItems != null)
                    hashCode = hashCode * 59 + this.ReceivedUniqueItems.GetHashCode();
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
