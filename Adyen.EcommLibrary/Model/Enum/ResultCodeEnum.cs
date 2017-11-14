﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.EcommLibrary.Model.Enum
{
    /// <summary>
    /// The result of the payment.
    /// </summary>
    /// <value>The result of the payment.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResultCodeEnum
    {

        /// <summary>
        /// Enum Authorised for "Authorised"
        /// </summary>
        [EnumMember(Value = "Authorised")]
        Authorised,

        /// <summary>
        /// Enum PartiallyAuthorised for "PartiallyAuthorised"
        /// </summary>
        [EnumMember(Value = "PartiallyAuthorised")]
        PartiallyAuthorised,

        /// <summary>
        /// Enum Refused for "Refused"
        /// </summary>
        [EnumMember(Value = "Refused")]
        Refused,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error,

        /// <summary>
        /// Enum Cancelled for "Cancelled"
        /// </summary>
        [EnumMember(Value = "Cancelled")]
        Cancelled,

        /// <summary>
        /// Enum Received for "Received"
        /// </summary>
        [EnumMember(Value = "Received")]
        Received,

        /// <summary>
        /// Enum RedirectShopper for "RedirectShopper"
        /// </summary>
        [EnumMember(Value = "RedirectShopper")]
        RedirectShopper
    }
}