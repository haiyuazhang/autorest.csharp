// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text.Json;

namespace body_complex.Models.V20160229
{
    public partial class DatetimeWrapper
    {
        internal void Serialize(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Field != null)
            {
                writer.WritePropertyName("field");
                Azure.Core.Utf8JsonWriterExtensions.WriteStringValue(writer, Field.Value, "S");
            }
            if (Now != null)
            {
                writer.WritePropertyName("now");
                Azure.Core.Utf8JsonWriterExtensions.WriteStringValue(writer, Now.Value, "S");
            }
            writer.WriteEndObject();
        }
        internal static DatetimeWrapper Deserialize(JsonElement element)
        {
            var result = new DatetimeWrapper();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("field"))
                {
                    result.Field = Azure.Core.TypeFormatters.GetDateTimeOffset(property.Value, "S");
                    continue;
                }
                if (property.NameEquals("now"))
                {
                    result.Now = Azure.Core.TypeFormatters.GetDateTimeOffset(property.Value, "S");
                    continue;
                }
            }
            return result;
        }
    }
}
