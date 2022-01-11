// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using MgmtListMethods.Models;

namespace MgmtListMethods
{
    /// <summary> A class representing collection of TenantParentWithLoc and their operations over its parent. </summary>
    public partial class TenantParentWithLocCollection : ArmCollection, IEnumerable<TenantParentWithLoc>, IAsyncEnumerable<TenantParentWithLoc>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly TenantParentWithLocsRestOperations _tenantParentWithLocsRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantParentWithLocCollection"/> class for mocking. </summary>
        protected TenantParentWithLocCollection()
        {
        }

        /// <summary> Initializes a new instance of TenantParentWithLocCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal TenantParentWithLocCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _tenantParentWithLocsRestClient = new TenantParentWithLocsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantTest.ResourceType)
                throw new ArgumentException(nameof(id), string.Format("Invalid resource type {0} expected {1}", id.ResourceType, TenantTest.ResourceType));
        }

        // Collection level operations.

        /// RequestPath: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithLocs/{tenantParentWithLocName}
        /// ContextualPath: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}
        /// OperationId: TenantParentWithLocs_CreateOrUpdate
        /// <summary> Create or update. </summary>
        /// <param name="tenantParentWithLocName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithLocName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual TenantParentWithLocCreateOrUpdateOperation CreateOrUpdate(string tenantParentWithLocName, TenantParentWithLocData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (tenantParentWithLocName == null)
            {
                throw new ArgumentNullException(nameof(tenantParentWithLocName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantParentWithLocCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _tenantParentWithLocsRestClient.CreateOrUpdate(Id.Name, tenantParentWithLocName, parameters, cancellationToken);
                var operation = new TenantParentWithLocCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithLocs/{tenantParentWithLocName}
        /// ContextualPath: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}
        /// OperationId: TenantParentWithLocs_CreateOrUpdate
        /// <summary> Create or update. </summary>
        /// <param name="tenantParentWithLocName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithLocName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<TenantParentWithLocCreateOrUpdateOperation> CreateOrUpdateAsync(string tenantParentWithLocName, TenantParentWithLocData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (tenantParentWithLocName == null)
            {
                throw new ArgumentNullException(nameof(tenantParentWithLocName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantParentWithLocCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _tenantParentWithLocsRestClient.CreateOrUpdateAsync(Id.Name, tenantParentWithLocName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new TenantParentWithLocCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithLocs/{tenantParentWithLocName}
        /// ContextualPath: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}
        /// OperationId: TenantParentWithLocs_Get
        /// <summary> Retrieves information. </summary>
        /// <param name="tenantParentWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithLocName"/> is null. </exception>
        public virtual Response<TenantParentWithLoc> Get(string tenantParentWithLocName, CancellationToken cancellationToken = default)
        {
            if (tenantParentWithLocName == null)
            {
                throw new ArgumentNullException(nameof(tenantParentWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantParentWithLocCollection.Get");
            scope.Start();
            try
            {
                var response = _tenantParentWithLocsRestClient.Get(Id.Name, tenantParentWithLocName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantParentWithLoc(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithLocs/{tenantParentWithLocName}
        /// ContextualPath: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}
        /// OperationId: TenantParentWithLocs_Get
        /// <summary> Retrieves information. </summary>
        /// <param name="tenantParentWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithLocName"/> is null. </exception>
        public async virtual Task<Response<TenantParentWithLoc>> GetAsync(string tenantParentWithLocName, CancellationToken cancellationToken = default)
        {
            if (tenantParentWithLocName == null)
            {
                throw new ArgumentNullException(nameof(tenantParentWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantParentWithLocCollection.Get");
            scope.Start();
            try
            {
                var response = await _tenantParentWithLocsRestClient.GetAsync(Id.Name, tenantParentWithLocName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new TenantParentWithLoc(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tenantParentWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithLocName"/> is null. </exception>
        public virtual Response<TenantParentWithLoc> GetIfExists(string tenantParentWithLocName, CancellationToken cancellationToken = default)
        {
            if (tenantParentWithLocName == null)
            {
                throw new ArgumentNullException(nameof(tenantParentWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantParentWithLocCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _tenantParentWithLocsRestClient.Get(Id.Name, tenantParentWithLocName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<TenantParentWithLoc>(null, response.GetRawResponse())
                    : Response.FromValue(new TenantParentWithLoc(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tenantParentWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithLocName"/> is null. </exception>
        public async virtual Task<Response<TenantParentWithLoc>> GetIfExistsAsync(string tenantParentWithLocName, CancellationToken cancellationToken = default)
        {
            if (tenantParentWithLocName == null)
            {
                throw new ArgumentNullException(nameof(tenantParentWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantParentWithLocCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _tenantParentWithLocsRestClient.GetAsync(Id.Name, tenantParentWithLocName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<TenantParentWithLoc>(null, response.GetRawResponse())
                    : Response.FromValue(new TenantParentWithLoc(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tenantParentWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithLocName"/> is null. </exception>
        public virtual Response<bool> Exists(string tenantParentWithLocName, CancellationToken cancellationToken = default)
        {
            if (tenantParentWithLocName == null)
            {
                throw new ArgumentNullException(nameof(tenantParentWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantParentWithLocCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(tenantParentWithLocName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tenantParentWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithLocName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string tenantParentWithLocName, CancellationToken cancellationToken = default)
        {
            if (tenantParentWithLocName == null)
            {
                throw new ArgumentNullException(nameof(tenantParentWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantParentWithLocCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(tenantParentWithLocName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithLocs
        /// ContextualPath: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}
        /// OperationId: TenantParentWithLocs_List
        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TenantParentWithLoc" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TenantParentWithLoc> GetAll(CancellationToken cancellationToken = default)
        {
            Page<TenantParentWithLoc> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TenantParentWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _tenantParentWithLocsRestClient.List(Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TenantParentWithLoc(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<TenantParentWithLoc> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TenantParentWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _tenantParentWithLocsRestClient.ListNextPage(nextLink, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TenantParentWithLoc(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithLocs
        /// ContextualPath: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}
        /// OperationId: TenantParentWithLocs_List
        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TenantParentWithLoc" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TenantParentWithLoc> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<TenantParentWithLoc>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TenantParentWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _tenantParentWithLocsRestClient.ListAsync(Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TenantParentWithLoc(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<TenantParentWithLoc>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TenantParentWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _tenantParentWithLocsRestClient.ListNextPageAsync(nextLink, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TenantParentWithLoc(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<TenantParentWithLoc> IEnumerable<TenantParentWithLoc>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TenantParentWithLoc> IAsyncEnumerable<TenantParentWithLoc>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, TenantParentWithLoc, TenantParentWithLocData> Construct() { }
    }
}
