// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace _Type._Dictionary
{
    // Data plane generated sub-client.
    /// <summary> Dictionary of int64 values. </summary>
    public partial class Int64Value
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of Int64Value for mocking. </summary>
        protected Int64Value()
        {
        }

        /// <summary> Initializes a new instance of Int64Value. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> Service host. </param>
        internal Int64Value(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _endpoint = endpoint;
        }

        /// <summary> Get int 64 value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <include file="Docs/Int64Value.xml" path="doc/members/member[@name='GetInt64ValueAsync(CancellationToken)']/*" />
        public virtual async Task<Response<IReadOnlyDictionary<string, long>>> GetInt64ValueAsync(CancellationToken cancellationToken = default)
        {
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await GetInt64ValueAsync(context).ConfigureAwait(false);
            IReadOnlyDictionary<string, long> value = default;
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            Dictionary<string, long> dictionary = new Dictionary<string, long>();
            foreach (var property in document.RootElement.EnumerateObject())
            {
                dictionary.Add(property.Name, property.Value.GetInt64());
            }
            value = dictionary;
            return Response.FromValue(value, response);
        }

        /// <summary> Get int 64 value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <include file="Docs/Int64Value.xml" path="doc/members/member[@name='GetInt64Value(CancellationToken)']/*" />
        public virtual Response<IReadOnlyDictionary<string, long>> GetInt64Value(CancellationToken cancellationToken = default)
        {
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = GetInt64Value(context);
            IReadOnlyDictionary<string, long> value = default;
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            Dictionary<string, long> dictionary = new Dictionary<string, long>();
            foreach (var property in document.RootElement.EnumerateObject())
            {
                dictionary.Add(property.Name, property.Value.GetInt64());
            }
            value = dictionary;
            return Response.FromValue(value, response);
        }

        /// <summary>
        /// [Protocol Method] Get int 64 value.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetInt64ValueAsync(CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Int64Value.xml" path="doc/members/member[@name='GetInt64ValueAsync(RequestContext)']/*" />
        public virtual async Task<Response> GetInt64ValueAsync(RequestContext context)
        {
            using var scope = ClientDiagnostics.CreateScope("Int64Value.GetInt64Value");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetInt64ValueRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Get int 64 value.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetInt64Value(CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Int64Value.xml" path="doc/members/member[@name='GetInt64Value(RequestContext)']/*" />
        public virtual Response GetInt64Value(RequestContext context)
        {
            using var scope = ClientDiagnostics.CreateScope("Int64Value.GetInt64Value");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetInt64ValueRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put. </summary>
        /// <param name="body"> The <see cref="IDictionary{TKey,TValue}"/> where <c>TKey</c> is of type <see cref="string"/>, where <c>TValue</c> is of type <see cref="long"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        /// <include file="Docs/Int64Value.xml" path="doc/members/member[@name='PutAsync(IDictionary{string,long},CancellationToken)']/*" />
        public virtual async Task<Response> PutAsync(IDictionary<string, long> body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(body, nameof(body));

            using RequestContent content = RequestContentHelper.FromDictionary(body);
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await PutAsync(content, context).ConfigureAwait(false);
            return response;
        }

        /// <summary> Put. </summary>
        /// <param name="body"> The <see cref="IDictionary{TKey,TValue}"/> where <c>TKey</c> is of type <see cref="string"/>, where <c>TValue</c> is of type <see cref="long"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        /// <include file="Docs/Int64Value.xml" path="doc/members/member[@name='Put(IDictionary{string,long},CancellationToken)']/*" />
        public virtual Response Put(IDictionary<string, long> body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(body, nameof(body));

            using RequestContent content = RequestContentHelper.FromDictionary(body);
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = Put(content, context);
            return response;
        }

        /// <summary>
        /// [Protocol Method] Put.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="PutAsync(IDictionary{string,long},CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Int64Value.xml" path="doc/members/member[@name='PutAsync(RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> PutAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("Int64Value.Put");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePutRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Put.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="Put(IDictionary{string,long},CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Int64Value.xml" path="doc/members/member[@name='Put(RequestContent,RequestContext)']/*" />
        public virtual Response Put(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("Int64Value.Put");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePutRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetInt64ValueRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/type/dictionary/int64", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreatePutRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/type/dictionary/int64", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        private static RequestContext DefaultRequestContext = new RequestContext();
        internal static RequestContext FromCancellationToken(CancellationToken cancellationToken = default)
        {
            if (!cancellationToken.CanBeCanceled)
            {
                return DefaultRequestContext;
            }

            return new RequestContext() { CancellationToken = cancellationToken };
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
        private static ResponseClassifier _responseClassifier204;
        private static ResponseClassifier ResponseClassifier204 => _responseClassifier204 ??= new StatusCodeClassifier(stackalloc ushort[] { 204 });
    }
}
