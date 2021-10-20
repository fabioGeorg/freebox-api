
namespace FreeboxAPI.DownloadAPI.DownloadStatsAPI
{
    public enum Status
    {
        /// <summary>
        /// Config has not been checked yet.
        /// </summary>
        not_checked,
        /// <summary>
        /// Test in progress.
        /// </summary>
        checking,
        /// <summary>
        /// Config is invalid, see error.
        /// </summary>
        error,
        /// <summary>
        /// Config is ok.
        /// </summary>
        ok
    }
}
