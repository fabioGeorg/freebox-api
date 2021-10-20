
namespace FreeboxAPI.FSAPI
{
    /// <summary>
    /// ConflictModes
    /// </summary>
    public enum ConflictModes
    {
        /// <summary>
        /// Overwrite the destination file.
        /// </summary>
        overwrite,
        /// <summary>
        /// Keep both files (rename the file adding a suffix).
        /// </summary>
        both,
        /// <summary>
        /// Only overwrite if newer than destination file.
        /// </summary>
        recent,
        /// <summary>
        /// Keep the destination file.
        /// </summary>
        skip
    }
}
