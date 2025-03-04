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

namespace MgmtMultipleParentResource
{
    internal class SubParentOperationSource : IOperationSource<SubParentResource>
    {
        private readonly ArmClient _client;

        internal SubParentOperationSource(ArmClient client)
        {
            _client = client;
        }

        SubParentResource IOperationSource<SubParentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            var data = SubParentData.DeserializeSubParentData(document.RootElement);
            return new SubParentResource(_client, data);
        }

        async ValueTask<SubParentResource> IOperationSource<SubParentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            var data = SubParentData.DeserializeSubParentData(document.RootElement);
            return new SubParentResource(_client, data);
        }
    }
}
