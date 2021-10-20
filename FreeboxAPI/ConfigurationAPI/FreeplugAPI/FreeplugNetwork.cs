
namespace FreeboxAPI.ConfigurationAPI.FreeplugAPI
{
    /// <summary>
    /// FreeplugNetwork
    /// </summary>
    public class FreeplugNetwork
    {
        /// <summary>
        /// Network unique ID.
        /// </summary>
        public string ID { get; protected set; }
        /// <summary>
        /// List of freeplugs member of this network.
        /// </summary>
        public Freeplug[] Members { get; protected set; }
    }
}
