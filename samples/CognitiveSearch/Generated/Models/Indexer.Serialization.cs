// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class Indexer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("dataSourceName"u8);
            writer.WriteStringValue(DataSourceName);
            if (Optional.IsDefined(SkillsetName))
            {
                writer.WritePropertyName("skillsetName"u8);
                writer.WriteStringValue(SkillsetName);
            }
            writer.WritePropertyName("targetIndexName"u8);
            writer.WriteStringValue(TargetIndexName);
            if (Optional.IsDefined(Schedule))
            {
                writer.WritePropertyName("schedule"u8);
                writer.WriteObjectValue(Schedule);
            }
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteObjectValue(Parameters);
            }
            if (Optional.IsCollectionDefined(FieldMappings))
            {
                writer.WritePropertyName("fieldMappings"u8);
                writer.WriteStartArray();
                foreach (var item in FieldMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(OutputFieldMappings))
            {
                writer.WritePropertyName("outputFieldMappings"u8);
                writer.WriteStartArray();
                foreach (var item in OutputFieldMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsDisabled))
            {
                writer.WritePropertyName("disabled"u8);
                writer.WriteBooleanValue(IsDisabled.Value);
            }
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("@odata.etag"u8);
                writer.WriteStringValue(ETag);
            }
            writer.WriteEndObject();
        }

        internal static Indexer DeserializeIndexer(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string description = default;
            string dataSourceName = default;
            string skillsetName = default;
            string targetIndexName = default;
            IndexingSchedule schedule = default;
            IndexingParameters parameters = default;
            IList<FieldMapping> fieldMappings = default;
            IList<FieldMapping> outputFieldMappings = default;
            bool? disabled = default;
            string odataEtag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSourceName"u8))
                {
                    dataSourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skillsetName"u8))
                {
                    skillsetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetIndexName"u8))
                {
                    targetIndexName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schedule = IndexingSchedule.DeserializeIndexingSchedule(property.Value);
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parameters = IndexingParameters.DeserializeIndexingParameters(property.Value);
                    continue;
                }
                if (property.NameEquals("fieldMappings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FieldMapping> array = new List<FieldMapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FieldMapping.DeserializeFieldMapping(item));
                    }
                    fieldMappings = array;
                    continue;
                }
                if (property.NameEquals("outputFieldMappings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FieldMapping> array = new List<FieldMapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FieldMapping.DeserializeFieldMapping(item));
                    }
                    outputFieldMappings = array;
                    continue;
                }
                if (property.NameEquals("disabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("@odata.etag"u8))
                {
                    odataEtag = property.Value.GetString();
                    continue;
                }
            }
            return new Indexer(
                name,
                description,
                dataSourceName,
                skillsetName,
                targetIndexName,
                schedule,
                parameters,
                fieldMappings ?? new ChangeTrackingList<FieldMapping>(),
                outputFieldMappings ?? new ChangeTrackingList<FieldMapping>(),
                disabled,
                odataEtag);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static Indexer FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeIndexer(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
