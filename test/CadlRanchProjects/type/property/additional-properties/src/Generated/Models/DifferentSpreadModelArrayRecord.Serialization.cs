// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace _Type.Property.AdditionalProperties.Models
{
    public partial class DifferentSpreadModelArrayRecord : IUtf8JsonSerializable, IJsonModel<DifferentSpreadModelArrayRecord>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DifferentSpreadModelArrayRecord>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DifferentSpreadModelArrayRecord>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DifferentSpreadModelArrayRecord>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DifferentSpreadModelArrayRecord)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("knownProp"u8);
            writer.WriteStringValue(KnownProp);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStartArray();
                foreach (var item0 in item.Value)
                {
                    if (item0 == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item0);
#else
                    using (JsonDocument document = JsonDocument.Parse(item0, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
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
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        DifferentSpreadModelArrayRecord IJsonModel<DifferentSpreadModelArrayRecord>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DifferentSpreadModelArrayRecord>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DifferentSpreadModelArrayRecord)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDifferentSpreadModelArrayRecord(document.RootElement, options);
        }

        internal static DifferentSpreadModelArrayRecord DeserializeDifferentSpreadModelArrayRecord(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string knownProp = default;
            IDictionary<string, IList<BinaryData>> additionalProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, IList<BinaryData>> additionalPropertiesDictionary = new Dictionary<string, IList<BinaryData>>();
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("knownProp"u8))
                {
                    knownProp = property.Value.GetString();
                    continue;
                }
                if (property.Value.ValueKind == JsonValueKind.Array)
                {
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    additionalPropertiesDictionary.Add(property.Name, array);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            additionalProperties = additionalPropertiesDictionary;
            serializedAdditionalRawData = rawDataDictionary;
            return new DifferentSpreadModelArrayRecord(knownProp, additionalProperties, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DifferentSpreadModelArrayRecord>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DifferentSpreadModelArrayRecord>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DifferentSpreadModelArrayRecord)} does not support writing '{options.Format}' format.");
            }
        }

        DifferentSpreadModelArrayRecord IPersistableModel<DifferentSpreadModelArrayRecord>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DifferentSpreadModelArrayRecord>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDifferentSpreadModelArrayRecord(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DifferentSpreadModelArrayRecord)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DifferentSpreadModelArrayRecord>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DifferentSpreadModelArrayRecord FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeDifferentSpreadModelArrayRecord(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
