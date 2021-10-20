
namespace FreeboxAPI.ConfigurationAPI.ConnectionAPI
{
    /// <summary>
    /// ConnectionConfiguration
    /// </summary>
    public class ConnectionConfiguration
    {
        /// <summary>
        /// Should the Freebox respond to external ping requests.
        /// </summary>
        public bool Ping { get; set; }
        /// <summary>
        /// Is the admin password secure enough to enable remote access.
        /// </summary>
        public bool IsSecurePass { get; protected set; }
        /// <summary>
        /// Enable/disable HTTP remote access.
        /// </summary>
        public bool RemoteAccess { get; set; }
        /// <summary>
        /// Port number to use for remote HTTP access.
        /// </summary>
        public int RemoteAccessPort { get; set; }
        /// <summary>
        /// This field indicate the minimum possible value for RemoteAccessPort.
        /// </summary>
        /// <see cref="ConnectionStatus"/> IPv4PortRange.
        public int RemoteAccessMinPort { get; protected set; }
        /// <summary>
        /// This field indicate the maximum possible value for RemoteAccessPort.
        /// </summary>
        /// <see cref="ConnectionStatus"/> IPv4PortRange.
        public int RemoteAccessMaxPort { get; protected set; }
        /// <summary>
        /// IPv4 to use for remote access (can be missing if connection is down).
        /// </summary>
        public string RemoteAccessIP { get; protected set; }
        /// <summary>
        /// Is remote access enabled for apps, or share link.
        /// </summary>
        public bool APIRemoteAccess { get; protected set; }
        /// <summary>
        /// Enable/Disable Wake-on-lan proxy.
        /// </summary>
        public bool WOL { get; set; }
        /// <summary>
        /// Is ads blocking feature enabled.
        /// </summary>
        public bool Adblock { get; set; }
        /// <summary>
        /// If set tot true adblock setting has never been set by the user.
        /// </summary>
        public bool AdblockNotSet { get; protected set; }
        /// <summary>
        /// If false, user has disabled new token request. New apps can't request a new token.
        /// Apps that already have a token are still allowed.
        /// </summary>
        public bool AllowTokenRequest { get; set; }
    }
}
