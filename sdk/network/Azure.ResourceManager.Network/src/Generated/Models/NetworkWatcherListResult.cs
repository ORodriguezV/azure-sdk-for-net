// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListNetworkWatchers API service call. </summary>
    public partial class NetworkWatcherListResult
    {
        /// <summary> Initializes a new instance of NetworkWatcherListResult. </summary>
        internal NetworkWatcherListResult()
        {
        }

        /// <summary> Initializes a new instance of NetworkWatcherListResult. </summary>
        /// <param name="value"> List of network watcher resources. </param>
        internal NetworkWatcherListResult(IReadOnlyList<NetworkWatcher> value)
        {
            Value = value;
        }

        /// <summary> List of network watcher resources. </summary>
        public IReadOnlyList<NetworkWatcher> Value { get; }
    }
}