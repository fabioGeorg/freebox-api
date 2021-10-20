
namespace FreeboxAPI.AirMediaAPI
{
    /// <summary>
    /// AirMediaConfig
    /// </summary>
    public class AirMediaConfig
    {
        /// <summary>
        /// Empty constructor.
        /// </summary>
        public AirMediaConfig() { }
        /// <summary>
        /// Parameters constructor.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="password"></param>
        public AirMediaConfig(bool enabled, string password)
        {
            Enabled = enabled;
            Password = password;
        }

        /// <summary>
        /// Enable/Disable the airmedia server.
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// If not empty, the client will have to enter a password to be able to use this airmedia server.
        /// </summary>
        public string Password { protected get; set; }
    }
}
