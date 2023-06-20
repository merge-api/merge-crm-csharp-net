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
    /// * &#x60;BOOLEAN&#x60; - BOOLEAN * &#x60;DATE&#x60; - DATE * &#x60;DATE_TIME&#x60; - DATE_TIME * &#x60;INTEGER&#x60; - INTEGER * &#x60;FLOAT&#x60; - FLOAT * &#x60;STRING&#x60; - STRING * &#x60;LIST_OF_STRINGS&#x60; - LIST_OF_STRINGS
    /// </summary>
    /// <value>* &#x60;BOOLEAN&#x60; - BOOLEAN * &#x60;DATE&#x60; - DATE * &#x60;DATE_TIME&#x60; - DATE_TIME * &#x60;INTEGER&#x60; - INTEGER * &#x60;FLOAT&#x60; - FLOAT * &#x60;STRING&#x60; - STRING * &#x60;LIST_OF_STRINGS&#x60; - LIST_OF_STRINGS</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConditionTypeEnum
    {
        /// <summary>
        /// Enum BOOLEAN for value: BOOLEAN
        /// </summary>
        [EnumMember(Value = "BOOLEAN")]
        BOOLEAN = 1,

        /// <summary>
        /// Enum DATE for value: DATE
        /// </summary>
        [EnumMember(Value = "DATE")]
        DATE = 2,

        /// <summary>
        /// Enum DATETIME for value: DATE_TIME
        /// </summary>
        [EnumMember(Value = "DATE_TIME")]
        DATETIME = 3,

        /// <summary>
        /// Enum INTEGER for value: INTEGER
        /// </summary>
        [EnumMember(Value = "INTEGER")]
        INTEGER = 4,

        /// <summary>
        /// Enum FLOAT for value: FLOAT
        /// </summary>
        [EnumMember(Value = "FLOAT")]
        FLOAT = 5,

        /// <summary>
        /// Enum STRING for value: STRING
        /// </summary>
        [EnumMember(Value = "STRING")]
        STRING = 6,

        /// <summary>
        /// Enum LISTOFSTRINGS for value: LIST_OF_STRINGS
        /// </summary>
        [EnumMember(Value = "LIST_OF_STRINGS")]
        LISTOFSTRINGS = 7

    }

}
