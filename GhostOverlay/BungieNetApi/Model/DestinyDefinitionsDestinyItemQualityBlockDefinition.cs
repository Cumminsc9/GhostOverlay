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
    /// An item&#39;s \&quot;Quality\&quot; determines its calculated stats. The Level at which the item spawns is combined with its \&quot;qualityLevel\&quot; along with some additional calculations to determine the value of those stats.  In Destiny 2, most items don&#39;t have default item levels and quality, making this property less useful: these apparently are almost always determined by the complex mechanisms of the Reward system rather than statically. They are still provided here in case they are still useful for people. This also contains some information about Infusion.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyItemQualityBlockDefinition :  IEquatable<DestinyDefinitionsDestinyItemQualityBlockDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyItemQualityBlockDefinition" /> class.
        /// </summary>
        /// <param name="itemLevels">The \&quot;base\&quot; defined level of an item. This is a list because, in theory, each Expansion could define its own base level for an item.  In practice, not only was that never done in Destiny 1, but now this isn&#39;t even populated at all. When it&#39;s not populated, the level at which it spawns has to be inferred by Reward information, of which BNet receives an imperfect view and will only be reliable on instanced data as a result..</param>
        /// <param name="qualityLevel">qualityLevel is used in combination with the item&#39;s level to calculate stats like Attack and Defense. It plays a role in that calculation, but not nearly as large as itemLevel does..</param>
        /// <param name="infusionCategoryName">The string identifier for this item&#39;s \&quot;infusability\&quot;, if any.   Items that match the same infusionCategoryName are allowed to infuse with each other.  DEPRECATED: Items can now have multiple infusion categories. Please use infusionCategoryHashes instead..</param>
        /// <param name="infusionCategoryHash">The hash identifier for the infusion. It does not map to a Definition entity.  DEPRECATED: Items can now have multiple infusion categories. Please use infusionCategoryHashes instead..</param>
        /// <param name="infusionCategoryHashes">If any one of these hashes matches any value in another item&#39;s infusionCategoryHashes, the two can infuse with each other..</param>
        /// <param name="progressionLevelRequirementHash">An item can refer to pre-set level requirements. They are defined in DestinyProgressionLevelRequirementDefinition, and you can use this hash to find the appropriate definition..</param>
        public DestinyDefinitionsDestinyItemQualityBlockDefinition(List<int> itemLevels = default(List<int>), int qualityLevel = default(int), string infusionCategoryName = default(string), long infusionCategoryHash = default(long), List<long> infusionCategoryHashes = default(List<long>), long progressionLevelRequirementHash = default(long))
        {
            this.ItemLevels = itemLevels;
            this.QualityLevel = qualityLevel;
            this.InfusionCategoryName = infusionCategoryName;
            this.InfusionCategoryHash = infusionCategoryHash;
            this.InfusionCategoryHashes = infusionCategoryHashes;
            this.ProgressionLevelRequirementHash = progressionLevelRequirementHash;
        }
        
        /// <summary>
        /// The \&quot;base\&quot; defined level of an item. This is a list because, in theory, each Expansion could define its own base level for an item.  In practice, not only was that never done in Destiny 1, but now this isn&#39;t even populated at all. When it&#39;s not populated, the level at which it spawns has to be inferred by Reward information, of which BNet receives an imperfect view and will only be reliable on instanced data as a result.
        /// </summary>
        /// <value>The \&quot;base\&quot; defined level of an item. This is a list because, in theory, each Expansion could define its own base level for an item.  In practice, not only was that never done in Destiny 1, but now this isn&#39;t even populated at all. When it&#39;s not populated, the level at which it spawns has to be inferred by Reward information, of which BNet receives an imperfect view and will only be reliable on instanced data as a result.</value>
        [DataMember(Name="itemLevels", EmitDefaultValue=false)]
        public List<int> ItemLevels { get; set; }

        /// <summary>
        /// qualityLevel is used in combination with the item&#39;s level to calculate stats like Attack and Defense. It plays a role in that calculation, but not nearly as large as itemLevel does.
        /// </summary>
        /// <value>qualityLevel is used in combination with the item&#39;s level to calculate stats like Attack and Defense. It plays a role in that calculation, but not nearly as large as itemLevel does.</value>
        [DataMember(Name="qualityLevel", EmitDefaultValue=false)]
        public int QualityLevel { get; set; }

        /// <summary>
        /// The string identifier for this item&#39;s \&quot;infusability\&quot;, if any.   Items that match the same infusionCategoryName are allowed to infuse with each other.  DEPRECATED: Items can now have multiple infusion categories. Please use infusionCategoryHashes instead.
        /// </summary>
        /// <value>The string identifier for this item&#39;s \&quot;infusability\&quot;, if any.   Items that match the same infusionCategoryName are allowed to infuse with each other.  DEPRECATED: Items can now have multiple infusion categories. Please use infusionCategoryHashes instead.</value>
        [DataMember(Name="infusionCategoryName", EmitDefaultValue=false)]
        public string InfusionCategoryName { get; set; }

        /// <summary>
        /// The hash identifier for the infusion. It does not map to a Definition entity.  DEPRECATED: Items can now have multiple infusion categories. Please use infusionCategoryHashes instead.
        /// </summary>
        /// <value>The hash identifier for the infusion. It does not map to a Definition entity.  DEPRECATED: Items can now have multiple infusion categories. Please use infusionCategoryHashes instead.</value>
        [DataMember(Name="infusionCategoryHash", EmitDefaultValue=false)]
        public long InfusionCategoryHash { get; set; }

        /// <summary>
        /// If any one of these hashes matches any value in another item&#39;s infusionCategoryHashes, the two can infuse with each other.
        /// </summary>
        /// <value>If any one of these hashes matches any value in another item&#39;s infusionCategoryHashes, the two can infuse with each other.</value>
        [DataMember(Name="infusionCategoryHashes", EmitDefaultValue=false)]
        public List<long> InfusionCategoryHashes { get; set; }

        /// <summary>
        /// An item can refer to pre-set level requirements. They are defined in DestinyProgressionLevelRequirementDefinition, and you can use this hash to find the appropriate definition.
        /// </summary>
        /// <value>An item can refer to pre-set level requirements. They are defined in DestinyProgressionLevelRequirementDefinition, and you can use this hash to find the appropriate definition.</value>
        [DataMember(Name="progressionLevelRequirementHash", EmitDefaultValue=false)]
        public long ProgressionLevelRequirementHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyItemQualityBlockDefinition {\n");
            sb.Append("  ItemLevels: ").Append(ItemLevels).Append("\n");
            sb.Append("  QualityLevel: ").Append(QualityLevel).Append("\n");
            sb.Append("  InfusionCategoryName: ").Append(InfusionCategoryName).Append("\n");
            sb.Append("  InfusionCategoryHash: ").Append(InfusionCategoryHash).Append("\n");
            sb.Append("  InfusionCategoryHashes: ").Append(InfusionCategoryHashes).Append("\n");
            sb.Append("  ProgressionLevelRequirementHash: ").Append(ProgressionLevelRequirementHash).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyItemQualityBlockDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyItemQualityBlockDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyItemQualityBlockDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyItemQualityBlockDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ItemLevels == input.ItemLevels ||
                    this.ItemLevels != null &&
                    input.ItemLevels != null &&
                    this.ItemLevels.SequenceEqual(input.ItemLevels)
                ) && 
                (
                    this.QualityLevel == input.QualityLevel ||
                    this.QualityLevel.Equals(input.QualityLevel)
                ) && 
                (
                    this.InfusionCategoryName == input.InfusionCategoryName ||
                    (this.InfusionCategoryName != null &&
                    this.InfusionCategoryName.Equals(input.InfusionCategoryName))
                ) && 
                (
                    this.InfusionCategoryHash == input.InfusionCategoryHash ||
                    this.InfusionCategoryHash.Equals(input.InfusionCategoryHash)
                ) && 
                (
                    this.InfusionCategoryHashes == input.InfusionCategoryHashes ||
                    this.InfusionCategoryHashes != null &&
                    input.InfusionCategoryHashes != null &&
                    this.InfusionCategoryHashes.SequenceEqual(input.InfusionCategoryHashes)
                ) && 
                (
                    this.ProgressionLevelRequirementHash == input.ProgressionLevelRequirementHash ||
                    this.ProgressionLevelRequirementHash.Equals(input.ProgressionLevelRequirementHash)
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
                if (this.ItemLevels != null)
                    hashCode = hashCode * 59 + this.ItemLevels.GetHashCode();
                hashCode = hashCode * 59 + this.QualityLevel.GetHashCode();
                if (this.InfusionCategoryName != null)
                    hashCode = hashCode * 59 + this.InfusionCategoryName.GetHashCode();
                hashCode = hashCode * 59 + this.InfusionCategoryHash.GetHashCode();
                if (this.InfusionCategoryHashes != null)
                    hashCode = hashCode * 59 + this.InfusionCategoryHashes.GetHashCode();
                hashCode = hashCode * 59 + this.ProgressionLevelRequirementHash.GetHashCode();
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
