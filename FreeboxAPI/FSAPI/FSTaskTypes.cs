
namespace FreeboxAPI.FSAPI
{
    /// <summary>
    /// FSTaskTypes
    /// </summary>
    public enum FSTaskTypes
    {
        /// <summary>
        /// Concatenate multiple files.
        /// </summary>
        cat,
        /// <summary>
        /// Copy files.
        /// </summary>
        cp,
        /// <summary>
        /// Move files.
        /// </summary>
        mv,
        /// <summary>
        /// Remove files.
        /// </summary>
        rm,
        /// <summary>
        /// Creates an archive.
        /// </summary>
        archive,
        /// <summary>
        /// Extract an archive.
        /// </summary>
        extract,
        /// <summary>
        /// Check and repair files.
        /// </summary>
        repair
    }
}
