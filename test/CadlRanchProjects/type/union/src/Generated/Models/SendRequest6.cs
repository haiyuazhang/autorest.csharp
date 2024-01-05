// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace _Type.Union.Models
{
    /// <summary> The SendRequest6. </summary>
    internal partial class SendRequest6
    {
        /// <summary> Initializes a new instance of <see cref="SendRequest6"/>. </summary>
        /// <param name="prop"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="prop"/> is null. </exception>
        public SendRequest6(EnumsOnlyCases prop)
        {
            Argument.AssertNotNull(prop, nameof(prop));

            Prop = prop;
        }

        /// <summary> Gets the prop. </summary>
        public EnumsOnlyCases Prop { get; }
    }
}
