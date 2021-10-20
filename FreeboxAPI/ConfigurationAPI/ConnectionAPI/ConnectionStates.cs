
namespace FreeboxAPI.ConfigurationAPI.ConnectionAPI
{
    /// <summary>
    /// ConnectionStates
    /// </summary>
    public enum ConnectionStates
    {
        /// <summary>
        /// Connection is initializing.
        /// </summary>
        going_up,
        /// <summary>
        /// Connection is active.
        /// </summary>
        up,
        /// <summary>
        /// Connection is about to become inactive.
        /// </summary>
        going_down,
        /// <summary>
        /// Connection is inactive.
        /// </summary>
        down
    }
}
