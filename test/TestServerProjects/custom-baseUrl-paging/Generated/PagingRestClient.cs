// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using custom_baseUrl_paging.Models;

namespace custom_baseUrl_paging
{
    internal partial class PagingRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _host;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of PagingRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="host"> A string value that is used as a global part of the parameterized host. The default value is "host". </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="host"/> is null. </exception>
        public PagingRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _host = host ?? throw new ArgumentNullException(nameof(host));
        }

        internal HttpMessage CreateGetPagesPartialUrlRequest(string accountName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("http://", false);
            uri.AppendRaw(accountName, false);
            uri.AppendRaw(_host, false);
            uri.AppendPath("/paging/customurl/partialnextlink", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL and expect to concat after host. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public async Task<Response<ProductResult>> GetPagesPartialUrlAsync(string accountName, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var message = CreateGetPagesPartialUrlRequest(accountName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ProductResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ProductResult.DeserializeProductResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL and expect to concat after host. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public Response<ProductResult> GetPagesPartialUrl(string accountName, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var message = CreateGetPagesPartialUrlRequest(accountName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ProductResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ProductResult.DeserializeProductResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetPagesPartialUrlOperationRequest(string accountName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("http://", false);
            uri.AppendRaw(accountName, false);
            uri.AppendRaw(_host, false);
            uri.AppendPath("/paging/customurl/partialnextlinkop", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL with next operation. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public async Task<Response<ProductResult>> GetPagesPartialUrlOperationAsync(string accountName, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var message = CreateGetPagesPartialUrlOperationRequest(accountName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ProductResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ProductResult.DeserializeProductResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL with next operation. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public Response<ProductResult> GetPagesPartialUrlOperation(string accountName, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var message = CreateGetPagesPartialUrlOperationRequest(accountName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ProductResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ProductResult.DeserializeProductResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetPagesPartialUrlOperationNextRequest(string accountName, string nextLink)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("http://", false);
            uri.AppendRaw(accountName, false);
            uri.AppendRaw(_host, false);
            uri.AppendPath("/paging/customurl/", false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="nextLink"> Next link for the list operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<ProductResult>> GetPagesPartialUrlOperationNextAsync(string accountName, string nextLink, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetPagesPartialUrlOperationNextRequest(accountName, nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ProductResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ProductResult.DeserializeProductResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="nextLink"> Next link for the list operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="nextLink"/> is null. </exception>
        public Response<ProductResult> GetPagesPartialUrlOperationNext(string accountName, string nextLink, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetPagesPartialUrlOperationNextRequest(accountName, nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ProductResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ProductResult.DeserializeProductResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetPagesPartialUrlNextPageRequest(string nextLink, string accountName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("http://", false);
            uri.AppendRaw(accountName, false);
            uri.AppendRaw(_host, false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL and expect to concat after host. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="accountName"/> is null. </exception>
        public async Task<Response<ProductResult>> GetPagesPartialUrlNextPageAsync(string nextLink, string accountName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var message = CreateGetPagesPartialUrlNextPageRequest(nextLink, accountName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ProductResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ProductResult.DeserializeProductResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL and expect to concat after host. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="accountName"/> is null. </exception>
        public Response<ProductResult> GetPagesPartialUrlNextPage(string nextLink, string accountName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var message = CreateGetPagesPartialUrlNextPageRequest(nextLink, accountName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ProductResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ProductResult.DeserializeProductResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
