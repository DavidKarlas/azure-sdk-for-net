// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> An access policy entry. </summary>
    public partial class HealthcareApisServiceAccessPolicyEntry
    {
        /// <summary> Initializes a new instance of HealthcareApisServiceAccessPolicyEntry. </summary>
        /// <param name="objectId"> An Azure AD object ID (User or Apps) that is allowed access to the FHIR service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="objectId"/> is null. </exception>
        public HealthcareApisServiceAccessPolicyEntry(string objectId)
        {
            Argument.AssertNotNull(objectId, nameof(objectId));

            ObjectId = objectId;
        }

        /// <summary> An Azure AD object ID (User or Apps) that is allowed access to the FHIR service. </summary>
        public string ObjectId { get; set; }
    }
}
