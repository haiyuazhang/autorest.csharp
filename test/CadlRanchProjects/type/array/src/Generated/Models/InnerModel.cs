// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace _Type._Array.Models
{
    /// <summary> Array inner model. </summary>
    public partial class InnerModel
    {
        /// <summary> Initializes a new instance of <see cref="InnerModel"/>. </summary>
        /// <param name="property"> Required string property. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="property"/> is null. </exception>
        public InnerModel(string property)
        {
            Argument.AssertNotNull(property, nameof(property));

            Property = property;
            Children = new ChangeTrackingList<InnerModel>();
        }

        /// <summary> Initializes a new instance of <see cref="InnerModel"/>. </summary>
        /// <param name="property"> Required string property. </param>
        /// <param name="children"></param>
        internal InnerModel(string property, IList<InnerModel> children)
        {
            Property = property;
            Children = children;
        }

        /// <summary> Required string property. </summary>
        public string Property { get; set; }
        /// <summary> Gets the children. </summary>
        public IList<InnerModel> Children { get; }
    }
}
