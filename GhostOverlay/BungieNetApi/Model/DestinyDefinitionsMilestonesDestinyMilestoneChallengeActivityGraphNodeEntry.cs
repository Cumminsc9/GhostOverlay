/* 
 * Bungie.Net API
 *
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * The version of the OpenAPI document: 2.8.0
 * Contact: support@bungie.com
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
using OpenAPIDateConverter = BungieNetApi.Client.OpenAPIDateConverter;

namespace BungieNetApi.Model
{
    /// <summary>
    /// DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry :  IEquatable<DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry" /> class.
        /// </summary>
        /// <param name="activityGraphHash">activityGraphHash.</param>
        /// <param name="activityGraphNodeHash">activityGraphNodeHash.</param>
        public DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry(long activityGraphHash = default(long), long activityGraphNodeHash = default(long))
        {
            this.ActivityGraphHash = activityGraphHash;
            this.ActivityGraphNodeHash = activityGraphNodeHash;
        }
        
        /// <summary>
        /// Gets or Sets ActivityGraphHash
        /// </summary>
        [DataMember(Name="activityGraphHash", EmitDefaultValue=false)]
        public long ActivityGraphHash { get; set; }

        /// <summary>
        /// Gets or Sets ActivityGraphNodeHash
        /// </summary>
        [DataMember(Name="activityGraphNodeHash", EmitDefaultValue=false)]
        public long ActivityGraphNodeHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry {\n");
            sb.Append("  ActivityGraphHash: ").Append(ActivityGraphHash).Append("\n");
            sb.Append("  ActivityGraphNodeHash: ").Append(ActivityGraphNodeHash).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActivityGraphHash == input.ActivityGraphHash ||
                    this.ActivityGraphHash.Equals(input.ActivityGraphHash)
                ) && 
                (
                    this.ActivityGraphNodeHash == input.ActivityGraphNodeHash ||
                    this.ActivityGraphNodeHash.Equals(input.ActivityGraphNodeHash)
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
                hashCode = hashCode * 59 + this.ActivityGraphHash.GetHashCode();
                hashCode = hashCode * 59 + this.ActivityGraphNodeHash.GetHashCode();
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
