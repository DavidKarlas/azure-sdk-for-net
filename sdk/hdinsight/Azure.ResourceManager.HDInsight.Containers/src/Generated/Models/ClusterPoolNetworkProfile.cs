// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Cluster pool networking configuration. </summary>
    internal partial class ClusterPoolNetworkProfile
    {
        /// <summary> Initializes a new instance of ClusterPoolNetworkProfile. </summary>
        /// <param name="subnetId"> Cluster pool subnet resource id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetId"/> is null. </exception>
        public ClusterPoolNetworkProfile(ResourceIdentifier subnetId)
        {
            Argument.AssertNotNull(subnetId, nameof(subnetId));

            SubnetId = subnetId;
        }

        /// <summary> Cluster pool subnet resource id. </summary>
        public ResourceIdentifier SubnetId { get; set; }
    }
}
