using System;
using System.Net;
using Newtonsoft.Json;

namespace FreeboxAPI.ConfigurationAPI.LCD
{
    /// <summary>
    /// Lcd
    /// </summary>
    public class Lcd
    {
        /// <summary>
        /// Empty constructor.
        /// </summary>
        public Lcd() { }

        /// <summary>
        /// Get LcdConfig.
        /// </summary>
        /// <returns></returns>
        public LcdConfig GetLcdConfig()
        {
            LcdConfig res = new LcdConfig();
            using(WebClient wc = new WebClient())
            {
                //wc.BaseAddress = "mafreebox.freebox.fr/api/v4/lcd/config/";
               
            }
            return res;
        }
    }
}
