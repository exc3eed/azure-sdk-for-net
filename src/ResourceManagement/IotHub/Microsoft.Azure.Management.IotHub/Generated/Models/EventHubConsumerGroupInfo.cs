// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.IotHub.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The properties indicating the EventHubConsumerGroupInfo.
    /// </summary>
    public partial class EventHubConsumerGroupInfo
    {
        /// <summary>
        /// Initializes a new instance of the EventHubConsumerGroupInfo class.
        /// </summary>
        public EventHubConsumerGroupInfo() { }

        /// <summary>
        /// Initializes a new instance of the EventHubConsumerGroupInfo class.
        /// </summary>
        public EventHubConsumerGroupInfo(IDictionary<string, string> tags = default(IDictionary<string, string>), string id = default(string), string name = default(string))
        {
            Tags = tags;
            Id = id;
            Name = name;
        }

        /// <summary>
        /// The tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// The event hub consumer group identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The event hub consumer group name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}