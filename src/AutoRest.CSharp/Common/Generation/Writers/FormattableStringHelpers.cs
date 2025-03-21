// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using AutoRest.CSharp.Common.Input;
using AutoRest.CSharp.Common.Output.Expressions.ValueExpressions;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Output.Models;
using AutoRest.CSharp.Output.Models.Requests;
using AutoRest.CSharp.Output.Models.Shared;
using AutoRest.CSharp.Output.Models.Types;
using AutoRest.CSharp.Utilities;
using Azure.Core;
using static AutoRest.CSharp.Common.Output.Models.Snippets;

namespace AutoRest.CSharp.Generation.Writers
{
    internal static class FormattableStringHelpers
    {
        public static FormattableString Empty => $"";

        [return: NotNullIfNotNull(nameof(s))]
        public static FormattableString? FromString(string? s) =>
            s is null ? null : s.Length == 0 ? Empty : $"{s}";

        public static bool IsNullOrEmpty(this FormattableString? fs) =>
            fs is null || string.IsNullOrEmpty(fs.Format) && fs.ArgumentCount == 0;

        public static bool IsEmpty(this FormattableString fs) =>
            string.IsNullOrEmpty(fs.Format) && fs.ArgumentCount == 0;

        public static FormattableString Join(this ICollection<FormattableString> fss, string separator, string? lastSeparator = null)
            => fss.Count == 1 ? fss.First() : Join(fss, fss.Count, static fs => fs, separator, lastSeparator, null);

        public static FormattableString GetClientTypesFormattable(this IReadOnlyList<LowLevelClient> clients)
            => Join(clients, clients.Count, static c => c.Type, ", ", null, 'C');

        public static FormattableString GetLiteralsFormattable(this IReadOnlyCollection<Parameter> parameters)
            => GetLiteralsFormattable(parameters.Select(p => p.Name), parameters.Count);

        public static FormattableString GetLiteralsFormattable(this IReadOnlyCollection<Reference> references)
            => GetLiteralsFormattable(references.Select(p => p.Name), references.Count);

        public static FormattableString GetLiteralsFormattable(this IReadOnlyCollection<string> literals)
            => GetLiteralsFormattable(literals, literals.Count);

        public static FormattableString GetLiteralsFormattable(this ICollection<string> literals)
            => GetLiteralsFormattable(literals, literals.Count);

        public static FormattableString GetLiteralsFormattable(this IEnumerable<string> literals, int count)
            => Join(literals, count, static l => l, ", ", null, 'L');

        public static FormattableString GetTypesFormattable(this IReadOnlyCollection<Parameter> parameters)
            => GetTypesFormattable(parameters, parameters.Count);

        public static FormattableString GetTypesFormattable(this IEnumerable<Parameter> parameters, int count)
            => Join(parameters, count, static p => p.Type, ",", null, null);

        public static FormattableString GetIdentifiersFormattable(this IReadOnlyCollection<Parameter> parameters)
            => GetIdentifiersFormattable(parameters.Select(p => p.Name), parameters.Count);

        public static FormattableString GetIdentifiersFormattable(this IReadOnlyCollection<Reference> references)
            => GetIdentifiersFormattable(references.Select(p => p.Name), references.Count);

        public static FormattableString GetIdentifiersFormattable(this IReadOnlyCollection<string> identifiers)
            => GetIdentifiersFormattable(identifiers, identifiers.Count);

        public static FormattableString GetIdentifiersFormattable(this IEnumerable<string> identifiers, int count)
            => Join(identifiers, count, static i => i, ", ", null, 'I');

        public static FormattableString? GetParameterInitializer(this CSharpType parameterType, Constant? defaultValue)
        {
            if (parameterType.IsValueType)
            {
                return null;
            }

            if (parameterType.IsCollection && (defaultValue == null || defaultValue.Value.Type.IsCollection))
            {
                defaultValue = Constant.NewInstanceOf(parameterType.InitializationType.WithNullable(false));
            }

            if (defaultValue == null)
            {
                return null;
            }

            var constantFormattable = GetConstantFormattable(defaultValue.Value);
            var conversion = GetConversionMethod(defaultValue.Value.Type, parameterType);
            return conversion == null ? constantFormattable : $"{constantFormattable}{conversion}";
        }

        public static FormattableString GetConversionFormattable(this Parameter parameter, CSharpType toType, string? contentType)
        {
            if (toType.EqualsIgnoreNullable(Configuration.ApiTypes.RequestContentType))
            {
                switch (parameter.Type)
                {
                    case { IsFrameworkType: true }:
                        return parameter.GetConversionFromFrameworkToRequestContent(contentType);
                    case { IsFrameworkType: false, Implementation: EnumType enumType }:
                        if (enumType.IsExtensible)
                        {
                            return $"{typeof(BinaryData)}.{nameof(BinaryData.FromObjectAsJson)}({parameter.Name}.{enumType.SerializationMethodName}())";
                        }
                        else
                        {
                            return $"{typeof(BinaryData)}.{nameof(BinaryData.FromObjectAsJson)}({(enumType.IsIntValueType ? $"({enumType.ValueType}){parameter.Name}" : $"{parameter.Name}.{enumType.SerializationMethodName}()")})";
                        }
                    case { IsFrameworkType: false, Implementation: ModelTypeProvider }:
                        {
                            BodyMediaType? mediaType = contentType == null ? null : BodyMediaTypeHelper.FromString(contentType);
                            if (mediaType == BodyMediaType.Multipart)
                            {
                                return $"{parameter.Name:I}.{Configuration.ApiTypes.ToMultipartRequestContentName}()";
                            }
                            break;
                        }
                }
            }

            var conversionMethod = GetConversionMethod(parameter.Type, toType);
            if (conversionMethod == null)
            {
                return $"{parameter.Name:I}";
            }

            if (parameter.IsOptionalInSignature)
            {
                return $"{parameter.Name:I}?{conversionMethod}";
            }

            return $"{parameter.Name:I}{conversionMethod}";
        }

        private static FormattableString GetConversionFromFrameworkToRequestContent(this Parameter parameter, string? contentType)
        {
            if (parameter.Type.IsReadWriteDictionary)
            {
                var dictionary = (ValueExpression)parameter;
                var expression = RequestContentHelperProvider.Instance.FromDictionary(dictionary);
                if (parameter.IsOptionalInSignature)
                {
                    expression = new TernaryConditionalOperator(NotEqual(dictionary, Null), expression, Null);
                }
                return $"{expression}";
            }

            if (parameter.Type.IsList)
            {
                var enumerable = (ValueExpression)parameter;
                var expression = RequestContentHelperProvider.Instance.FromEnumerable(enumerable);
                if (parameter.IsOptionalInSignature)
                {
                    expression = new TernaryConditionalOperator(NotEqual(enumerable, Null), expression, Null);
                }
                return $"{expression}";
            }

            if (parameter.Type.IsFrameworkType == true && parameter.Type.FrameworkType == typeof(AzureLocation))
            {
                return $"{RequestContentHelperProvider.Instance.FromObject(((ValueExpression)parameter).InvokeToString())}";
            }

            BodyMediaType? mediaType = contentType == null ? null : BodyMediaTypeHelper.FromString(contentType);
            if (parameter.RequestLocation == RequestLocation.Body && mediaType == BodyMediaType.Binary)
            {
                return $"{parameter.Name:I}";
            }
            // TODO: Here we only consider the case when body is string type. We will add support for other types.
            if (parameter.RequestLocation == RequestLocation.Body && mediaType == BodyMediaType.Text && parameter.Type.FrameworkType == typeof(string))
            {
                return $"{parameter.Name:I}";
            }

            return $"{RequestContentHelperProvider.Instance.FromObject(parameter)}";
        }

        public static string? GetConversionMethod(CSharpType fromType, CSharpType toType)
            => fromType switch
            {
                { IsFrameworkType: false, Implementation: EnumType { IsExtensible: true } } when toType.EqualsIgnoreNullable(typeof(string)) => ".ToString()",
                { IsFrameworkType: false, Implementation: EnumType { IsExtensible: false } } when toType.EqualsIgnoreNullable(typeof(string)) => ".ToSerialString()",
                { IsFrameworkType: false, Implementation: EnumType } when toType.EqualsIgnoreNullable(typeof(int)) => ".ToSerialInt32()",
                { IsFrameworkType: false, Implementation: EnumType } when toType.EqualsIgnoreNullable(typeof(float)) => ".ToSerialSingle()",
                { IsFrameworkType: false, Implementation: ModelTypeProvider } when toType.EqualsIgnoreNullable(Configuration.ApiTypes.RequestContentType) => $".{Configuration.ApiTypes.ToRequestContentName}()",
                _ => null
            };

        public static FormattableString GetReferenceOrConstantFormattable(this ReferenceOrConstant value)
            => value.IsConstant ? value.Constant.GetConstantFormattable() : value.Reference.GetReferenceFormattable();

        public static FormattableString GetReferenceFormattable(this Reference reference)
        {
            var parts = reference.Name.Split(".").ToArray<object>();
            return Join(parts, parts.Length, static s => s, ".", null, 'I');
        }

        public static FormattableString GetConstantFormattable(this Constant constant, bool writeAsString = false)
        {
            if (constant.Value == null)
            {
                // Cast helps the overload resolution
                return $"({constant.Type}){null:L}";
            }

            if (constant.IsNewInstanceSentinel)
            {
                return $"new {constant.Type}()";
            }

            if (constant.Value is Constant.Expression expression)
            {
                return expression.ExpressionValue;
            }

            if (constant is { Type: { IsFrameworkType: false }, Value: EnumTypeValue enumTypeValue })
            {
                return $"{constant.Type}.{enumTypeValue.Declaration.Name}";
            }

            // we cannot check `constant.Value is string` because it is always string - this is an issue in yaml serialization)
            if (constant.Type is { IsFrameworkType: false, Implementation: EnumType enumType })
            {
                if (enumType.IsStringValueType)
                    return $"new {constant.Type}({constant.Value:L})";
                else
                    return $"new {constant.Type}(({enumType.ValueType}){constant.Value})";
            }

            Type frameworkType = constant.Type.FrameworkType;
            if (frameworkType == typeof(DateTimeOffset))
            {
                var d = (DateTimeOffset)constant.Value;
                d = d.ToUniversalTime();
                return $"new {typeof(DateTimeOffset)}({d.Year:L}, {d.Month:L}, {d.Day:L} ,{d.Hour:L}, {d.Minute:L}, {d.Second:L}, {d.Millisecond:L}, {typeof(TimeSpan)}.{nameof(TimeSpan.Zero)})";
            }

            if (frameworkType == typeof(byte[]))
            {
                var bytes = (byte[])constant.Value;
                var joinedBytes = string.Join(", ", bytes);
                return $"new byte[] {{{joinedBytes}}}";
            }

            if (frameworkType == typeof(ResourceType))
            {
                return $"{((ResourceType)constant.Value).ToString():L}";
            }

            if (frameworkType == typeof(bool) && writeAsString)
            {
                return $"\"{constant.Value!.ToString()!.ToLower()}\"";
            }

            return $"{constant.Value:L}";
        }

        private static FormattableString Join<T>(IEnumerable<T> source, int count, Func<T, object> converter, string separator, string? lastSeparator, char? format)
            => count switch
            {
                0 => Empty,
                1 => FormattableStringFactory.Create(format is not null ? $"{{0:{format}}}" : "{0}", converter(source.First())),
                _ => FormattableStringFactory.Create(CreateFormatWithSeparator(separator, lastSeparator, format, count), source.Select(converter).ToArray())
            };

        private static string CreateFormatWithSeparator(string separator, string? lastSeparator, char? format, int count)
        {
            const int offset = 48; // (int)'0' is 48
            if (count > 100)
            {
                var s = string.Join(separator, Enumerable.Range(0, count).Select(i => $"{{{i}}}"));
                return lastSeparator is null ? s : s.ReplaceLast(separator, lastSeparator);
            }

            Debug.Assert(count > 1);

            lastSeparator ??= separator;

            var placeholderLength = format.HasValue ? 5 : 3;
            var length = count < 10
                ? count * placeholderLength
                : (count - 10) * (placeholderLength + 1) + 10 * placeholderLength;

            length += separator.Length * (count - 2) + lastSeparator.Length;

            return string.Create(length, (separator, lastSeparator, format, count), static (span, state) =>
            {
                var (separator, lastSeparator, format, count) = state;
                for (int i = 0; i < count; i++)
                {
                    span[0] = '{';
                    if (i < 10)
                    {
                        span[1] = (char)(i + offset);
                        span = span[2..];
                    }
                    else
                    {
                        span[1] = (char)(i / 10 + offset);
                        span[2] = (char)(i % 10 + offset);
                        span = span[3..];
                    }

                    if (format is not null)
                    {
                        span[0] = ':';
                        span[1] = format.Value;
                        span = span[2..];
                    }

                    span[0] = '}';
                    span = span[1..];

                    if (i < count - 1)
                    {
                        var separatorToUse = i < count - 2 ? separator : lastSeparator;
                        separatorToUse.CopyTo(span);
                        span = span[separatorToUse.Length..];
                    }
                }

                Debug.Assert(span.IsEmpty);
            });
        }
    }
}
