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
    public partial class SpreadFloatRecord : IUtf8JsonSerializable, IJsonModel<SpreadFloatRecord>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SpreadFloatRecord>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SpreadFloatRecord>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpreadFloatRecord>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SpreadFloatRecord)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("id"u8);
            writer.WriteNumberValue(Id);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteNumberValue(item.Value);
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

        SpreadFloatRecord IJsonModel<SpreadFloatRecord>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpreadFloatRecord>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SpreadFloatRecord)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSpreadFloatRecord(document.RootElement, options);
        }

        internal static SpreadFloatRecord DeserializeSpreadFloatRecord(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float id = default;
            IDictionary<string, float> additionalProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, float> additionalPropertiesDictionary = new Dictionary<string, float>();
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetSingle();
                    continue;
                }
                if (property.Value.TryGetSingle(out float value))
                {
                    additionalPropertiesDictionary.Add(property.Name, value);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            additionalProperties = additionalPropertiesDictionary;
            serializedAdditionalRawData = rawDataDictionary;
            return new SpreadFloatRecord(id, additionalProperties, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SpreadFloatRecord>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpreadFloatRecord>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SpreadFloatRecord)} does not support writing '{options.Format}' format.");
            }
        }

        SpreadFloatRecord IPersistableModel<SpreadFloatRecord>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpreadFloatRecord>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSpreadFloatRecord(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SpreadFloatRecord)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SpreadFloatRecord>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SpreadFloatRecord FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeSpreadFloatRecord(document.RootElement);
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
