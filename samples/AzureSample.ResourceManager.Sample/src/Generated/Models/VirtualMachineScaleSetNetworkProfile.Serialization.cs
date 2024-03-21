// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources.Models;

namespace AzureSample.ResourceManager.Sample.Models
{
    public partial class VirtualMachineScaleSetNetworkProfile : IUtf8JsonSerializable, IJsonModel<VirtualMachineScaleSetNetworkProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineScaleSetNetworkProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineScaleSetNetworkProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetNetworkProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(HealthProbe))
            {
                writer.WritePropertyName("healthProbe"u8);
                JsonSerializer.Serialize(writer, HealthProbe);
            }
            if (Optional.IsCollectionDefined(NetworkInterfaceConfigurations))
            {
                writer.WritePropertyName("networkInterfaceConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkInterfaceConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        VirtualMachineScaleSetNetworkProfile IJsonModel<VirtualMachineScaleSetNetworkProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetNetworkProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineScaleSetNetworkProfile(document.RootElement, options);
        }

        internal static VirtualMachineScaleSetNetworkProfile DeserializeVirtualMachineScaleSetNetworkProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WritableSubResource healthProbe = default;
            IList<VirtualMachineScaleSetNetworkConfiguration> networkInterfaceConfigurations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("healthProbe"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    healthProbe = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("networkInterfaceConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VirtualMachineScaleSetNetworkConfiguration> array = new List<VirtualMachineScaleSetNetworkConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualMachineScaleSetNetworkConfiguration.DeserializeVirtualMachineScaleSetNetworkConfiguration(item, options));
                    }
                    networkInterfaceConfigurations = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineScaleSetNetworkProfile(healthProbe, networkInterfaceConfigurations ?? new ChangeTrackingList<VirtualMachineScaleSetNetworkConfiguration>(), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.ParameterOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            if (propertyOverrides != null)
            {
                TransformFlattenedOverrides(bicepOptions, propertyOverrides);
            }

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HealthProbe), out propertyOverride);
            if (Optional.IsDefined(HealthProbe) || hasPropertyOverride)
            {
                builder.Append("  healthProbe: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    BicepSerializationHelpers.AppendChildObject(builder, HealthProbe, options, 2, false, "  healthProbe: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NetworkInterfaceConfigurations), out propertyOverride);
            if (Optional.IsCollectionDefined(NetworkInterfaceConfigurations) || hasPropertyOverride)
            {
                if (NetworkInterfaceConfigurations.Any() || hasPropertyOverride)
                {
                    builder.Append("  networkInterfaceConfigurations: ");
                    if (hasPropertyOverride)
                    {
                        builder.AppendLine($"{propertyOverride}");
                    }
                    else
                    {
                        builder.AppendLine("[");
                        foreach (var item in NetworkInterfaceConfigurations)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  networkInterfaceConfigurations: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void TransformFlattenedOverrides(BicepModelReaderWriterOptions bicepOptions, IDictionary<string, string> propertyOverrides)
        {
            foreach (var item in propertyOverrides.ToList())
            {
                switch (item.Key)
                {
                    case "HealthProbeId":
                        Dictionary<string, string> propertyDictionary = new Dictionary<string, string>();
                        propertyDictionary.Add("Id", item.Value);
                        bicepOptions.ParameterOverrides.Add(HealthProbe, propertyDictionary);
                        break;
                    default:
                        continue;
                }
            }
        }

        BinaryData IPersistableModel<VirtualMachineScaleSetNetworkProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetNetworkProfile)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineScaleSetNetworkProfile IPersistableModel<VirtualMachineScaleSetNetworkProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineScaleSetNetworkProfile(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetNetworkProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineScaleSetNetworkProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
