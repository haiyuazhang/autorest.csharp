// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sample
{
    public partial class LogAnalyticsData
    {
        internal static LogAnalyticsData DeserializeLogAnalyticsData(JsonElement element)
        {
            Optional<LogAnalyticsOutput> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    properties = LogAnalyticsOutput.DeserializeLogAnalyticsOutput(property.Value);
                    continue;
                }
            }
            return new LogAnalyticsData(properties.Value);
        }
    }
}
