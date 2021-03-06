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
    /// The most essential summary information about a Profile (in Destiny 1, we called these \&quot;Accounts\&quot;).
    /// </summary>
    [DataContract]
    public partial class DestinyEntitiesProfilesDestinyProfileComponent :  IEquatable<DestinyEntitiesProfilesDestinyProfileComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyEntitiesProfilesDestinyProfileComponent" /> class.
        /// </summary>
        /// <param name="userInfo">If you need to render the Profile (their platform name, icon, etc...) somewhere, this property contains that information..</param>
        /// <param name="dateLastPlayed">The last time the user played with any character on this Profile..</param>
        /// <param name="versionsOwned">If you want to know what expansions they own, this will contain that data.   IMPORTANT: This field may not return the data you&#39;re interested in for Cross-Saved users. It returns the last ownership data we saw for this account - which is to say, what they&#39;ve purchased on the platform on which they last played, which now could be a different platform.   If you don&#39;t care about per-platform ownership and only care about whatever platform it seems they are playing on most recently, then this should be \&quot;good enough.\&quot; Otherwise, this should be considered deprecated. We do not have a good alternative to provide at this time with platform specific ownership data for DLC..</param>
        /// <param name="characterIds">A list of the character IDs, for further querying on your part..</param>
        /// <param name="seasonHashes">A list of seasons that this profile owns. Unlike versionsOwned, these stay with the profile across Platforms, and thus will be valid.   It turns out that Stadia Pro subscriptions will give access to seasons but only while playing on Stadia and with an active subscription. So some users (users who have Stadia Pro but choose to play on some other platform) won&#39;t see these as available: it will be whatever seasons are available for the platform on which they last played..</param>
        /// <param name="currentSeasonHash">If populated, this is a reference to the season that is currently active..</param>
        public DestinyEntitiesProfilesDestinyProfileComponent(UserUserInfoCard userInfo = default(UserUserInfoCard), DateTime dateLastPlayed = default(DateTime), int versionsOwned = default(int), List<long> characterIds = default(List<long>), List<long> seasonHashes = default(List<long>), long currentSeasonHash = default(long))
        {
            this.UserInfo = userInfo;
            this.DateLastPlayed = dateLastPlayed;
            this.VersionsOwned = versionsOwned;
            this.CharacterIds = characterIds;
            this.SeasonHashes = seasonHashes;
            this.CurrentSeasonHash = currentSeasonHash;
        }
        
        /// <summary>
        /// If you need to render the Profile (their platform name, icon, etc...) somewhere, this property contains that information.
        /// </summary>
        /// <value>If you need to render the Profile (their platform name, icon, etc...) somewhere, this property contains that information.</value>
        [DataMember(Name="userInfo", EmitDefaultValue=false)]
        public UserUserInfoCard UserInfo { get; set; }

        /// <summary>
        /// The last time the user played with any character on this Profile.
        /// </summary>
        /// <value>The last time the user played with any character on this Profile.</value>
        [DataMember(Name="dateLastPlayed", EmitDefaultValue=false)]
        public DateTime DateLastPlayed { get; set; }

        /// <summary>
        /// If you want to know what expansions they own, this will contain that data.   IMPORTANT: This field may not return the data you&#39;re interested in for Cross-Saved users. It returns the last ownership data we saw for this account - which is to say, what they&#39;ve purchased on the platform on which they last played, which now could be a different platform.   If you don&#39;t care about per-platform ownership and only care about whatever platform it seems they are playing on most recently, then this should be \&quot;good enough.\&quot; Otherwise, this should be considered deprecated. We do not have a good alternative to provide at this time with platform specific ownership data for DLC.
        /// </summary>
        /// <value>If you want to know what expansions they own, this will contain that data.   IMPORTANT: This field may not return the data you&#39;re interested in for Cross-Saved users. It returns the last ownership data we saw for this account - which is to say, what they&#39;ve purchased on the platform on which they last played, which now could be a different platform.   If you don&#39;t care about per-platform ownership and only care about whatever platform it seems they are playing on most recently, then this should be \&quot;good enough.\&quot; Otherwise, this should be considered deprecated. We do not have a good alternative to provide at this time with platform specific ownership data for DLC.</value>
        [DataMember(Name="versionsOwned", EmitDefaultValue=false)]
        public int VersionsOwned { get; set; }

        /// <summary>
        /// A list of the character IDs, for further querying on your part.
        /// </summary>
        /// <value>A list of the character IDs, for further querying on your part.</value>
        [DataMember(Name="characterIds", EmitDefaultValue=false)]
        public List<long> CharacterIds { get; set; }

        /// <summary>
        /// A list of seasons that this profile owns. Unlike versionsOwned, these stay with the profile across Platforms, and thus will be valid.   It turns out that Stadia Pro subscriptions will give access to seasons but only while playing on Stadia and with an active subscription. So some users (users who have Stadia Pro but choose to play on some other platform) won&#39;t see these as available: it will be whatever seasons are available for the platform on which they last played.
        /// </summary>
        /// <value>A list of seasons that this profile owns. Unlike versionsOwned, these stay with the profile across Platforms, and thus will be valid.   It turns out that Stadia Pro subscriptions will give access to seasons but only while playing on Stadia and with an active subscription. So some users (users who have Stadia Pro but choose to play on some other platform) won&#39;t see these as available: it will be whatever seasons are available for the platform on which they last played.</value>
        [DataMember(Name="seasonHashes", EmitDefaultValue=false)]
        public List<long> SeasonHashes { get; set; }

        /// <summary>
        /// If populated, this is a reference to the season that is currently active.
        /// </summary>
        /// <value>If populated, this is a reference to the season that is currently active.</value>
        [DataMember(Name="currentSeasonHash", EmitDefaultValue=false)]
        public long CurrentSeasonHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyEntitiesProfilesDestinyProfileComponent {\n");
            sb.Append("  UserInfo: ").Append(UserInfo).Append("\n");
            sb.Append("  DateLastPlayed: ").Append(DateLastPlayed).Append("\n");
            sb.Append("  VersionsOwned: ").Append(VersionsOwned).Append("\n");
            sb.Append("  CharacterIds: ").Append(CharacterIds).Append("\n");
            sb.Append("  SeasonHashes: ").Append(SeasonHashes).Append("\n");
            sb.Append("  CurrentSeasonHash: ").Append(CurrentSeasonHash).Append("\n");
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
            return this.Equals(input as DestinyEntitiesProfilesDestinyProfileComponent);
        }

        /// <summary>
        /// Returns true if DestinyEntitiesProfilesDestinyProfileComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyEntitiesProfilesDestinyProfileComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyEntitiesProfilesDestinyProfileComponent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserInfo == input.UserInfo ||
                    (this.UserInfo != null &&
                    this.UserInfo.Equals(input.UserInfo))
                ) && 
                (
                    this.DateLastPlayed == input.DateLastPlayed ||
                    (this.DateLastPlayed != null &&
                    this.DateLastPlayed.Equals(input.DateLastPlayed))
                ) && 
                (
                    this.VersionsOwned == input.VersionsOwned ||
                    this.VersionsOwned.Equals(input.VersionsOwned)
                ) && 
                (
                    this.CharacterIds == input.CharacterIds ||
                    this.CharacterIds != null &&
                    input.CharacterIds != null &&
                    this.CharacterIds.SequenceEqual(input.CharacterIds)
                ) && 
                (
                    this.SeasonHashes == input.SeasonHashes ||
                    this.SeasonHashes != null &&
                    input.SeasonHashes != null &&
                    this.SeasonHashes.SequenceEqual(input.SeasonHashes)
                ) && 
                (
                    this.CurrentSeasonHash == input.CurrentSeasonHash ||
                    this.CurrentSeasonHash.Equals(input.CurrentSeasonHash)
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
                if (this.UserInfo != null)
                    hashCode = hashCode * 59 + this.UserInfo.GetHashCode();
                if (this.DateLastPlayed != null)
                    hashCode = hashCode * 59 + this.DateLastPlayed.GetHashCode();
                hashCode = hashCode * 59 + this.VersionsOwned.GetHashCode();
                if (this.CharacterIds != null)
                    hashCode = hashCode * 59 + this.CharacterIds.GetHashCode();
                if (this.SeasonHashes != null)
                    hashCode = hashCode * 59 + this.SeasonHashes.GetHashCode();
                hashCode = hashCode * 59 + this.CurrentSeasonHash.GetHashCode();
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
