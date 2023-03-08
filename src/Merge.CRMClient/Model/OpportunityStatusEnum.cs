/*
 * Merge CRM API
 *
 * The unified API for building rich integrations with multiple CRM platforms.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: hello@merge.dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Merge.CRMClient.Client.OpenAPIDateConverter;

namespace Merge.CRMClient.Model
{
    /// <summary>
    /// Defines OpportunityStatusEnum
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OpportunityStatusEnum
    {
        /// <summary>
        /// Enum OPEN for value: OPEN
        /// </summary>
        [EnumMember(Value = "OPEN")]
        OPEN = 1,

        /// <summary>
        /// Enum WON for value: WON
        /// </summary>
        [EnumMember(Value = "WON")]
        WON = 2,

        /// <summary>
        /// Enum LOST for value: LOST
        /// </summary>
        [EnumMember(Value = "LOST")]
        LOST = 3

    }

}
