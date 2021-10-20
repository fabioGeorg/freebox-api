
namespace FreeboxAPI.AirMediaAPI
{
    /// <summary>
    /// AirMediaReceiverRequest
    /// </summary>
    public class AirMediaReceiverRequest
    {
        /// <summary>
        /// Start/Stop playing a media.
        /// </summary>
        public Actions Action { get; set; }
        /// <summary>
        /// Media type
        /// photo: display a photo
        /// video: display a video
        /// </summary>
        public string MediaType { get; set; }
        /// <summary>
        /// Optional receiver password.
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Start position for a video.
        /// The start position is expressed in percent * 1000, for instance 50 000 means 50% of the video.
        /// </summary>
        public int Position { get; set; }
        /// <summary>
        /// The media to play.
        /// For video media, you have to specify the media URL (end with .mov or .mp4, etc)
        /// For photo media, you have to specify the file path on the Freebox Server (base64 encoded
        /// as returned in fs/ls call).
        /// </summary>
        public string Media { get; set; }
    }
}
