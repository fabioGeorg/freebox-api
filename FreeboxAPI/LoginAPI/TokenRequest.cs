using System;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;

namespace FreeboxAPI.LoginAPI
{
    /// <summary>
    /// TokenRequest
    /// </summary>
    public class TokenRequest
    {
        /// <summary>
        /// Parameters constructor.
        /// </summary>
        /// <param name="appID"></param>
        /// <param name="appName"></param>
        /// <param name="appVersion"></param>
        /// <param name="deviceName"></param>
        public TokenRequest(string appID, string appName, string appVersion, string deviceName)
        {
            AppID = appID;
            AppName = appName;
            AppVersion = appVersion;
            DeviceName = deviceName;
        }

        /// <summary>
        /// Request authorization
        /// </summary>
        public void RequestAuth()
        {
            TokenRequest req = new TokenRequest(AppID, AppName, AppVersion, DeviceName);
            using (HttpClient client = new HttpClient())
            {                
                string strReq = JsonConvert.SerializeObject(req);
                var content = new StringContent(strReq, Encoding.UTF8, "application/json");
                var result = client.PostAsync(API.Endpoints.APIEndpoints.LoginEndpoints.RequestAuthorization, content).Result;
            }
        }

        public override string ToString()
        {
            string openBracket = "{";
            string closeBracket = "}";
            //return $"{openBracket}\"app_id\":\"{AppID}\",\"app_name\":\"{AppName}\",\"app_version\":\"{AppVersion}\",\"device_name\":\"{DeviceName}\"{closeBracket}";
            return $"{{\"app_id\":\"{AppID}\",\"app_name\":\"{AppName}\",\"app_version\":\"{AppVersion}\",\"device_name\":\"{DeviceName}\"}}";
        }

        /// <summary>
        /// AppID
        /// </summary>
        public string AppID { get; protected set; }
        /// <summary>
        /// AppName
        /// </summary>
        public string AppName { get; protected set; }
        /// <summary>
        /// AppVersion
        /// </summary>
        public string AppVersion { get; protected set; }
        /// <summary>
        /// DeviceName
        /// </summary>
        public string DeviceName { get; protected set; }
    }
}
