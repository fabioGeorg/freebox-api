using System;

namespace FreeboxAPI.DownloadAPI.DownloadStatsAPI
{
    public class DlThrottlingConfig
    {
        public DlThrottlingConfig() { }
        /// <summary>
        /// Download rate for normal time slot (in B/s).
        /// </summary>
        public DlRate Normal { get; set; }
        /// <summary>
        /// Download rate for normal slow slot (in B/s).
        /// </summary>
        public DlRate Slow { get; set; }
        /// <summary>
        /// The schedule array represent the list of week hours timeslot, starting on monday
        /// at midnight. Therefore the complete week is represented in a array of 168 elements (24 * 7).
        /// </summary>
        public Schedule[] Schedule { get; set; }
    }
}
