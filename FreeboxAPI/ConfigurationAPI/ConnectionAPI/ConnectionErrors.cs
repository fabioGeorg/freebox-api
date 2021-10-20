
namespace FreeboxAPI.ConfigurationAPI.ConnectionAPI
{
    /// <summary>
    /// ConnectionErrors
    /// </summary>
    public enum ConnectionErrors
    {
        /// <summary>
        /// Invalid request.
        /// </summary>
        inval,
        /// <summary>
        /// No device found with this name.
        /// </summary>
        nodev,
        /// <summary>
        /// No entity found with this name.
        /// </summary>
        noent,
        /// <summary>
        /// Network is down.
        /// </summary>
        netdown,
        /// <summary>
        /// Device is busy.
        /// </summary>
        busy,
        /// <summary>
        /// Invalid port.
        /// </summary>
        invalid_port,
        /// <summary>
        /// The password is too weak to enable remote access.
        /// </summary>
        insecure_password,
        /// <summary>
        /// Invalid ddns provider name.
        /// </summary>
        invalid_provider,
        /// <summary>
        /// Invalid next hop address (should be a link local address).
        /// </summary>
        invalid_next_hop
    }
}
