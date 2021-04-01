// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sample
{
    /// <summary> Specifies the Security profile settings for the virtual machine or virtual machine scale set. </summary>
    public partial class SecurityProfile
    {
        /// <summary> Initializes a new instance of SecurityProfile. </summary>
        public SecurityProfile()
        {
        }

        /// <summary> Initializes a new instance of SecurityProfile. </summary>
        /// <param name="encryptionAtHost"> This property can be used by user in the request to enable or disable the Host Encryption for the virtual machine or virtual machine scale set. This will enable the encryption for all the disks including Resource/Temp disk at host itself. &lt;br&gt;&lt;br&gt; Default: The Encryption at host will be disabled unless this property is set to true for the resource. </param>
        internal SecurityProfile(bool? encryptionAtHost)
        {
            EncryptionAtHost = encryptionAtHost;
        }

        /// <summary> This property can be used by user in the request to enable or disable the Host Encryption for the virtual machine or virtual machine scale set. This will enable the encryption for all the disks including Resource/Temp disk at host itself. &lt;br&gt;&lt;br&gt; Default: The Encryption at host will be disabled unless this property is set to true for the resource. </summary>
        public bool? EncryptionAtHost { get; set; }
    }
}
