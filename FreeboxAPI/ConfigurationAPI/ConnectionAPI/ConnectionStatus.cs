
namespace FreeboxAPI.ConfigurationAPI.ConnectionAPI
{
    /// <summary>
    /// ConnectionStatus
    /// </summary>
    public class ConnectionStatus
    {
        /// <summary>
        /// ConnectionState
        /// </summary>
        public ConnectionStates ConnectionState { get; protected set; }
        /// <summary>
        /// ConnectionType
        /// </summary>
        public ConnectionTypes ConnectionType { get; protected set; }
        /// <summary>
        /// MediaType
        /// </summary>
        public Media Media { get; protected set; }
        /// <summary>
        /// Freebox IPv4 address.       
        /// </summary>
        /// <remarks>
        /// This field is only available when connection state is up.
        /// </remarks>
        public string IPv4 { get; protected set; }
        /// <summary>
        /// Freebox IPv6.
        /// </summary>
        /// <remarks>
        /// This field is only available when connection state is up.
        /// </remarks>
        public string IPv6 { get; protected set; }
        /// <summary>
        /// Current upload rate in byte/s.
        /// </summary>
        public int RateUp { get; protected set; }
        /// <summary>
        /// Current download rate in byte/s.
        /// </summary>
        public int RateDown { get; protected set; }
        /// <summary>
        /// Available upload bandwidth in bit/s.
        /// </summary>
        public int BandwidthUp { get; protected set; }
        /// <summary>
        /// Available download bandwidth in bit/s.
        /// </summary>
        public int BandwidthDown { get; protected set; }
        /// <summary>
        /// Total uploaded bytes since last connection.
        /// </summary>
        public int BytesUp { get; protected set; }
        /// <summary>
        /// Total downloaded bytes since last connection.
        /// </summary>
        public int BytesDown { get; protected set; }
        /// <summary>
        /// Some customers share the same IPv4 and each customer is then assigned a port range.
        /// The first value is the first port of the assigned range and the second value is the
        /// last port (inclusive).
        /// All PortForwardingConfig must use ports in this range to be effective.
        /// </summary>        
        public int[] IPv4PortRange { get; protected set; }
    }
}
