
namespace FreeboxAPI.FSAPI
{
    /// <summary>
    /// FSTaskStates
    /// </summary>
    public enum FSTaskStates
    {
        /// <summary>
        /// Queued (only one task is active at a given time).
        /// </summary>
        queued,
        /// <summary>
        /// Running.
        /// </summary>
        running,
        /// <summary>
        /// Pause (user suspended).
        /// </summary>
        paused,
        /// <summary>
        /// Done.
        /// </summary>
        done,
        /// <summary>
        /// Failed (see error).
        /// </summary>
        failed
    }
}
