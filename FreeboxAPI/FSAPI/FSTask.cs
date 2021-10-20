
namespace FreeboxAPI.FSAPI
{
    /// <summary>
    /// FSTask
    /// </summary>
    public class FSTask
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; protected set; }
        /// <summary>
        /// TaskType
        /// </summary>
        public FSTaskTypes FSTaskType { get; protected set; }
        /// <summary>
        /// TaskState
        /// </summary>
        public FSTaskStates FSTaskState { get; protected set; }
        /// <summary>
        /// Error
        /// </summary>
        public FSErrorsPlus Error { get; protected set; }
        /// <summary>
        /// CreatedTS
        /// </summary>
        public int CreatedTS { get; protected set; }
        /// <summary>
        /// StartedTS
        /// </summary>
        public int StartedTS { get; protected set; }
        /// <summary>
        /// DoneTS
        /// </summary>
        public int DoneTS { get; protected set; }
        /// <summary>
        /// Task duration in seconds.
        /// </summary>
        public int Duration { get; protected set; }
        /// <summary>
        /// Task progress in percent (scaled by 100).
        /// </summary>
        public int Progress { get; protected set; }
        /// <summary>
        /// Estimated time remaining before the task completion (in seconds).
        /// </summary>
        public int ETA { get; protected set; }
        /// <summary>
        /// Current source file (if available).
        /// </summary>
        public string From { get; protected set; }
        /// <summary>
        /// Current destination file (if available).
        /// </summary>
        public string To { get; protected set; }
        /// <summary>
        /// Number of files to process.
        /// </summary>
        public int NbFiles { get; protected set; }
        /// <summary>
        /// Number of files processed.
        /// </summary>
        public int NbFilesDone { get; protected set; }
        /// <summary>
        /// Total bytes to process.
        /// </summary>
        public int TotalBytes { get; protected set; }
        /// <summary>
        /// Number of bytes processed.
        /// </summary>
        public int TotalBytesDone { get; protected set; }
        /// <summary>
        /// Size of the file currently processed.
        /// </summary>
        public int CurrentBytes { get; protected set; }
        /// <summary>
        /// Number of bytes processed for the current file.
        /// </summary>
        public int CurrentBytesDone { get; protected set; }
        /// <summary>
        /// Processing rate in byte/s.
        /// </summary>
        public int Rate { get; protected set; }
    }
}
