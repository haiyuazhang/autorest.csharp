// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace TenantOnly
{
    /// <summary> A class representing the AvailableBalance data model. </summary>
    public partial class AvailableBalanceData : Azure.ResourceManager.Core.Resource
    {
        /// <summary> Initializes a new instance of AvailableBalanceData. </summary>
        public AvailableBalanceData()
        {
        }

        /// <summary> Initializes a new instance of AvailableBalanceData. </summary>
        /// <param name="amount"> Balance amount. </param>
        internal AvailableBalanceData(Amount amount)
        {
            Amount = amount;
        }

        /// <summary> Balance amount. </summary>
        public Amount Amount { get; }
    }
}
