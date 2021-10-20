
namespace FreeboxAPI.ConfigurationAPI.NetworkShareAPI
{
    /// <summary>
    /// NetworkShareErrors
    /// </summary>
    public enum NetworkShareErrors
    {
        /// <summary>
        /// Invalid workgroup name.
        /// </summary>
        invalid_workgroup_name,
        /// <summary>
        /// Invalid samba user name.
        /// </summary>
        invalid_logon_user,
        /// <summary>
        /// Invalid samba user password.
        /// </summary>
        invalid_logon_password,
        /// <summary>
        /// Invalid AFP user name.
        /// </summary>
        invalid_afp_login_name,
        /// <summary>
        /// Invalid AFP user password.
        /// </summary>
        invalid_afp_login_password
    }
}
