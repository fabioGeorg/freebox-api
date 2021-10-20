
namespace FreeboxAPI.DownloadAPI
{
    public enum DownloadStatus
    {
        /// <summary>
        /// Task is stopped, can be resumed by setting the status to downloading.
        /// </summary>
        stopped,
        /// <summary>
        /// Task will start when a new download slot is available the queue
        /// position is stored in QueuePos attribute.
        /// </summary>
        queued,
        /// <summary>
        /// Task is preparing to start download.
        /// </summary>
        starting,
        downloading,
        /// <summary>
        /// Task is gracefully stopping.
        /// </summary>
        stopping,
        /// <summary>
        /// There was a problem with the download, you can get an error code
        /// in the error field.
        /// </summary>
        error,
        /// <summary>
        /// The download is over. For bt you can resume seeding setting the status
        /// to seeding if the ratio is not reached yet.
        /// </summary>
        done,
        /// <summary>
        /// (only valid for nzb) download is over, the downloaded files are being checked using par2.
        /// </summary>
        checking,
        /// <summary>
        /// (only valid for nzb) download is over, the downloaded files are being repaired using par2.
        /// </summary>
        repairing,
        /// <summary>
        /// (only valid for nzb) download is over, the downloaded files are being extracted.
        /// </summary>
        extracting,
        /// <summary>
        /// (only valid for bt) download is over, the content is changed to being shared to other users.
        /// The task will automatically stop once the seed ratio has been reached.
        /// </summary>
        seeding,
        /// <summary>
        /// You can set a task status to 'retry' to restart the download task.
        /// </summary>
        retry
    }
}
