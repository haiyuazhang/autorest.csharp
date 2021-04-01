// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sample
{
    public partial class VirtualMachineScaleSetManagedDiskParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StorageAccountType))
            {
                writer.WritePropertyName("storageAccountType");
                writer.WriteStringValue(StorageAccountType.Value.ToString());
            }
            if (Optional.IsDefined(DiskEncryptionSet))
            {
                writer.WritePropertyName("diskEncryptionSet");
                writer.WriteObjectValue(DiskEncryptionSet);
            }
            writer.WriteEndObject();
        }

        internal static VirtualMachineScaleSetManagedDiskParameters DeserializeVirtualMachineScaleSetManagedDiskParameters(JsonElement element)
        {
            Optional<StorageAccountTypes> storageAccountType = default;
            Optional<DiskEncryptionSetParameters> diskEncryptionSet = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageAccountType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    storageAccountType = new StorageAccountTypes(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diskEncryptionSet"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    diskEncryptionSet = DiskEncryptionSetParameters.DeserializeDiskEncryptionSetParameters(property.Value);
                    continue;
                }
            }
            return new VirtualMachineScaleSetManagedDiskParameters(Optional.ToNullable(storageAccountType), diskEncryptionSet.Value);
        }
    }
}
