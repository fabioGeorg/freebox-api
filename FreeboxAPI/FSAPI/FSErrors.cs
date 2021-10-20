
namespace FreeboxAPI.FSAPI
{
    /// <summary>
    /// FSErrors
    /// </summary>
    public enum FSErrors
    {
        /// <summary>
        /// Invalid object ID.
        /// </summary>
        invalid_id,
        /// <summary>
        /// File or folder not found.
        /// </summary>
        path_not_found,
        /// <summary>
        /// Internal error.
        /// </summary>
        internal_error,
        /// <summary>
        /// The disk is not mounted.
        /// </summary>
        disk_unavailable,
        /// <summary>
        /// Invalid request.
        /// </summary>
        invalid_request,
        /// <summary>
        /// The conflict mode specified is invalid (see below).
        /// </summary>
        invalid_conflict_mode,
        /// <summary>
        /// Internal error.
        /// </summary>
        exec_failed,
        /// <summary>
        /// Out of memory.
        /// </summary>
        out_of_memory,
        /// <summary>
        /// Invalid task ID.
        /// </summary>
        task_not_found,
        /// <summary>
        /// You tried to set an invalid state.
        /// </summary>
        invalid_state,
        /// <summary>
        /// This operation cannot be performed on this task.
        /// </summary>
        invalid_task_type,
        /// <summary>
        /// The destination file/folder already exists.
        /// </summary>
        destination_conflict,
        /// <summary>
        /// Access to this file is denied.
        /// </summary>
        access_denied,
        /// <summary>
        /// The destination disk is full.
        /// </summary>
        disk_full
    }
}
