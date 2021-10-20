using System.Collections.Generic;

namespace FreeboxAPI.AirMediaAPI
{
    /// <summary>
    /// AirMediaReceiver
    /// </summary>
    public class AirMediaReceiver
    {
        /// <summary>
        /// Empty constructor.
        /// </summary>
        public AirMediaReceiver() { }
        /// <summary>
        /// AirMedia name.
        /// </summary>
        public string Name { get; protected set; }
        /// <summary>
        /// If set to true the receiver is protected by a password.
        /// </summary>
        public bool PasswordProtected { get; protected set; }
        /// <summary>
        /// List of receiver capabilities from the following list:
        /// photo: can display photos
        /// audio: can play audio files
        /// video: can play video files
        /// screen: can display remote screen
        /// </summary>
        public Dictionary<string, bool> Capabilities { get; protected set; }
    }
}
