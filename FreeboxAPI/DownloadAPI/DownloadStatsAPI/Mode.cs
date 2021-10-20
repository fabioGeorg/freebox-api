
namespace FreeboxAPI.DownloadAPI.DownloadStatsAPI
{
    /// <summary>
    /// Mode
    /// </summary>
    public enum Mode
    {
        /// <summary>
        /// Force use of normal rate limits (not using the scheduler).
        /// </summary>
        normal,
        /// <summary>
        /// Force use of slow rate limits (not using the scheduler).
        /// </summary>
        slow,
        /// <summary>
        /// Force hibernate (not using the scheduler).
        /// </summary>
        hibernate,
        /// <summary>
        /// Use scheduded rate limit.
        /// </summary>
        schedule
    }
}
