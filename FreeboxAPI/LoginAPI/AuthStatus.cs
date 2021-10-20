
namespace FreeboxAPI.LoginAPI
{
    public enum AuthStatus
    {
        /// <summary>
        /// The app_token is invalid or has been revoked.
        /// </summary>
        unknown,
        /// <summary>
        /// The user has not confirmed the authorization request yet.
        /// </summary>
        pending,
        /// <summary>
        /// The user did not confirmed the authorization within the given time.
        /// </summary>
        timeout,
        /// <summary>
        /// The app_token is valid and can be used to open a session.
        /// </summary>
        granted,
        /// <summary>
        /// The user denied the authorization request.
        /// </summary>
        denied
    }
}
