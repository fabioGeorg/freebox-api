
namespace FreeboxAPI.AirMediaAPI
{
    /// <summary>
    /// AirMediaErrors
    /// </summary>
    public enum AirMediaErrors
    {
        /// <summary>
        /// No airmedia device with this name in range.
        /// </summary>
        unknown_target,
        /// <summary>
        /// No airmedia client connected.
        /// </summary>
        no_client,
        /// <summary>
        /// Unable to update password.
        /// </summary>
        set_pass,
        /// <summary>
        /// Unable to activate onscreen code.
        /// </summary>
        set_onscreen_code,
        /// <summary>
        /// Remote control is unavailable.
        /// </summary>
        no_ctrl,
        /// <summary>
        /// Internal HTTP error.
        /// </summary>
        http,
        /// <summary>
        /// No stream session found.
        /// </summary>
        bad_session,
        /// <summary>
        /// Invalid airmedia name.
        /// </summary>
        bad_name,
        /// <summary>
        /// No device with this id.
        /// </summary>
        bad_device_id,
        /// <summary>
        /// No remote control with this id.
        /// </summary>
        bad_remote_id,
        /// <summary>
        /// You should try again, another request is still processing.
        /// </summary>
        req_in_progress,
        /// <summary>
        /// Unable to get slideshow information.
        /// </summary>
        fetch,
        /// <summary>
        /// No screen available.
        /// </summary>
        no_display,
        /// <summary>
        /// Invalid playback state.
        /// </summary>
        playback_state,
        /// <summary>
        /// Slideshow is not supported.
        /// </summary>
        no_slideshow_srv,
        /// <summary>
        /// Internal error.
        /// </summary>
        no_mem,
        /// <summary>
        /// Unable to read input file.
        /// </summary>
        inout_file,
        /// <summary>
        /// Volume control is not available.
        /// </summary>
        no_volume_control,
        /// <summary>
        /// Error connecting to the airmedia device.
        /// </summary>
        connect,
        /// <summary>
        /// This device requests a password.
        /// </summary>
        unauthorized,
        /// <summary>
        /// The device does not support this format.
        /// </summary>
        unsupported_media,
        /// <summary>
        /// Invalid file type.
        /// </summary>
        bad_type,
        /// <summary>
        /// Unimplemented.
        /// </summary>
        unimplemented
    }
}
