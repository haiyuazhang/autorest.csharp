// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Models
{
    public partial class ChatCompletionRequestMessage : IJsonModel<ChatCompletionRequestMessage>
    {
        void IJsonModel<ChatCompletionRequestMessage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionRequestMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatCompletionRequestMessage)} does not support writing '{format}' format.");
            }

            if (SerializedAdditionalRawData?.ContainsKey("role") != true)
            {
                writer.WritePropertyName("role"u8);
                writer.WriteStringValue(Role.ToSerialString());
            }
            if (SerializedAdditionalRawData?.ContainsKey("content") != true)
            {
                if (Content != null)
                {
                    writer.WritePropertyName("content"u8);
                    writer.WriteStringValue(Content);
                }
                else
                {
                    writer.WriteNull("content");
                }
            }
            if (SerializedAdditionalRawData?.ContainsKey("name") != true && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (SerializedAdditionalRawData?.ContainsKey("function_call") != true && Optional.IsDefined(FunctionCall))
            {
                writer.WritePropertyName("function_call"u8);
                writer.WriteObjectValue(FunctionCall, options);
            }
            if (SerializedAdditionalRawData != null)
            {
                foreach (var item in SerializedAdditionalRawData)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
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

        ChatCompletionRequestMessage IJsonModel<ChatCompletionRequestMessage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionRequestMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatCompletionRequestMessage)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChatCompletionRequestMessage(document.RootElement, options);
        }

        internal static ChatCompletionRequestMessage DeserializeChatCompletionRequestMessage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ChatCompletionRequestMessageRole role = default;
            string content = default;
            string name = default;
            ChatCompletionRequestMessageFunctionCall functionCall = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("role"u8))
                {
                    role = property.Value.GetString().ToChatCompletionRequestMessageRole();
                    continue;
                }
                if (property.NameEquals("content"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        content = null;
                        continue;
                    }
                    content = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("function_call"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    functionCall = ChatCompletionRequestMessageFunctionCall.DeserializeChatCompletionRequestMessageFunctionCall(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ChatCompletionRequestMessage(role, content, name, functionCall, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ChatCompletionRequestMessage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionRequestMessage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChatCompletionRequestMessage)} does not support writing '{options.Format}' format.");
            }
        }

        ChatCompletionRequestMessage IPersistableModel<ChatCompletionRequestMessage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionRequestMessage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeChatCompletionRequestMessage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChatCompletionRequestMessage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChatCompletionRequestMessage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static ChatCompletionRequestMessage FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeChatCompletionRequestMessage(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
