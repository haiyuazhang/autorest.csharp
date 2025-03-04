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

namespace MgmtScopeResource
{
    internal class DeploymentExtendedOperationSource : IOperationSource<DeploymentExtendedResource>
    {
        private readonly ArmClient _client;

        internal DeploymentExtendedOperationSource(ArmClient client)
        {
            _client = client;
        }

        DeploymentExtendedResource IOperationSource<DeploymentExtendedResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            var data = DeploymentExtendedData.DeserializeDeploymentExtendedData(document.RootElement);
            return new DeploymentExtendedResource(_client, data);
        }

        async ValueTask<DeploymentExtendedResource> IOperationSource<DeploymentExtendedResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            var data = DeploymentExtendedData.DeserializeDeploymentExtendedData(document.RootElement);
            return new DeploymentExtendedResource(_client, data);
        }
    }
}
