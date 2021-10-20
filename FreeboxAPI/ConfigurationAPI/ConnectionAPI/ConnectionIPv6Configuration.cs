
namespace FreeboxAPI.ConfigurationAPI.ConnectionAPI
{
    /// <summary>
    /// ConnectionIPv6Configuration
    /// </summary>
    public class ConnectionIPv6Configuration
    {
        /// <summary>
        /// Is IPv6 enabled.
        /// </summary>
        public bool IPv6Enabled { get; set; }
        /// <summary>
        /// Freebox IPv6 link local address.
        /// </summary>
        public string IPv6ll { get; protected set; }
        /// <summary>
        /// List of IPv6 delegations (List length: 8)
        /// </summary>
        public ConnetionIPv6Delegation[] Delegations { get; set; }
    }
}
