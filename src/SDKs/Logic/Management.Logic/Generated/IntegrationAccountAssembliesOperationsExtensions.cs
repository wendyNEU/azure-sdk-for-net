// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for IntegrationAccountAssembliesOperations.
    /// </summary>
    public static partial class IntegrationAccountAssembliesOperationsExtensions
    {
            /// <summary>
            /// List the assemblies for an integration account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            public static IEnumerable<AssemblyDefinition> List(this IIntegrationAccountAssembliesOperations operations, string resourceGroupName, string integrationAccountName)
            {
                return operations.ListAsync(resourceGroupName, integrationAccountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the assemblies for an integration account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<AssemblyDefinition>> ListAsync(this IIntegrationAccountAssembliesOperations operations, string resourceGroupName, string integrationAccountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, integrationAccountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get an assembly for an integration account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='assemblyArtifactName'>
            /// The assembly artifact name.
            /// </param>
            public static AssemblyDefinition Get(this IIntegrationAccountAssembliesOperations operations, string resourceGroupName, string integrationAccountName, string assemblyArtifactName)
            {
                return operations.GetAsync(resourceGroupName, integrationAccountName, assemblyArtifactName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get an assembly for an integration account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='assemblyArtifactName'>
            /// The assembly artifact name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AssemblyDefinition> GetAsync(this IIntegrationAccountAssembliesOperations operations, string resourceGroupName, string integrationAccountName, string assemblyArtifactName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, integrationAccountName, assemblyArtifactName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update an assembly for an integration account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='assemblyArtifactName'>
            /// The assembly artifact name.
            /// </param>
            /// <param name='assemblyArtifact'>
            /// The assembly artifact.
            /// </param>
            public static AssemblyDefinition CreateOrUpdate(this IIntegrationAccountAssembliesOperations operations, string resourceGroupName, string integrationAccountName, string assemblyArtifactName, AssemblyDefinition assemblyArtifact)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, integrationAccountName, assemblyArtifactName, assemblyArtifact).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update an assembly for an integration account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='assemblyArtifactName'>
            /// The assembly artifact name.
            /// </param>
            /// <param name='assemblyArtifact'>
            /// The assembly artifact.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AssemblyDefinition> CreateOrUpdateAsync(this IIntegrationAccountAssembliesOperations operations, string resourceGroupName, string integrationAccountName, string assemblyArtifactName, AssemblyDefinition assemblyArtifact, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, integrationAccountName, assemblyArtifactName, assemblyArtifact, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an assembly for an integration account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='assemblyArtifactName'>
            /// The assembly artifact name.
            /// </param>
            public static void Delete(this IIntegrationAccountAssembliesOperations operations, string resourceGroupName, string integrationAccountName, string assemblyArtifactName)
            {
                operations.DeleteAsync(resourceGroupName, integrationAccountName, assemblyArtifactName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete an assembly for an integration account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='assemblyArtifactName'>
            /// The assembly artifact name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IIntegrationAccountAssembliesOperations operations, string resourceGroupName, string integrationAccountName, string assemblyArtifactName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, integrationAccountName, assemblyArtifactName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get the content callback url for an integration account assembly.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='assemblyArtifactName'>
            /// The assembly artifact name.
            /// </param>
            public static WorkflowTriggerCallbackUrl ListContentCallbackUrl(this IIntegrationAccountAssembliesOperations operations, string resourceGroupName, string integrationAccountName, string assemblyArtifactName)
            {
                return operations.ListContentCallbackUrlAsync(resourceGroupName, integrationAccountName, assemblyArtifactName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the content callback url for an integration account assembly.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='assemblyArtifactName'>
            /// The assembly artifact name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkflowTriggerCallbackUrl> ListContentCallbackUrlAsync(this IIntegrationAccountAssembliesOperations operations, string resourceGroupName, string integrationAccountName, string assemblyArtifactName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListContentCallbackUrlWithHttpMessagesAsync(resourceGroupName, integrationAccountName, assemblyArtifactName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
