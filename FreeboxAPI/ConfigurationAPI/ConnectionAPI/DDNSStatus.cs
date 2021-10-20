
namespace FreeboxAPI.ConfigurationAPI.ConnectionAPI
{
    /// <summary>
    /// DDNSStatus
    /// </summary>
    public class DDNSStatus
    {
        /// <summary>
        /// Status
        /// </summary>
        public DynDnsProviderStatus Status { get; set; }
        /// <summary>
        /// Next refresh timestamp.
        /// </summary>
        public int NextRefresh { get; set; }
        /// <summary>
        /// Last refresh timestamp.
        /// </summary>
        public int LastRefresh { get; set; }
        /// <summary>
        /// Next retry timestamp.
        /// </summary>
        public int NextRetry { get; set; }
        /// <summary>
        /// Last error timestamp.
        /// </summary>
        public int LastError { get; set; }
    }
}
