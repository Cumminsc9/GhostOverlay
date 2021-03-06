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
    /// A hint for the UI as to what display information ought to be shown. Defaults to showing the static MilestoneDefinition&#39;s display properties.   If for some reason the indicated property is not populated, fall back to the MilestoneDefinition.displayProperties.
    /// </summary>
    /// <value>A hint for the UI as to what display information ought to be shown. Defaults to showing the static MilestoneDefinition&#39;s display properties.   If for some reason the indicated property is not populated, fall back to the MilestoneDefinition.displayProperties.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DestinyDefinitionsMilestonesDestinyMilestoneDisplayPreference
    {
        /// <summary>
        /// Enum NUMBER_0 for value: 0
        /// </summary>
        [EnumMember(Value = "0")]
        NUMBER_0 = 1,

        /// <summary>
        /// Enum NUMBER_1 for value: 1
        /// </summary>
        [EnumMember(Value = "1")]
        NUMBER_1 = 2,

        /// <summary>
        /// Enum NUMBER_2 for value: 2
        /// </summary>
        [EnumMember(Value = "2")]
        NUMBER_2 = 3

    }

}
