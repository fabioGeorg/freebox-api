
namespace FreeboxAPI.FSAPI
{
    /// <summary>
    /// FSErrorPlus
    /// </summary>
    public enum FSErrorsPlus
    {
        /// <summary>
        /// No error.
        /// </summary>
        none,
        /// <summary>
        /// Error reading archive.
        /// </summary>
        archive_read_failed,
        /// <summary>
        /// Error opening archive.
        /// </summary>
        archive_open_failed,
        /// <summary>
        /// Error writing archive.
        /// </summary>
        archive_write_failed,
        /// <summary>
        /// Error changing directory.
        /// </summary>
        chdir_failed,
        /// <summary>
        /// The destination is not a directory.
        /// </summary>
        dest_is_not_dir,
        /// <summary>
        /// File already exists.
        /// </summary>
        file_exists,
        /// <summary>
        /// File not found.
        /// </summary>
        file_not_found,
        /// <summary>
        /// Unable to create directory.
        /// </summary>
        mkdir_failed,
        /// <summary>
        /// Error opening input file.
        /// </summary>
        open_input_failed,
        /// <summary>
        /// Error opening output file.
        /// </summary>
        open_output_failed,
        /// <summary>
        /// Error opening directory.
        /// </summary>
        opendir_failed,
        /// <summary>
        /// Error overwriting file.
        /// </summary>
        openwrite_failed,
        /// <summary>
        /// Path is too long.
        /// </summary>
        path_too_big,
        /// <summary>
        /// Failed to repair corrupted files.
        /// </summary>
        repair_failed,
        /// <summary>
        /// Error removing directory.
        /// </summary>
        mdir_failed,
        /// <summary>
        /// Source and Destination are the same file.
        /// </summary>
        same_file,
        /// <summary>
        /// Error removing file.
        /// </summary>
        unlink_failed,
        /// <summary>
        /// This file type is not supported.
        /// </summary>
        unsupported_file_type,
        /// <summary>
        /// Error writing file.
        /// </summary>
        write_failed,
        /// <summary>
        /// Disk is full.
        /// </summary>
        disk_full,
        /// <summary>
        /// Internal error.
        /// </summary>
        @internal,
        /// <summary>
        /// Invalid file format (corrupted?).
        /// </summary>
        invalid_format,
        /// <summary>
        /// Invalid or missing password for extraction.
        /// </summary>
        incorrect_password,
        /// <summary>
        /// Permission denied.
        /// </summary>
        permission_denied,
        /// <summary>
        /// Failed to read the target of a symbolic link.
        /// </summary>
        readlink_failed,
        /// <summary>
        /// Failed to create a symbolic link.
        /// </summary>
        symlink_failed
    }
}
