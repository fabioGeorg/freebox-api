using System;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace FreeboxAPI
{
    /// <summary>
    /// Freebox
    /// </summary>
    public class Freebox
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public Freebox(string username, string password)
        {
            Username = username;
            Password = password;
        }

        /// <summary>
        /// Request auth function.
        /// </summary>
        /// <param name="tokenRequest">Application information.</param>
        /// <returns>Returns whether the request is granted.</returns>
        public bool RequestAuth(LoginAPI.TokenRequest tokenRequest)
        {
            string jsonStr = "";
            JObject jsonObject = new JObject();
            using (WebClient client = new WebClient())
            {
                jsonStr = client.UploadString(API.Endpoints.APIEndpoints.LoginEndpoints.RequestAuthorization, tokenRequest.ToString());
            }
            jsonObject = JObject.Parse(jsonStr);
            bool success = (bool)jsonObject["success"];
            if (success)
            {
                int trackID = (int)jsonObject["result"]["track_id"];
                //if (success)
                //    IsLoggedIn = (bool)jsonObject["result"]["logged_in"];
                //else IsLoggedIn = false;
                //Console.WriteLine(jsonObject["result"].ToString());

                return GetAuthStatus(trackID) == LoginAPI.AuthStatus.granted;
            }
            return false;
        }

        /// <summary>
        /// Get athentication status.
        /// </summary>
        /// <param name="trackID">The app trackID</param>
        /// <returns></returns>
        private LoginAPI.AuthStatus GetAuthStatus(int trackID)
        {
            string jsonStr = "";
            JObject jsonObject = new JObject();
            using (WebClient client = new WebClient())
            {
                jsonStr = client.DownloadString(API.Endpoints.APIEndpoints.LoginEndpoints.GetAuthorizationProgressByID.Replace("{track_id}", $"{trackID}"));
            }
            jsonObject = JObject.Parse(jsonStr);
            if ((bool)jsonObject["success"])
            {
                string authStatus = (string)jsonObject["result"]["status"];
                return (LoginAPI.AuthStatus)Enum.Parse(typeof(LoginAPI.AuthStatus), authStatus);
            }
            return LoginAPI.AuthStatus.unknown;
        }

        /// <summary>
        /// Get the challenge string.
        /// </summary>
        /// <returns>Challenge string</returns>
        public string GetChallenge()
        {
            string jsonStr = "";
            JObject jsonObject = new JObject();
            using (WebClient client = new WebClient())
            {
                jsonStr = client.DownloadString(API.Endpoints.APIEndpoints.LoginEndpoints.GetChallengeValue);
            }

            jsonObject = JObject.Parse(jsonStr);
            if ((bool)jsonObject["success"])
            {
                return (string)jsonObject["result"]["challenge"];
            }
            return "";
        }
        
        /// <summary>
        /// Open a session.
        /// </summary>
        /// <returns>Returns a <c>Dictionary</c> corresponding to the app permissions.</returns>
        /// <see cref="API.AppPermission"/>
        public Dictionary<string, bool> OpenSession()
        {
            string jsonStr = "";
            JObject jsonObject = new JObject();
            Dictionary<string, bool> appPermissions = new Dictionary<string, bool>();
            using (WebClient client = new WebClient())
            {
                jsonStr = client.UploadString(API.Endpoints.APIEndpoints.LoginEndpoints.OpenSession, "");
            }

            jsonObject = JObject.Parse(jsonStr);
            if((bool)jsonObject["success"])
            {
                //TODO: Permissions parse.
            }
            return appPermissions;
        }

        /// <summary>
        /// Make an authenticated call to the API.
        /// </summary>
        /// <param name="sessionToken">The session token</param>
        /// <returns>return true if success. False otherwise.</returns>
        public bool AuthenticatedCall(string sessionToken)
        {
            string jsonStr = "";
            JObject jsonObject = new JObject();
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("X-Fbx-App-Auth", sessionToken);
                jsonStr = client.DownloadString(API.Endpoints.APIEndpoints.LoginEndpoints.OpenSession);
            }

            jsonObject = JObject.Parse(jsonStr);
            return (bool)jsonObject["success"];
        }

        /// <summary>
        /// Close the current session.
        /// </summary>
        /// <returns>return true if the session has been close. False otherwise.</returns>
        public bool CloseSession()
        {
            string jsonStr = "";
            JObject jsonObject = new JObject();
            using (WebClient client = new WebClient())
            {
                jsonStr = client.UploadString(API.Endpoints.APIEndpoints.LoginEndpoints.CloseSession, "");
            }
            jsonObject = JObject.Parse(jsonStr);
            return (bool)jsonObject["success"];
        }

        /// <summary>
        /// Get logged_in value.
        /// </summary>
        /// <returns>True if the user is connected. False otherwise.</returns>
        /// <remarks>
        /// This function use the <c>APIEndpoints.LoginEndpoints.GetChallengeValue</c>.
        /// </remarks>
        private bool GetIsLoggedIn()
        {
            string jsonStr = "";
            JObject jsonObject = new JObject();
            using (WebClient client = new WebClient())
            {
                jsonStr = client.DownloadString(API.Endpoints.APIEndpoints.LoginEndpoints.GetChallengeValue);
            }

            jsonObject = JObject.Parse(jsonStr);
            if ((bool)jsonObject["success"])
                return (bool)jsonObject["result"]["logged_in"];
            return false;
        }

        /// <summary>
        /// Username
        /// </summary>
        public string Username { get; protected set; }
        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; protected set; }
        /// <summary>
        /// Is the user already connected
        /// </summary>
        public bool IsLoggedIn
        {
            get => GetIsLoggedIn();
            protected set { }
        }
    }
}
