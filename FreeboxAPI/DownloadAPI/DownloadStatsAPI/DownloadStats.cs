using System;
using Newtonsoft.Json.Linq;

namespace FreeboxAPI.DownloadAPI.DownloadStatsAPI
{
    /// <summary>
    /// DownloadStats
    /// </summary>
    public class DownloadStats
    {
        /// <summary>
        /// NbTasks
        /// </summary>
        public int NbTasks { get; protected set; }
        /// <summary>
        /// NbTasksStopped
        /// </summary>
        public int NbTasksStopped { get; protected set; }
        /// <summary>
        /// NbTasksChecking
        /// </summary>
        public int NbTasksChecking { get; protected set; }
        /// <summary>
        /// NbTasksQueued
        /// </summary>
        public int NbTasksQueued { get; protected set; }
        /// <summary>
        /// NbTasksExtracting
        /// </summary>
        public int NbTasksExtracting { get; protected set; }
        /// <summary>
        /// NbTasksDone
        /// </summary>
        public int NbTasksDone { get; protected set; }
        /// <summary>
        /// NbTasksRepairing
        /// </summary>
        public int NbTasksRepairing { get; protected set; }
        /// <summary>
        /// NbTasksSeeding
        /// </summary>
        public int NbTasksSeeding { get; protected set; }
        /// <summary>
        /// NbTasksDownloading
        /// </summary>
        public int NbTasksDownloading { get; protected set; }
        /// <summary>
        /// NbTasksError
        /// </summary>
        public int NbTasksError { get; protected set; }
        /// <summary>
        /// NbTasksStopping
        /// </summary>
        public int NbTasksStopping { get; protected set; }
        /// <summary>
        /// NbTaksActive
        /// </summary>
        public int NbTasksActive { get; protected set; }
        /// <summary>
        /// NbRSS
        /// </summary>
        public int NbRss { get; protected set; }
        /// <summary>
        /// NbRSSItemsUnread
        /// </summary>
        public int NbRssItemsUnread { get; protected set; }
        /// <summary>
        /// RXRate
        /// </summary>
        public int RXRate { get; protected set; }
        /// <summary>
        /// TXRate
        /// </summary>
        public int TXRate { get; protected set; }
        /// <summary>
        /// ThrottlingMode
        /// </summary>
        public Mode ThrottlingMode { get; protected set; }
        /// <summary>
        /// IsThrottlingScheduled
        /// </summary>
        public bool IsThrottlingScheduled { get; protected set; }
        /// <summary>
        /// ThrottlingRate
        /// </summary>
        public JObject ThrottlingRate { get; protected set; }
        /// <summary>
        /// NzbConfigStatus
        /// </summary>
        public JObject NzbConfigStatus { get; protected set; }
        /// <summary>
        /// ConnectionReady
        /// </summary>
        public bool ConnectionReady { get; protected set; }
        /// <summary>
        /// NbPeer
        /// </summary>
        public int NbPeer { get; protected set; }
        /// <summary>
        /// BlocklistEntries
        /// </summary>
        public int BlocklistEntries { get; protected set; }
        /// <summary>
        /// BlocklistHits
        /// </summary>
        public int BlocklistHits { get; protected set; }
        /// <summary>
        /// DhtStats
        /// </summary>
        public JObject DhtStats { get; protected set; }
    }
}
