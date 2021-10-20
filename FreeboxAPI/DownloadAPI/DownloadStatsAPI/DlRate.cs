using System;

namespace FreeboxAPI.DownloadAPI.DownloadStatsAPI
{
    /// <summary>
    /// DlRate
    /// </summary>
    public class DlRate
    {
        /// <summary>
        /// Empty constructor.
        /// </summary>
        public DlRate() { }
        /// <summary>
        /// TXRate
        /// </summary>
        public int TXRate { get; set; }        
        //RXRate
        public int RXRate { get; set; }
    }
}
