
namespace FreeboxAPI.API
{
    /// <summary>
    /// App permission
    /// </summary>
    public static class AppPermission
    {
        /// <summary>
        /// Allow modifying the Freebox settings (reading settings is always allowed).
        /// </summary>
        public static string Settings => "settings";
        /// <summary>
        /// Access to contact list.
        /// </summary>
        public static string Contacts => "contacts";
        /// <summary>
        /// Access to call logs.
        /// </summary>
        public static string Calls => "calls";
        /// <summary>
        /// Access to filesystem.
        /// </summary>
        public static string Explorer => "explorer";
        /// <summary>
        /// Access to downloader.
        /// </summary>
        public static string Downloader => "downloader";
        /// <summary>
        /// Access to parental control.
        /// </summary>
        public static string Parental => "parental";
        /// <summary>
        /// Access personal video recorder. (Not yet supported)
        /// </summary>
        public static string PVR => "pvr";
    }
}
