// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace paging.Models
{
    /// <summary> The ProductResultValue. </summary>
    internal partial class ProductResultValue
    {
        /// <summary> Initializes a new instance of <see cref="ProductResultValue"/>. </summary>
        internal ProductResultValue()
        {
            Value = new ChangeTrackingList<Product>();
        }

        /// <summary> Initializes a new instance of <see cref="ProductResultValue"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"></param>
        internal ProductResultValue(IReadOnlyList<Product> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<Product> Value { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
