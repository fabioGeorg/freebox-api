
namespace FreeboxAPI.ConfigurationAPI.ConnectionAPI
{
    /// <summary>
    /// ConnectionIPv6Delegation
    /// </summary>
    public class ConnetionIPv6Delegation
    {
        /// <summary>
        /// IPv6 prefix.
        /// </summary>
        public string Prefix { get; set; }
        /// <summary>
        /// The next hop for the prefix.
        /// </summary>
        public long NextHop { get; set; }
    }
}
