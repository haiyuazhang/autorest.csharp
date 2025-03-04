// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;

namespace CognitiveSearch.Models
{
    public partial class ListSkillsetsResult
    {
        internal static ListSkillsetsResult DeserializeListSkillsetsResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<Skillset> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<Skillset> array = new List<Skillset>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Skillset.DeserializeSkillset(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ListSkillsetsResult(value);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ListSkillsetsResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeListSkillsetsResult(document.RootElement);
        }
    }
}
