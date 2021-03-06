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
    /// Returns the detailed information about a Collectible Presentation Node and any Collectibles that are direct descendants.
    /// </summary>
    [DataContract]
    public partial class DestinyResponsesDestinyCollectibleNodeDetailResponse :  IEquatable<DestinyResponsesDestinyCollectibleNodeDetailResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyResponsesDestinyCollectibleNodeDetailResponse" /> class.
        /// </summary>
        /// <param name="collectibles">COMPONENT TYPE: Collectibles.</param>
        /// <param name="collectibleItemComponents">Item components, keyed by the item hash of the items pointed at collectibles found under the requested Presentation Node.  NOTE: I had a lot of hemming and hawing about whether these should be keyed by collectible hash or item hash... but ultimately having it be keyed by item hash meant that UI that already uses DestinyItemComponentSet data wouldn&#39;t have to have a special override to do the collectible -&gt; item lookup once you delve into an item&#39;s details, and it also meant that you didn&#39;t have to remember that the Hash being used as the key for plugSets was different from the Hash being used for the other Dictionaries. As a result, using the Item Hash felt like the least crappy solution.  We may all come to regret this decision. We will see.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.].</param>
        public DestinyResponsesDestinyCollectibleNodeDetailResponse(SingleComponentResponseOfDestinyCollectiblesComponent collectibles = default(SingleComponentResponseOfDestinyCollectiblesComponent), DestinyItemComponentSetOfuint32 collectibleItemComponents = default(DestinyItemComponentSetOfuint32))
        {
            this.Collectibles = collectibles;
            this.CollectibleItemComponents = collectibleItemComponents;
        }
        
        /// <summary>
        /// COMPONENT TYPE: Collectibles
        /// </summary>
        /// <value>COMPONENT TYPE: Collectibles</value>
        [DataMember(Name="collectibles", EmitDefaultValue=false)]
        public SingleComponentResponseOfDestinyCollectiblesComponent Collectibles { get; set; }

        /// <summary>
        /// Item components, keyed by the item hash of the items pointed at collectibles found under the requested Presentation Node.  NOTE: I had a lot of hemming and hawing about whether these should be keyed by collectible hash or item hash... but ultimately having it be keyed by item hash meant that UI that already uses DestinyItemComponentSet data wouldn&#39;t have to have a special override to do the collectible -&gt; item lookup once you delve into an item&#39;s details, and it also meant that you didn&#39;t have to remember that the Hash being used as the key for plugSets was different from the Hash being used for the other Dictionaries. As a result, using the Item Hash felt like the least crappy solution.  We may all come to regret this decision. We will see.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]
        /// </summary>
        /// <value>Item components, keyed by the item hash of the items pointed at collectibles found under the requested Presentation Node.  NOTE: I had a lot of hemming and hawing about whether these should be keyed by collectible hash or item hash... but ultimately having it be keyed by item hash meant that UI that already uses DestinyItemComponentSet data wouldn&#39;t have to have a special override to do the collectible -&gt; item lookup once you delve into an item&#39;s details, and it also meant that you didn&#39;t have to remember that the Hash being used as the key for plugSets was different from the Hash being used for the other Dictionaries. As a result, using the Item Hash felt like the least crappy solution.  We may all come to regret this decision. We will see.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]</value>
        [DataMember(Name="collectibleItemComponents", EmitDefaultValue=false)]
        public DestinyItemComponentSetOfuint32 CollectibleItemComponents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyResponsesDestinyCollectibleNodeDetailResponse {\n");
            sb.Append("  Collectibles: ").Append(Collectibles).Append("\n");
            sb.Append("  CollectibleItemComponents: ").Append(CollectibleItemComponents).Append("\n");
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
            return this.Equals(input as DestinyResponsesDestinyCollectibleNodeDetailResponse);
        }

        /// <summary>
        /// Returns true if DestinyResponsesDestinyCollectibleNodeDetailResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyResponsesDestinyCollectibleNodeDetailResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyResponsesDestinyCollectibleNodeDetailResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Collectibles == input.Collectibles ||
                    (this.Collectibles != null &&
                    this.Collectibles.Equals(input.Collectibles))
                ) && 
                (
                    this.CollectibleItemComponents == input.CollectibleItemComponents ||
                    (this.CollectibleItemComponents != null &&
                    this.CollectibleItemComponents.Equals(input.CollectibleItemComponents))
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
                if (this.Collectibles != null)
                    hashCode = hashCode * 59 + this.Collectibles.GetHashCode();
                if (this.CollectibleItemComponents != null)
                    hashCode = hashCode * 59 + this.CollectibleItemComponents.GetHashCode();
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
