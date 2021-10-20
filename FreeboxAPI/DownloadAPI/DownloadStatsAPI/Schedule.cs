
namespace FreeboxAPI.DownloadAPI.DownloadStatsAPI
{
    public enum Schedule
    {
        /// <summary>
        /// Downloads will use normal DlRate config for this timeslot.
        /// </summary>
        normal,
        /// <summary>
        /// Downloads will use slow DlRate config for this timeslot.
        /// </summary>
        slow,
        /// <summary>
        /// Downloads will be paused for this timeslot.
        /// </summary>
        hibernate
    }
}
