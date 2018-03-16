// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ManagementGroups.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// (Optional) The ID of the parent management group.
    /// </summary>
    public partial class ParentGroupInfo
    {
        /// <summary>
        /// Initializes a new instance of the ParentGroupInfo class.
        /// </summary>
        public ParentGroupInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ParentGroupInfo class.
        /// </summary>
        /// <param name="parentId">The fully qualified ID for the parent
        /// management group.  For example,
        /// /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000</param>
        /// <param name="displayName">The friendly name of the parent
        /// management group.</param>
        public ParentGroupInfo(string parentId = default(string), string displayName = default(string))
        {
            ParentId = parentId;
            DisplayName = displayName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the fully qualified ID for the parent management
        /// group.  For example,
        /// /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000
        /// </summary>
        [JsonProperty(PropertyName = "parentId")]
        public string ParentId { get; set; }

        /// <summary>
        /// Gets or sets the friendly name of the parent management group.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

    }
}