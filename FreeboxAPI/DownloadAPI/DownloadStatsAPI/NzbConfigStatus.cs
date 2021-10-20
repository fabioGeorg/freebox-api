using System;

namespace FreeboxAPI.DownloadAPI.DownloadStatsAPI
{
    /// <summary>
    /// NzbConfigStatus
    /// </summary>
    public class NzbConfigStatus
    {
        /// <summary>
        /// Empty constructor.
        /// </summary>
        public NzbConfigStatus() { }
        /// <summary>
        /// Status
        /// </summary>
        public Status Status { get; protected set; }
        /// <summary>
        /// Error
        /// </summary>
        public Errors Error { get; protected set; }
    }
}
