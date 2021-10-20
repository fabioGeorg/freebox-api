
namespace FreeboxAPI.ConfigurationAPI.ConnectionAPI
{
    /// <summary>
    /// DDNSConfig
    /// </summary>
    public class DDNSConfig
    {
        public bool Enabled { get; set; }
        /// <summary>
        /// DNS name to use to register.
        /// </summary>
        public string Hostname { get; set; }
        /// <summary>
        /// Username to use to register.
        /// </summary>
        public string User { get; set; }
        /// <summary>
        /// Password to use to register.
        /// </summary>
        public string Password { protected get; set; }
    }
}
