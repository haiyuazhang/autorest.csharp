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
    public partial class Index : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("fields"u8);
            writer.WriteStartArray();
            foreach (var item in Fields)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(ScoringProfiles))
            {
                writer.WritePropertyName("scoringProfiles"u8);
                writer.WriteStartArray();
                foreach (var item in ScoringProfiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultScoringProfile))
            {
                writer.WritePropertyName("defaultScoringProfile"u8);
                writer.WriteStringValue(DefaultScoringProfile);
            }
            if (Optional.IsDefined(CorsOptions))
            {
                writer.WritePropertyName("corsOptions"u8);
                writer.WriteObjectValue(CorsOptions);
            }
            if (Optional.IsCollectionDefined(Suggesters))
            {
                writer.WritePropertyName("suggesters"u8);
                writer.WriteStartArray();
                foreach (var item in Suggesters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Analyzers))
            {
                writer.WritePropertyName("analyzers"u8);
                writer.WriteStartArray();
                foreach (var item in Analyzers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Tokenizers))
            {
                writer.WritePropertyName("tokenizers"u8);
                writer.WriteStartArray();
                foreach (var item in Tokenizers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TokenFilters))
            {
                writer.WritePropertyName("tokenFilters"u8);
                writer.WriteStartArray();
                foreach (var item in TokenFilters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CharFilters))
            {
                writer.WritePropertyName("charFilters"u8);
                writer.WriteStartArray();
                foreach (var item in CharFilters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EncryptionKey))
            {
                writer.WritePropertyName("encryptionKey"u8);
                writer.WriteObjectValue(EncryptionKey);
            }
            if (Optional.IsDefined(Similarity))
            {
                writer.WritePropertyName("similarity"u8);
                writer.WriteObjectValue(Similarity);
            }
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("@odata.etag"u8);
                writer.WriteStringValue(ETag);
            }
            writer.WriteEndObject();
        }

        internal static Index DeserializeIndex(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IList<Field> fields = default;
            IList<ScoringProfile> scoringProfiles = default;
            string defaultScoringProfile = default;
            CorsOptions corsOptions = default;
            IList<Suggester> suggesters = default;
            IList<Analyzer> analyzers = default;
            IList<Tokenizer> tokenizers = default;
            IList<TokenFilter> tokenFilters = default;
            IList<CharFilter> charFilters = default;
            EncryptionKey encryptionKey = default;
            Similarity similarity = default;
            string odataEtag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fields"u8))
                {
                    List<Field> array = new List<Field>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Field.DeserializeField(item));
                    }
                    fields = array;
                    continue;
                }
                if (property.NameEquals("scoringProfiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScoringProfile> array = new List<ScoringProfile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScoringProfile.DeserializeScoringProfile(item));
                    }
                    scoringProfiles = array;
                    continue;
                }
                if (property.NameEquals("defaultScoringProfile"u8))
                {
                    defaultScoringProfile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("corsOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    corsOptions = CorsOptions.DeserializeCorsOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("suggesters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Suggester> array = new List<Suggester>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Suggester.DeserializeSuggester(item));
                    }
                    suggesters = array;
                    continue;
                }
                if (property.NameEquals("analyzers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Analyzer> array = new List<Analyzer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Analyzer.DeserializeAnalyzer(item));
                    }
                    analyzers = array;
                    continue;
                }
                if (property.NameEquals("tokenizers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Tokenizer> array = new List<Tokenizer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Tokenizer.DeserializeTokenizer(item));
                    }
                    tokenizers = array;
                    continue;
                }
                if (property.NameEquals("tokenFilters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TokenFilter> array = new List<TokenFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TokenFilter.DeserializeTokenFilter(item));
                    }
                    tokenFilters = array;
                    continue;
                }
                if (property.NameEquals("charFilters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CharFilter> array = new List<CharFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CharFilter.DeserializeCharFilter(item));
                    }
                    charFilters = array;
                    continue;
                }
                if (property.NameEquals("encryptionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptionKey = EncryptionKey.DeserializeEncryptionKey(property.Value);
                    continue;
                }
                if (property.NameEquals("similarity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    similarity = Similarity.DeserializeSimilarity(property.Value);
                    continue;
                }
                if (property.NameEquals("@odata.etag"u8))
                {
                    odataEtag = property.Value.GetString();
                    continue;
                }
            }
            return new Index(
                name,
                fields,
                scoringProfiles ?? new ChangeTrackingList<ScoringProfile>(),
                defaultScoringProfile,
                corsOptions,
                suggesters ?? new ChangeTrackingList<Suggester>(),
                analyzers ?? new ChangeTrackingList<Analyzer>(),
                tokenizers ?? new ChangeTrackingList<Tokenizer>(),
                tokenFilters ?? new ChangeTrackingList<TokenFilter>(),
                charFilters ?? new ChangeTrackingList<CharFilter>(),
                encryptionKey,
                similarity,
                odataEtag);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static Index FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeIndex(document.RootElement);
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
