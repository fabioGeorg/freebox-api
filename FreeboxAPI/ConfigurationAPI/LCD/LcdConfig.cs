using System;

namespace FreeboxAPI.ConfigurationAPI.LCD
{
    /// <summary>
    /// LcdConfig
    /// </summary>
    public class LcdConfig
    {
        /// <summary>
        /// Empty constructor.
        /// </summary>
        public LcdConfig(){}

        /// <summary>
        /// Parameters constructor.
        /// </summary>
        /// <param name="brightness"></param>
        /// <param name="orientationForced"></param>
        /// <param name="orientation"></param>

        public LcdConfig(int brightness, bool orientationForced, int orientation)
        {
            Brightness = brightness;
            OrientationForced = orientationForced;
            Orientation = orientation;
        }

        /// <summary>
        /// The screen brightness (range from 0 to 100).
        /// </summary>
        public int Brightness { get; set; }
        /// <summary>
        /// Is the screen orientation forced.
        /// </summary>
        public bool OrientationForced { get; set; }
        /// <summary>
        /// The screen orientation angle.
        /// </summary>
        public int Orientation { get; set; }
    }
}
