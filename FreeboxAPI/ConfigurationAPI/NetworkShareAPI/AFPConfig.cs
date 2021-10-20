
namespace FreeboxAPI.ConfigurationAPI.NetworkShareAPI
{
    /// <summary>
    /// AFPConfig
    /// </summary>
    public class AFPConfig
    {
        /// <summary>
        /// Is AFP service enabled.
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// /Allow guest to access shared files.
        /// </summary>
        public bool GuestAllow { get; set; }
        /// <summary>
        /// AFP server type (to display proper icon) in MacOS.
        /// </summary>
        /// <see cref="AFPServerType"/>
        public AFPServerType ServerType { get; set; }
        /// <summary>
        /// AFP user name.
        /// </summary>
        public string LoginName { get; set; }
        /// <summary>
        /// AFP user password.
        /// </summary>
        public string LoginPassword { protected get; set; }
    }
}
