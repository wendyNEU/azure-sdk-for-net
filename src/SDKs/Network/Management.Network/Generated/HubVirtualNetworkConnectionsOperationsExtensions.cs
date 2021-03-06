// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for HubVirtualNetworkConnectionsOperations.
    /// </summary>
    public static partial class HubVirtualNetworkConnectionsOperationsExtensions
    {
            /// <summary>
            /// Retrieves the details of a HubVirtualNetworkConnection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubName'>
            /// The name of the VirtualHub.
            /// </param>
            /// <param name='connectionName'>
            /// The name of the vpn connection.
            /// </param>
            public static HubVirtualNetworkConnection Get(this IHubVirtualNetworkConnectionsOperations operations, string resourceGroupName, string virtualHubName, string connectionName)
            {
                return operations.GetAsync(resourceGroupName, virtualHubName, connectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves the details of a HubVirtualNetworkConnection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubName'>
            /// The name of the VirtualHub.
            /// </param>
            /// <param name='connectionName'>
            /// The name of the vpn connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HubVirtualNetworkConnection> GetAsync(this IHubVirtualNetworkConnectionsOperations operations, string resourceGroupName, string virtualHubName, string connectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, virtualHubName, connectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves the details of all HubVirtualNetworkConnections.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubName'>
            /// The name of the VirtualHub.
            /// </param>
            public static IPage<HubVirtualNetworkConnection> List(this IHubVirtualNetworkConnectionsOperations operations, string resourceGroupName, string virtualHubName)
            {
                return operations.ListAsync(resourceGroupName, virtualHubName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves the details of all HubVirtualNetworkConnections.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubName'>
            /// The name of the VirtualHub.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<HubVirtualNetworkConnection>> ListAsync(this IHubVirtualNetworkConnectionsOperations operations, string resourceGroupName, string virtualHubName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, virtualHubName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves the details of all HubVirtualNetworkConnections.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<HubVirtualNetworkConnection> ListNext(this IHubVirtualNetworkConnectionsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves the details of all HubVirtualNetworkConnections.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<HubVirtualNetworkConnection>> ListNextAsync(this IHubVirtualNetworkConnectionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
