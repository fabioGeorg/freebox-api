
namespace FreeboxAPI.ConfigurationAPI.FreeplugAPI
{
    /// <summary>
    /// Freeplug
    /// </summary>
    public class Freeplug
    {
        /// <summary>
        /// Freeplug unique ID.
        /// </summary>
        public string ID { get; protected set; }
        /// <summary>
        /// If true the Freeplug is connected directly to the Freebox.
        /// </summary>
        public bool Local { get; protected set; }
        /// <summary>
        /// Freeplug network role.
        /// </summary>
        public NetRoles NetRole { get; protected set; }
        /// <summary>
        /// Freebox Server netbios name.
        /// </summary>
        public string Model { get; protected set; }
        public EthernetPortStatus EthernetPortStatus { get; protected set; }
        /// <summary>
        /// Ethernet link is full duplex.
        /// </summary>
        public bool EthernetFullDuplex { get; protected set; }
        /// <summary>
        /// Is connected to the network.
        /// </summary>
        public bool HasNetwork { get; protected set; }
        /// <summary>
        /// Ethernet port speed.
        /// </summary>
        public int EthernetSpeed { get; protected set; }
        /// <summary>
        /// Seconds since last activity.
        /// </summary>
        public int Inactive { get; protected set; }
        /// <summary>
        /// Network ID.
        /// </summary>
        public string NetworkID { get; protected set; }
        /// <summary>
        /// RX rate (from the freeplugs to the 'cco' freeplug) (in Mb/s), -1 if not available.
        /// </summary>
        public int RXRate { get; protected set; }
        /// <summary>
        /// TX rate (from the 'cco' freeplug to the freeplugs) (in Mb/s), -1 if not available.
        /// </summary>
        public int TXRate { get; protected set; }
    }
}
