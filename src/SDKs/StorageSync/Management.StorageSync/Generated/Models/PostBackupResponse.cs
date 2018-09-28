// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Post Backup Response
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PostBackupResponse
    {
        /// <summary>
        /// Initializes a new instance of the PostBackupResponse class.
        /// </summary>
        public PostBackupResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PostBackupResponse class.
        /// </summary>
        /// <param name="cloudEndpointName">cloud endpoint Name.</param>
        public PostBackupResponse(string cloudEndpointName = default(string))
        {
            CloudEndpointName = cloudEndpointName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets cloud endpoint Name.
        /// </summary>
        [JsonProperty(PropertyName = "backupMetadata.cloudEndpointName")]
        public string CloudEndpointName { get; private set; }

    }
}