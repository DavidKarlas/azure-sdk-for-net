// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.CosmosDBForPostgreSql.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDBForPostgreSql
{
    /// <summary>
    /// A class representing the CosmosDBForPostgreSqlFirewallRule data model.
    /// Represents a cluster firewall rule.
    /// </summary>
    public partial class CosmosDBForPostgreSqlFirewallRuleData : ResourceData
    {
        /// <summary> Initializes a new instance of CosmosDBForPostgreSqlFirewallRuleData. </summary>
        /// <param name="startIPAddress"> The start IP address of the cluster firewall rule. Must be IPv4 format. </param>
        /// <param name="endIPAddress"> The end IP address of the cluster firewall rule. Must be IPv4 format. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="startIPAddress"/> or <paramref name="endIPAddress"/> is null. </exception>
        public CosmosDBForPostgreSqlFirewallRuleData(IPAddress startIPAddress, IPAddress endIPAddress)
        {
            Argument.AssertNotNull(startIPAddress, nameof(startIPAddress));
            Argument.AssertNotNull(endIPAddress, nameof(endIPAddress));

            StartIPAddress = startIPAddress;
            EndIPAddress = endIPAddress;
        }

        /// <summary> Initializes a new instance of CosmosDBForPostgreSqlFirewallRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="startIPAddress"> The start IP address of the cluster firewall rule. Must be IPv4 format. </param>
        /// <param name="endIPAddress"> The end IP address of the cluster firewall rule. Must be IPv4 format. </param>
        /// <param name="provisioningState"> Provisioning state of the firewall rule. </param>
        internal CosmosDBForPostgreSqlFirewallRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IPAddress startIPAddress, IPAddress endIPAddress, CosmosDBForPostgreSqlProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            StartIPAddress = startIPAddress;
            EndIPAddress = endIPAddress;
            ProvisioningState = provisioningState;
        }

        /// <summary> The start IP address of the cluster firewall rule. Must be IPv4 format. </summary>
        public IPAddress StartIPAddress { get; set; }
        /// <summary> The end IP address of the cluster firewall rule. Must be IPv4 format. </summary>
        public IPAddress EndIPAddress { get; set; }
        /// <summary> Provisioning state of the firewall rule. </summary>
        public CosmosDBForPostgreSqlProvisioningState? ProvisioningState { get; }
    }
}
