// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.AI.FormRecognizer.Models
{
    public partial class Model
    {
        internal static Model DeserializeModel(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ModelInfo modelInfo = default;
            KeysResult keys = default;
            TrainResult trainResult = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modelInfo"u8))
                {
                    modelInfo = ModelInfo.DeserializeModelInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("keys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keys = KeysResult.DeserializeKeysResult(property.Value);
                    continue;
                }
                if (property.NameEquals("trainResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trainResult = TrainResult.DeserializeTrainResult(property.Value);
                    continue;
                }
            }
            return new Model(modelInfo, keys, trainResult);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static Model FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeModel(document.RootElement);
        }
    }
}
