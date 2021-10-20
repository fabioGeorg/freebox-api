
namespace FreeboxAPI.DownloadAPI
{
    /// <summary>
    /// DownloadErrors
    /// </summary>
    public enum DownloadErrors
    {
        /// <summary>
        /// No task was found with the given id.
        /// </summary>
        task_not_found,
        /// <summary>
        /// Attempt to perform an invalid operation.
        /// </summary>
        invalid_operation,
        /// <summary>
        /// Error with the download file (invalid format?).
        /// </summary>
        invalid_file,
        /// <summary>
        /// URL is invalid.
        /// </summary>
        invalid_url,
        /// <summary>
        /// Method not implemented.
        /// </summary>
        not_implemented,
        /// <summary>
        /// No more memory available to perform the requested action.
        /// </summary>
        out_of_memory,
        /// <summary>
        /// The task type is invalid.
        /// </summary>
        invalid_task_type,
        /// <summary>
        /// The downloader is hibernating.
        /// </summary>
        hibernating,
        /// <summary>
        /// This action is only valid for Bittorrent task in stopped or done state.
        /// </summary>
        need_bt_stopped_done,
        /// <summary>
        /// Attempt to access an invalid tracker object.
        /// </summary>
        bt_tracker_not_found,
        /// <summary>
        /// Too many tasks.
        /// </summary>
        too_many_tasks,
        /// <summary>
        /// Invalid peer address.
        /// </summary>
        invalid_address,
        /// <summary>
        /// Port conflict when setting config.
        /// </summary>
        port_conflict,
        /// <summary>
        /// Invalid priority.
        /// </summary>
        invalid_priority,
        /// <summary>
        /// Internal error.
        /// </summary>
        internal_error,
        /// <summary>
        /// Failed to initialize task context file (need to check disk).
        /// </summary>
        ctx_file_error,
        /// <summary>
        /// Same task already exists.
        /// </summary>
        exists,
        /// <summary>
        /// Incoming port is not available for this customer
        /// </summary>
        /// <see cref="ConfigurationAPI.ConnectionAPI.ConnectionStatus"/>
        port_outside_range
    }
}
