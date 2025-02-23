// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> A list of sensitivity label update operations. </summary>
    public partial class SynapseSensitivityLabelUpdateListResult
    {
        /// <summary> Initializes a new instance of SynapseSensitivityLabelUpdateListResult. </summary>
        public SynapseSensitivityLabelUpdateListResult()
        {
            Operations = new ChangeTrackingList<SynapseSensitivityLabelUpdate>();
        }

        /// <summary> Gets the operations. </summary>
        public IList<SynapseSensitivityLabelUpdate> Operations { get; }
    }
}
