// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SqlPoolTableColumns.
    /// </summary>
    public static partial class SqlPoolTableColumnsExtensions
    {
            /// <summary>
            /// Gets columns in a given table in a SQL pool
            /// </summary>
            /// <remarks>
            /// Gets columns in a given table in a SQL pool.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='schemaName'>
            /// The name of the schema.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='filter'>
            /// An OData filter expression that filters elements in the collection.
            /// </param>
            public static SqlPoolColumnListResult ListByTableName(this ISqlPoolTableColumns operations, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName, string filter = default(string))
            {
                return operations.ListByTableNameAsync(resourceGroupName, workspaceName, sqlPoolName, schemaName, tableName, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets columns in a given table in a SQL pool
            /// </summary>
            /// <remarks>
            /// Gets columns in a given table in a SQL pool.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='schemaName'>
            /// The name of the schema.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='filter'>
            /// An OData filter expression that filters elements in the collection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SqlPoolColumnListResult> ListByTableNameAsync(this ISqlPoolTableColumns operations, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByTableNameWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, schemaName, tableName, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
