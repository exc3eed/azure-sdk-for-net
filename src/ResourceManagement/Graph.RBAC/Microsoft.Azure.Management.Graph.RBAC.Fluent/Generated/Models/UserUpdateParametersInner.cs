// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Graph.RBAC.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Graph;
    using Microsoft.Azure.Management.Graph.RBAC;
    using Microsoft.Azure.Management.Graph.RBAC.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Request parameters for updating an existing work or school account
    /// user.
    /// </summary>
    public partial class UserUpdateParametersInner
    {
        /// <summary>
        /// Initializes a new instance of the UserUpdateParametersInner class.
        /// </summary>
        public UserUpdateParametersInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserUpdateParametersInner class.
        /// </summary>
        /// <param name="accountEnabled">Whether the account is
        /// enabled.</param>
        /// <param name="displayName">The display name of the user.</param>
        /// <param name="passwordProfile">The password profile of the
        /// user.</param>
        /// <param name="mailNickname">The mail alias for the user.</param>
        public UserUpdateParametersInner(bool? accountEnabled = default(bool?), string displayName = default(string), PasswordProfile passwordProfile = default(PasswordProfile), string mailNickname = default(string))
        {
            AccountEnabled = accountEnabled;
            DisplayName = displayName;
            PasswordProfile = passwordProfile;
            MailNickname = mailNickname;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets whether the account is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "accountEnabled")]
        public bool? AccountEnabled { get; set; }

        /// <summary>
        /// Gets or sets the display name of the user.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the password profile of the user.
        /// </summary>
        [JsonProperty(PropertyName = "passwordProfile")]
        public PasswordProfile PasswordProfile { get; set; }

        /// <summary>
        /// Gets or sets the mail alias for the user.
        /// </summary>
        [JsonProperty(PropertyName = "mailNickname")]
        public string MailNickname { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PasswordProfile != null)
            {
                PasswordProfile.Validate();
            }
        }
    }
}