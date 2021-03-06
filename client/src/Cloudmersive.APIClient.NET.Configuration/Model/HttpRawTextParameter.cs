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
    /// Raw text parameter that defines the entire body of the HTTP payload; cannot be used with other parameter types
    /// </summary>
    [DataContract]
    public partial class HttpRawTextParameter :  IEquatable<HttpRawTextParameter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpRawTextParameter" /> class.
        /// </summary>
        /// <param name="parameterValue">Text value of the parameter.</param>
        /// <param name="useOutputFromPreviousTask">Optional; use the output from a previous task as the input to this parameter.  Set to null (default) to ignore..</param>
        public HttpRawTextParameter(string parameterValue = default(string), TaskOutputReference useOutputFromPreviousTask = default(TaskOutputReference))
        {
            this.ParameterValue = parameterValue;
            this.UseOutputFromPreviousTask = useOutputFromPreviousTask;
        }
        
        /// <summary>
        /// Text value of the parameter
        /// </summary>
        /// <value>Text value of the parameter</value>
        [DataMember(Name="ParameterValue", EmitDefaultValue=false)]
        public string ParameterValue { get; set; }

        /// <summary>
        /// Optional; use the output from a previous task as the input to this parameter.  Set to null (default) to ignore.
        /// </summary>
        /// <value>Optional; use the output from a previous task as the input to this parameter.  Set to null (default) to ignore.</value>
        [DataMember(Name="UseOutputFromPreviousTask", EmitDefaultValue=false)]
        public TaskOutputReference UseOutputFromPreviousTask { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HttpRawTextParameter {\n");
            sb.Append("  ParameterValue: ").Append(ParameterValue).Append("\n");
            sb.Append("  UseOutputFromPreviousTask: ").Append(UseOutputFromPreviousTask).Append("\n");
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
            return this.Equals(input as HttpRawTextParameter);
        }

        /// <summary>
        /// Returns true if HttpRawTextParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of HttpRawTextParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HttpRawTextParameter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ParameterValue == input.ParameterValue ||
                    (this.ParameterValue != null &&
                    this.ParameterValue.Equals(input.ParameterValue))
                ) && 
                (
                    this.UseOutputFromPreviousTask == input.UseOutputFromPreviousTask ||
                    (this.UseOutputFromPreviousTask != null &&
                    this.UseOutputFromPreviousTask.Equals(input.UseOutputFromPreviousTask))
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
                if (this.ParameterValue != null)
                    hashCode = hashCode * 59 + this.ParameterValue.GetHashCode();
                if (this.UseOutputFromPreviousTask != null)
                    hashCode = hashCode * 59 + this.UseOutputFromPreviousTask.GetHashCode();
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
