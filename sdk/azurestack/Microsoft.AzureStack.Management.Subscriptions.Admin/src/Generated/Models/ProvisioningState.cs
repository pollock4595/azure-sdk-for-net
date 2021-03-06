// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Subscriptions.Admin.Models
{

    /// <summary>
    /// Defines values for ProvisioningState.
    /// </summary>
    public static class ProvisioningState
    {
        /// <summary>
        /// The provisioning state is not specified.
        /// </summary>
        public const string NotSpecified = "NotSpecified";
        /// <summary>
        /// The provisioning state is accepted, and indicates provisioning is
        /// ongoing.
        /// </summary>
        public const string Accepted = "Accepted";
        /// <summary>
        /// The provisioning state is failed, and indicates the data is
        /// potentially out-of-sync with third parties.
        /// </summary>
        public const string Failed = "Failed";
        /// <summary>
        /// The provisioning state is succeeded, and indicates the data is
        /// in-sync with third-parties.
        /// </summary>
        public const string Succeeded = "Succeeded";
    }
}
