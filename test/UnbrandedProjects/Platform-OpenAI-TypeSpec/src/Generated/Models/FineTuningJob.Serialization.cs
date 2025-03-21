// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Models
{
    public partial class FineTuningJob : IJsonModel<FineTuningJob>
    {
        void IJsonModel<FineTuningJob>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FineTuningJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FineTuningJob)} does not support writing '{format}' format.");
            }

            if (SerializedAdditionalRawData?.ContainsKey("id") != true)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (SerializedAdditionalRawData?.ContainsKey("object") != true)
            {
                writer.WritePropertyName("object"u8);
                writer.WriteStringValue(Object.ToString());
            }
            if (SerializedAdditionalRawData?.ContainsKey("created_at") != true)
            {
                writer.WritePropertyName("created_at"u8);
                writer.WriteNumberValue(CreatedAt, "U");
            }
            if (SerializedAdditionalRawData?.ContainsKey("finished_at") != true)
            {
                if (FinishedAt != null)
                {
                    writer.WritePropertyName("finished_at"u8);
                    writer.WriteNumberValue(FinishedAt.Value, "U");
                }
                else
                {
                    writer.WriteNull("finished_at");
                }
            }
            if (SerializedAdditionalRawData?.ContainsKey("model") != true)
            {
                writer.WritePropertyName("model"u8);
                writer.WriteStringValue(Model);
            }
            if (SerializedAdditionalRawData?.ContainsKey("fine_tuned_model") != true)
            {
                if (FineTunedModel != null)
                {
                    writer.WritePropertyName("fine_tuned_model"u8);
                    writer.WriteStringValue(FineTunedModel);
                }
                else
                {
                    writer.WriteNull("fine_tuned_model");
                }
            }
            if (SerializedAdditionalRawData?.ContainsKey("organization_id") != true)
            {
                writer.WritePropertyName("organization_id"u8);
                writer.WriteStringValue(OrganizationId);
            }
            if (SerializedAdditionalRawData?.ContainsKey("status") != true)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.ToSerialString());
            }
            if (SerializedAdditionalRawData?.ContainsKey("hyperparameters") != true)
            {
                writer.WritePropertyName("hyperparameters"u8);
                writer.WriteObjectValue(Hyperparameters, options);
            }
            if (SerializedAdditionalRawData?.ContainsKey("training_file") != true)
            {
                writer.WritePropertyName("training_file"u8);
                writer.WriteStringValue(TrainingFile);
            }
            if (SerializedAdditionalRawData?.ContainsKey("validation_file") != true)
            {
                if (ValidationFile != null)
                {
                    writer.WritePropertyName("validation_file"u8);
                    writer.WriteStringValue(ValidationFile);
                }
                else
                {
                    writer.WriteNull("validation_file");
                }
            }
            if (SerializedAdditionalRawData?.ContainsKey("result_files") != true)
            {
                writer.WritePropertyName("result_files"u8);
                writer.WriteStartArray();
                foreach (var item in ResultFiles)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (SerializedAdditionalRawData?.ContainsKey("trained_tokens") != true)
            {
                if (TrainedTokens != null)
                {
                    writer.WritePropertyName("trained_tokens"u8);
                    writer.WriteNumberValue(TrainedTokens.Value);
                }
                else
                {
                    writer.WriteNull("trained_tokens");
                }
            }
            if (SerializedAdditionalRawData?.ContainsKey("error") != true)
            {
                if (Error != null)
                {
                    writer.WritePropertyName("error"u8);
                    writer.WriteObjectValue(Error, options);
                }
                else
                {
                    writer.WriteNull("error");
                }
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

        FineTuningJob IJsonModel<FineTuningJob>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FineTuningJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FineTuningJob)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFineTuningJob(document.RootElement, options);
        }

        internal static FineTuningJob DeserializeFineTuningJob(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            FineTuningJobObject @object = default;
            DateTimeOffset createdAt = default;
            DateTimeOffset? finishedAt = default;
            string model = default;
            string fineTunedModel = default;
            string organizationId = default;
            FineTuningJobStatus status = default;
            FineTuningJobHyperparameters hyperparameters = default;
            string trainingFile = default;
            string validationFile = default;
            IReadOnlyList<string> resultFiles = default;
            long? trainedTokens = default;
            FineTuningJobError1 error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("object"u8))
                {
                    @object = new FineTuningJobObject(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("created_at"u8))
                {
                    createdAt = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
                if (property.NameEquals("finished_at"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        finishedAt = null;
                        continue;
                    }
                    finishedAt = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    model = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fine_tuned_model"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        fineTunedModel = null;
                        continue;
                    }
                    fineTunedModel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("organization_id"u8))
                {
                    organizationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString().ToFineTuningJobStatus();
                    continue;
                }
                if (property.NameEquals("hyperparameters"u8))
                {
                    hyperparameters = FineTuningJobHyperparameters.DeserializeFineTuningJobHyperparameters(property.Value, options);
                    continue;
                }
                if (property.NameEquals("training_file"u8))
                {
                    trainingFile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("validation_file"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationFile = null;
                        continue;
                    }
                    validationFile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("result_files"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    resultFiles = array;
                    continue;
                }
                if (property.NameEquals("trained_tokens"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        trainedTokens = null;
                        continue;
                    }
                    trainedTokens = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        error = null;
                        continue;
                    }
                    error = FineTuningJobError1.DeserializeFineTuningJobError1(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FineTuningJob(
                id,
                @object,
                createdAt,
                finishedAt,
                model,
                fineTunedModel,
                organizationId,
                status,
                hyperparameters,
                trainingFile,
                validationFile,
                resultFiles,
                trainedTokens,
                error,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FineTuningJob>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FineTuningJob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FineTuningJob)} does not support writing '{options.Format}' format.");
            }
        }

        FineTuningJob IPersistableModel<FineTuningJob>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FineTuningJob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeFineTuningJob(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FineTuningJob)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FineTuningJob>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static FineTuningJob FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeFineTuningJob(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
