using System;

namespace FreeboxAPI.DownloadAPI.DownloadStatsAPI
{
    public class DhtStats
    {
        public DhtStats() { }
        /// <summary>
        /// Is the dht enabled.
        /// </summary>
        public bool Enabled { get; protected set; }
        /// <summary>
        /// Number of active nodes.
        /// </summary>
        public int NodeCount { get; protected set; }
        /// <summary>
        /// Is the dht enabled on IPv6
        /// </summary>
        public bool EnabledIPv6 { get; protected set; }
        /// <summary>
        /// Number of active nodes on IPv6.
        /// </summary>
        public int NodeCountIPv6 { get; protected set; }
    }
}
