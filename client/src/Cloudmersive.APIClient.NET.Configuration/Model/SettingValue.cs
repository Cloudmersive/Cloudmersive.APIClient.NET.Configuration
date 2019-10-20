/* 
 * configapi
 *
 * Config API lets you easily manage configuration at scale.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = Cloudmersive.APIClient.NET.Configuration.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NET.Configuration.Model
{
    /// <summary>
    /// SettingValue
    /// </summary>
    [DataContract]
    public partial class SettingValue :  IEquatable<SettingValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingValue" /> class.
        /// </summary>
        /// <param name="configSettingValueID">configSettingValueID.</param>
        /// <param name="configSettingDefinitionID">configSettingDefinitionID.</param>
        /// <param name="configSettingValue">configSettingValue.</param>
        /// <param name="configSettingLastModified">configSettingLastModified.</param>
        /// <param name="configSettingName">configSettingName.</param>
        /// <param name="configSettingType">configSettingType.</param>
        public SettingValue(string configSettingValueID = default(string), string configSettingDefinitionID = default(string), Object configSettingValue = default(Object), DateTime? configSettingLastModified = default(DateTime?), string configSettingName = default(string), string configSettingType = default(string))
        {
            this.ConfigSettingValueID = configSettingValueID;
            this.ConfigSettingDefinitionID = configSettingDefinitionID;
            this.ConfigSettingValue = configSettingValue;
            this.ConfigSettingLastModified = configSettingLastModified;
            this.ConfigSettingName = configSettingName;
            this.ConfigSettingType = configSettingType;
        }
        
        /// <summary>
        /// Gets or Sets ConfigSettingValueID
        /// </summary>
        [DataMember(Name="ConfigSettingValueID", EmitDefaultValue=false)]
        public string ConfigSettingValueID { get; set; }

        /// <summary>
        /// Gets or Sets ConfigSettingDefinitionID
        /// </summary>
        [DataMember(Name="ConfigSettingDefinitionID", EmitDefaultValue=false)]
        public string ConfigSettingDefinitionID { get; set; }

        /// <summary>
        /// Gets or Sets ConfigSettingValue
        /// </summary>
        [DataMember(Name="ConfigSettingValue", EmitDefaultValue=false)]
        public Object ConfigSettingValue { get; set; }

        /// <summary>
        /// Gets or Sets ConfigSettingLastModified
        /// </summary>
        [DataMember(Name="ConfigSettingLastModified", EmitDefaultValue=false)]
        public DateTime? ConfigSettingLastModified { get; set; }

        /// <summary>
        /// Gets or Sets ConfigSettingName
        /// </summary>
        [DataMember(Name="ConfigSettingName", EmitDefaultValue=false)]
        public string ConfigSettingName { get; set; }

        /// <summary>
        /// Gets or Sets ConfigSettingType
        /// </summary>
        [DataMember(Name="ConfigSettingType", EmitDefaultValue=false)]
        public string ConfigSettingType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SettingValue {\n");
            sb.Append("  ConfigSettingValueID: ").Append(ConfigSettingValueID).Append("\n");
            sb.Append("  ConfigSettingDefinitionID: ").Append(ConfigSettingDefinitionID).Append("\n");
            sb.Append("  ConfigSettingValue: ").Append(ConfigSettingValue).Append("\n");
            sb.Append("  ConfigSettingLastModified: ").Append(ConfigSettingLastModified).Append("\n");
            sb.Append("  ConfigSettingName: ").Append(ConfigSettingName).Append("\n");
            sb.Append("  ConfigSettingType: ").Append(ConfigSettingType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SettingValue);
        }

        /// <summary>
        /// Returns true if SettingValue instances are equal
        /// </summary>
        /// <param name="input">Instance of SettingValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettingValue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConfigSettingValueID == input.ConfigSettingValueID ||
                    (this.ConfigSettingValueID != null &&
                    this.ConfigSettingValueID.Equals(input.ConfigSettingValueID))
                ) && 
                (
                    this.ConfigSettingDefinitionID == input.ConfigSettingDefinitionID ||
                    (this.ConfigSettingDefinitionID != null &&
                    this.ConfigSettingDefinitionID.Equals(input.ConfigSettingDefinitionID))
                ) && 
                (
                    this.ConfigSettingValue == input.ConfigSettingValue ||
                    (this.ConfigSettingValue != null &&
                    this.ConfigSettingValue.Equals(input.ConfigSettingValue))
                ) && 
                (
                    this.ConfigSettingLastModified == input.ConfigSettingLastModified ||
                    (this.ConfigSettingLastModified != null &&
                    this.ConfigSettingLastModified.Equals(input.ConfigSettingLastModified))
                ) && 
                (
                    this.ConfigSettingName == input.ConfigSettingName ||
                    (this.ConfigSettingName != null &&
                    this.ConfigSettingName.Equals(input.ConfigSettingName))
                ) && 
                (
                    this.ConfigSettingType == input.ConfigSettingType ||
                    (this.ConfigSettingType != null &&
                    this.ConfigSettingType.Equals(input.ConfigSettingType))
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
                if (this.ConfigSettingValueID != null)
                    hashCode = hashCode * 59 + this.ConfigSettingValueID.GetHashCode();
                if (this.ConfigSettingDefinitionID != null)
                    hashCode = hashCode * 59 + this.ConfigSettingDefinitionID.GetHashCode();
                if (this.ConfigSettingValue != null)
                    hashCode = hashCode * 59 + this.ConfigSettingValue.GetHashCode();
                if (this.ConfigSettingLastModified != null)
                    hashCode = hashCode * 59 + this.ConfigSettingLastModified.GetHashCode();
                if (this.ConfigSettingName != null)
                    hashCode = hashCode * 59 + this.ConfigSettingName.GetHashCode();
                if (this.ConfigSettingType != null)
                    hashCode = hashCode * 59 + this.ConfigSettingType.GetHashCode();
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
