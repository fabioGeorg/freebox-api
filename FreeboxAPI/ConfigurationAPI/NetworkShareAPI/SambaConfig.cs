
namespace FreeboxAPI.ConfigurationAPI.NetworkShareAPI
{
    /// <summary>
    /// SambaConfig
    /// </summary>
    public class SambaConfig
    {
        /// <summary>
        /// Is file sharing enabled.
        /// </summary>
        public bool FileShareEnabled { get; set; }
        /// <summary>
        /// Is printer sharing enabled.
        /// </summary>
        public bool PrintShareEnabled { get; set; }
        /// <summary>
        /// Is login/password required to access shares.
        /// </summary>
        public bool LogonEnabled { get; set; }
        /// <summary>
        /// Samba user name.
        /// </summary>
        public string LogonUser { get; set; }
        /// <summary>
        /// Samba user password.
        /// </summary>
        public string LogonPassword { protected get; set; }
        /// <summary>
        /// Name of the workgroup.
        /// </summary>
        public string Workgroup { get; set; }
    }
}
