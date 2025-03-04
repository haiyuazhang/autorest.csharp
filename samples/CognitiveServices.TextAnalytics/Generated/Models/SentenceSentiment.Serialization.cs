// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;

namespace CognitiveServices.TextAnalytics.Models
{
    public partial class SentenceSentiment
    {
        internal static SentenceSentiment DeserializeSentenceSentiment(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string text = default;
            SentenceSentimentValue sentiment = default;
            SentimentConfidenceScorePerLabel confidenceScores = default;
            int offset = default;
            int length = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sentiment"u8))
                {
                    sentiment = property.Value.GetString().ToSentenceSentimentValue();
                    continue;
                }
                if (property.NameEquals("confidenceScores"u8))
                {
                    confidenceScores = SentimentConfidenceScorePerLabel.DeserializeSentimentConfidenceScorePerLabel(property.Value);
                    continue;
                }
                if (property.NameEquals("offset"u8))
                {
                    offset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("length"u8))
                {
                    length = property.Value.GetInt32();
                    continue;
                }
            }
            return new SentenceSentiment(text, sentiment, confidenceScores, offset, length);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SentenceSentiment FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeSentenceSentiment(document.RootElement);
        }
    }
}
