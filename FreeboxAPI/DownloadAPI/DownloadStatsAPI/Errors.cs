
namespace FreeboxAPI.DownloadAPI.DownloadStatsAPI
{
    /// <summary>
    /// Errors
    /// </summary>
    public enum Errors
    {
        /// <summary>
        /// Test is ok.
        /// </summary>
        none,
        /// <summary>
        /// Authentication is required.
        /// </summary>
        nzb_authentication_required,
        /// <summary>
        /// Incorrect credentials.
        /// </summary>
        bad_authentication,
        /// <summary>
        /// Unable to connect to NNTP server.
        /// </summary>
        connection_refused
    }
}
