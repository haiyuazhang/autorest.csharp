// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace MgmtNonStringPathVariable
{
    internal class FakeOperationSource : IOperationSource<FakeResource>
    {
        private readonly ArmClient _client;

        internal FakeOperationSource(ArmClient client)
        {
            _client = client;
        }

        FakeResource IOperationSource<FakeResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            var data = FakeData.DeserializeFakeData(document.RootElement);
            return new FakeResource(_client, data);
        }

        async ValueTask<FakeResource> IOperationSource<FakeResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            var data = FakeData.DeserializeFakeData(document.RootElement);
            return new FakeResource(_client, data);
        }
    }
}
