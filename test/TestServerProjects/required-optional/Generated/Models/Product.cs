// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace required_optional.Models
{
    /// <summary> The Product. </summary>
    public partial class Product
    {
        /// <summary> Initializes a new instance of Product. </summary>
        /// <param name="id"> . </param>
        public Product(int id)
        {
            Id = id;
        }

        public int Id { get; }
        public string Name { get; set; }
    }
}
