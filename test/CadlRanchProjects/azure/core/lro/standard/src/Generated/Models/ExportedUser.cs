// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace _Azure.Lro.Standard.Models
{
    /// <summary> The exported user data. </summary>
    public partial class ExportedUser
    {
        /// <summary> Initializes a new instance of <see cref="ExportedUser"/>. </summary>
        /// <param name="name"> The name of user. </param>
        /// <param name="resourceUri"> The exported URI. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="resourceUri"/> is null. </exception>
        internal ExportedUser(string name, string resourceUri)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));

            Name = name;
            ResourceUri = resourceUri;
        }

        /// <summary> The name of user. </summary>
        public string Name { get; }
        /// <summary> The exported URI. </summary>
        public string ResourceUri { get; }
    }
}
