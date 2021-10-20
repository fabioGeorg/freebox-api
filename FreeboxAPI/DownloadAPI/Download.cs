
namespace FreeboxAPI.DownloadAPI
{
    /// <summary>
    /// Download
    /// </summary>
    public class Download
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; protected set; }
        /// <summary>
        /// DownloadType
        /// </summary>
        public DownloadTypes DownloadType { get; protected set; }
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; protected set; }
        /// <summary>
        /// Status
        /// </summary>
        public DownloadStatus Status { get; set; }
        /// <summary>
        /// Size
        /// </summary>
        public int Size { get; protected set; }
        /// <summary>
        /// QueuePos
        /// </summary>
        public int QueuePos { get; set; }
        /// <summary>
        /// IOPriority
        /// </summary>
        public IOPriority IOPriority { get; set; }
        /// <summary>
        /// TXBytes
        /// </summary>
        public int TXBytes { get; protected set; }
        /// <summary>
        /// RXBytes
        /// </summary>
        public int RXBytes { get; protected set; }
        /// <summary>
        /// TXRate
        /// </summary>
        public int TXRate { get; protected set; }
        /// <summary>
        /// RXRate
        /// </summary>
        public int RXRate { get; protected set; }
        /// <summary>
        /// TXPct
        /// </summary>
        public int TXPct { get; protected set; }
        /// <summary>
        /// RXPct
        /// </summary>
        public int RXPct { get; protected set; }
        /// <summary>
        /// DownloadTaskError
        /// </summary>
        public DownloadTaskErrors Error { get; protected set; }
        /// <summary>
        /// CreatedTS
        /// </summary>
        public int CreatedTS { get; protected set; }
        /// <summary>
        /// ETA
        /// </summary>
        public int ETA { get; protected set; }
        /// <summary>
        /// DownloadDir
        /// </summary>
        public string DownloadDir { get; protected set; }
        /// <summary>
        /// StopRatio
        /// </summary>
        public int StopRatio { get; protected set; }
        /// <summary>
        /// ArchivePassword
        /// </summary>
        public string ArchivePassword { get; set; }
        /// <summary>
        /// InfoHash
        /// </summary>
        public string InfoHash { get; set; }
        /// <summary>
        /// PieceLength
        /// </summary>
        public int PieceLength { get; protected set; }
    }
}
