
namespace FreeboxAPI.FSAPI
{
    /// <summary>
    /// FSFileInfo
    /// </summary>
    public class FSFileInfo
    {
        /// <summary>
        /// File path (encoded in base64).
        /// </summary>
        public string Path { get; protected set; }
        /// <summary>
        /// File name (in clear text).
        /// </summary>
        public string Name { get; protected set; }
        /// <summary>
        /// File mimetype.
        /// </summary>
        public string Mimetype { get; protected set; }
        /// <summary>
        /// FileType.
        /// </summary>
        public FileTypes FileType { get; set; }
        /// <summary>
        /// File size in bytes.
        /// </summary>
        public int Size { get; protected set; }
        /// <summary>
        /// File modification timestamp.
        /// </summary>
        public int Modification { get; protected set; }
        /// <summary>
        /// Display order for natural sort.
        /// </summary>
        public int Index { get; protected set; }
        /// <summary>
        /// Is this file a link.
        /// </summary>
        public bool Link { get; protected set; }
        /// <summary>
        /// Symlink target path (encoded in base64) (only present when link is set to true).
        /// </summary>
        public string Target { get; protected set; }
        /// <summary>
        /// Should the file be hidden to user.
        /// </summary>
        public bool Hidden { get; protected set; }
        /// <summary>
        /// Number of subfolders. Only relevant for dir, only provided if "countDubFolder" parameter is set.
        /// </summary>
        public int FolderCount { get; protected set; }
        /// <summary>
        /// Number of files inside directory. Only relevant for dir, only provided if "countSubFolder" parameter is set.
        /// </summary>
        public int FileCount { get; protected set; }
    }
}
