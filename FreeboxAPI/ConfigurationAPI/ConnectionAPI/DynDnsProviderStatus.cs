
namespace FreeboxAPI.ConfigurationAPI.ConnectionAPI
{
    /// <summary>
    /// DynDnsProviderStatus
    /// </summary>
    public enum DynDnsProviderStatus
    {
        /// <summary>
        /// Disabled.
        /// </summary>
        disabled,
        /// <summary>
        /// OK.
        /// </summary>
        ok,
        /// <summary>
        /// Updating.
        /// </summary>
        wait,
        /// <summary>
        /// Request failed.
        /// </summary>
        reqfail,
        /// <summary>
        /// Authentication error.
        /// </summary>
        authfail,
        /// <summary>
        /// Invalid credential.
        /// </summary>
        nocredential,
        /// <summary>
        /// Invalid IP.
        /// </summary>
        ipinval,
        /// <summary>
        /// Invalid hostname.
        /// </summary>
        hostinval,
        /// <summary>
        /// Blocked because of abuse.
        /// </summary>
        abuse,
        /// <summary>
        /// DNS error.
        /// </summary>
        dnserror,
        /// <summary>
        /// Service unavailable.
        /// </summary>
        unavailable,
        /// <summary>
        /// Unable to get wan IP.
        /// </summary>
        nowan,
        /// <summary>
        /// Unknown.
        /// </summary>
        unknown
    }
}
