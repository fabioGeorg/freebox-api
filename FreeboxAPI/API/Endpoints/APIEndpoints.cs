
namespace FreeboxAPI.API.Endpoints
{
    /// <summary>
    /// Contains all the APIEndpoints URL.
    /// </summary>
    public static class APIEndpoints
    {
        /// <summary>
        /// API base URL
        /// </summary>
        public static string BaseURL => "http://mafreebox.freebox.fr/";
        /// <summary>
        /// Get the API version.
        /// Method: GET
        /// Param: none
        /// </summary>
        public static string GetAPIVersion => "http://mafreebox.freebox.fr/api_version";
        
        /// <summary>
        /// ParentalAPI
        /// </summary>
        public static class ParentalEndpoints
        {
            /// <summary>
            /// Get the <c>ParentalFilterConfig</c>.
            /// Method: GET
            /// Param: none
            /// </summary>
            public static string GetParentalFilterConfig => "http://mafreebox.freebox.fr/api/v4/parental/config/";
            /// <summary>
            /// Update the <c>ParentalFilterConfig</c>.
            /// Method: PUT
            /// Param: none
            /// </summary>
            public static string UpdateParentalFilterConfig => "http://mafreebox.freebox.fr/api/v4/parental/config/";
            /// <summary>
            /// Returns the collection of all <c>ParentalFilter</c> rules.
            /// Method: GET
            /// Param: none
            /// </summary>
            public static string GetAllParentalFilterRules => "http://mafreebox.freebox.fr/api/v4/parental/filter/";
            /// <summary>
            /// Returns the <c>ParentalFilter</c> rule with the given ID.
            /// Method: GET
            /// Param: ID (replace {id} with the ID)
            /// </summary>
            public static string GetParentalFilterRuleByID => "http://mafreebox.freebox.fr/api/v4/parental/filter/{id}";
            /// <summary>
            /// Deletes the <c>ParentalFilter</c> rule with the given ID.
            /// Method: DELETE
            /// Param: ID (replace {id} with the ID)
            /// </summary>
            public static string DeleteParentalFilterRuleByID => "http://mafreebox.freebox.fr/api/v4/parental/filter/{id}";
            /// <summary>
            /// Updates the <c>ParentalFilter</c> rule with the given ID.
            /// Method: PUT
            /// Param: ID (replace {id} with the ID)
            /// </summary>
            public static string UpdateParentalFilterRuleByID => "http://mafreebox.freebox.fr/api/v4/parental/filter/{id}";
            /// <summary>
            /// Add a parental filter rule.
            /// Method: POST
            /// Param: none
            /// </summary>
            public static string AddParentalFilterRule => "http://mafreebox.freebox.fr/api/v4/parental/filter/";
            /// <summary>
            /// Returns the <c>ParentalFilterPlanning</c> for the filter with the given ID.
            /// Method: GET
            /// Param: ID (replace {id} with the ID}
            /// </summary>
            public static string GetParentalFilterPlanningByID => "http://mafreebox.freebox.fr/api/v4/parental/filter/{id}/planning";
            /// <summary>
            /// Update the <c>ParentalFilterPlanning</c> for the parental filter rule with the given ID.
            /// Method: PUT
            /// Param: ID (replace {id} with the ID)
            /// </summary>
            public static string UpdateParentalFilterPlanningByID => "http://mafreebox.freebox.fr/api/v4/parental/filter/{id}/planning";
        }

        /// <summary>
        /// CallAPI
        /// </summary>
        public static class CallEndpoints
        {
            /// <summary>
            /// Returns the collection of all <c>CallEntry</c> call entry.
            /// Method: GET
            /// Param: none
            /// </summary>
            public static string GetListCalls => "http://mafreebox.freebox.fr/api/v4/call/log/";
            /// <summary>
            /// Remove all <c>CallEntry</c> call entries.
            /// Method: POST
            /// Param: none
            /// </summary>
            public static string DeleteAllCalls => "http://mafreebox.freebox.fr/api/v4/call/log/delete_all/";
            /// <summary>
            /// Mark all <c>CallEntry</c> call entries as read.
            /// Method: POST
            /// Param: none
            /// </summary>
            public static string MarkAllCallsAsRead => "http://mafreebox.freebox.fr/api/v4/call/log/mark_all_as_read/";
            /// <summary>
            /// Returns the <c>CallEntry</c> task with the given ID.
            /// Method: GET
            /// Param: ID (replace {id} with the ID)
            /// </summary>
            public static string GetCallByID => "http://mafreebox.freebox.fr/api/v4/call/log/{id}";
            /// <summary>
            /// Deletes the <c>CallEntry</c> with the given ID.
            /// Method: DELETE
            /// Param: ID (replace {id} with the ID)
            /// </summary>
            public static string DeleteCallByID => "http://mafreebox.freebox.fr/api/v4/call/log/{id}";
            /// <summary>
            /// Updates the <c>CallEntry</c> task with the given ID.
            /// Method: PUT
            /// Param: ID (replace {id} with the ID)
            /// </summary>
            public static string UpdateCallByID => "http://mafreebox.freebox.fr/api/v4/call/log/{id}";
        }
        
        /// <summary>
        /// AirMediaAPI
        /// </summary>
        public static class AirMediaEndpoints
        {
            /// <summary>
            /// Returns the current <c>AirMediaConfig</c>.
            /// Method: GET
            /// Param: none           
            /// </summary>
            public static string GetAirMediaConfig => "http://mafreebox.freebox.fr/api/v4/airmedia/config/";
            /// <summary>
            /// Update the current <c>AirMediaConfig</c>.
            /// Method: PUT
            /// Param: none
            /// </summary>
            public static string UpdateAirMediaConfig => "http://mafreebox.freebox.fr/api/v4/airmedia/config/";
            /// <summary>
            /// Get the list of <c>AirMediaReceiver</c> connected to the Freebox Server.
            /// Method: GET
            /// Param: none
            /// </summary>
            public static string GetAllAirMediaReceivers => "http://mafreebox.freebox.fr/api/v4/airmedia/receivers/";
            /// <summary>
            /// Send a new request to an <c>AirMediaReceiver</c>.
            /// Method: POST
            /// Param: ReceiverName (replace {receiver_name} with the ReceiverName)
            /// </summary>
            public static string SendAirMediaRequestByReceiverName => "http://mafreebox.freebox.fr/api/v4/airmedia/receivers/{receiver_name}/";

        }

        /// <summary>
        /// ConnectionAPI
        /// </summary>
        public static class ConnectionEndpoints
        {
            /// <summary>
            /// Returns the current <c>ConnectionStatus</c>.
            /// Method: GET
            /// Param: none
            /// </summary>
            public static string GetConnectionStatus => "http://mafreebox.freebox.fr/api/v4/connection/";
            /// <summary>
            /// Returns the current <c>ConnectionConfiguration</c>.
            /// Method: GET
            /// Param: none
            /// </summary>
            public static string GetConnectionConfig => "http://mafreebox.freebox.fr/api/v4/connection/config/";
            /// <summary>
            /// Updates the <c>ConnectionConfiguration</c>.
            /// Method: PUT
            /// Param: none
            /// </summary>
            public static string UpdateConnectionConfig => "http://mafreebox.freebox.fr/api/v4/connection/config/";
            /// <summary>
            /// Returns the current <c>ConnectionIPv6Configuration</c>.
            /// Method: GET
            /// Param: none
            /// </summary>
            public static string GetIPv6ConnectionConfig => "http://mafreebox.freebox.fr/api/v4/connection/ipv6/config/";
            /// <summary>
            /// Updates the <c>ConnectionIPv6Configuration</c>.
            /// Method: PUT
            /// Param: none
            /// </summary>
            public static string UpdateIPv6ConnectionConfig => "http://mafreebox.freebox.fr/api/v4/connection/ipv6/config/";
            /// <summary>
            /// Returns the current <c>xDSLInfos</c>.
            /// Method: GET
            /// Param: none
            /// </summary>
            public static string GetxDSLInfos => "http://mafreebox.freebox.fr/api/v4/connection/xdsl/";
            /// <summary>
            /// Returns the current <c>FTTHStatus</c>.
            /// Method: GET
            /// Param: none
            /// </summary>
            public static string GetFTTHStatus => "http://mafreebox.freebox.fr/api/v4/connection/ftth/";
            /// <summary>
            /// Returns the current <c>DDNSStatus</c>.
            /// Method: GET
            /// Param: Provider (replace {provider} with the Provider)
            /// </summary>
            public static string GetDDNSStatus => "http://mafreebox.freebox.fr/api/v4/connection/ddns/{provider}/status/";
            /// <summary>
            /// Returns the current <c>DDNSConfig</c>.
            /// Method: GET
            /// Param: Provider (replace {provider} with the Provider)
            /// </summary>
            public static string GetDDNSConfig => "http://mafreebox.freebox.fr/api/v4/connection/ddns/{provider}/";
            /// <summary>
            /// Set the <c>DDNSConfig</c>.
            /// Method: PUT
            /// Param: Provider (replace {provider} with the Provider)
            /// </summary>
            public static string SetDDNSConfig => "http://mafreebox.freebox.fr/api/v4/connection/ddns/{provider}/";
        }

        /// <summary>
        /// FreeplugAPI
        /// </summary>
        public static class FreeplugEndpoints
        {
            /// <summary>
            /// Returns the list of <c>FreeplugNetwork</c>.
            /// Method: GET
            /// Param: none
            /// </summary>
            public static string GetFreeplugs => "http://mafreebox.freebox.fr/api/v4/freeplug/";
            /// <summary>
            /// Returns the information of a <c>Freeplug</c>.
            /// Method: GET
            /// Param: ID (replace {id} with the ID)
            /// </summary>
            public static string GetFreeplugByID => "http://mafreebox.freebox.fr/api/v4/freeplug/{id}/";
            /// <summary>
            /// Reset the given <c>Freeplug</c>.
            /// Method: POST
            /// Param: ID (replace {id} with the ID)
            /// </summary>
            public static string ResetFreeplugByID => "http://mafreebox.freebox.fr/api/v4/freeplug/{id}/reset/";
        }

        /// <summary>
        /// LcdAPI
        /// </summary>
        public static class LCDEndpoints
        {
            /// <summary>
            /// Get the <c>LcdConfig</c>.
            /// Method: GET
            /// Param: none
            /// </summary>
            public static string GetLCDConfig => "http://mafreebox.freebox.fr/api/v4/lcd/config/";
            /// <summary>
            /// Update the <c>LcdConfig</c>.
            /// Method: PUT
            /// Param: none
            /// </summary>
            public static string UpdateLCDConfig => "http://mafreebox.freebox.fr/api/v4/lcd/config/";
        }

        /// <summary>
        /// UPnPAVAPI
        /// </summary>
        public static class UPnPAVEndpoints
        {
            /// <summary>
            /// Get the <c>UPnPAVConfig</c>.
            /// Method: GET
            /// Param: none
            /// </summary>
            public static string GetUPnPAVConfig => "http://mafreebox.freebox.fr/api/v4/upnpav/config/";
            /// <summary>
            /// Update the <c>UPnPAVConfig</c>.
            /// Method: PUT
            /// Param: none
            /// </summary>
            public static string UpdateUPnPAVConfig => "http://mafreebox.freebox.fr/api/v4/upnpav/config/";
        }

        /// <summary>
        /// NetworkShareAPI
        /// </summary>
        public static class NetworkShareEndpoints
        {
            /// <summary>
            /// Get the <c>SambaConfig</c>.
            /// Method: GET
            /// Param: none
            /// </summary>
            public static string GetSambaConfig => "http://mafreebox.freebox.fr/api/v4/netshare/samba/";
            /// <summary>
            /// Update the <c>SambaConfig</c>.
            /// Method: PUT
            /// Param: none
            /// </summary>
            public static string UpdateSambaConfig => "http://mafreebox.freebox.fr/api/v4/netshare/samba/";
            /// <summary>
            /// Get the <c>AFPConfig</c>.
            /// Method: GET
            /// Param: none
            /// </summary>
            public static string GetAFPConfig => "http://mafreebox.freebox.fr/api/v4/netshare/afp/";
            /// <summary>
            /// Update the <c>AFPConfig</c>.
            /// Method: PUT
            /// Param: none
            /// </summary>
            public static string UpdateAFPConfig => "http://mafreebox.freebox.fr/api/v4/netshare/afp/";
        }

        /// <summary>
        /// Login
        /// </summary>
        public static class LoginEndpoints
        {
            /// <summary>
            /// Request authorization.
            /// Method: POST
            /// Param: none
            /// </summary>
            public static string RequestAuthorization => "http://mafreebox.freebox.fr/api/v4/login/authorize/";
            /// <summary>
            /// Get the authorization progress of the given ID.
            /// Method: GET
            /// Param: TrackID (replace {track_id} with the TrackID)
            /// </summary>
            public static string GetAuthorizationProgressByID => "http://mafreebox.freebox.fr/api/v4/login/authorize/{track_id}";
            /// <summary>
            /// Get challenge value.
            /// Method: GET
            /// Param: none
            /// </summary>
            public static string GetChallengeValue => "http://mafreebox.freebox.fr/api/v4/login/";
            /// <summary>
            /// Open a session.
            /// Method: POST, GET (depends the API used)
            /// Param: none
            /// </summary>
            public static string OpenSession => "http://mafreebox.freebox.fr/api/v4/login/session/";
            /// <summary>
            /// Close the session.
            /// Method: POST
            /// Param: none
            /// </summary>
            public static string CloseSession => "http://mafreebox.freebox.fr/api/v4/login/logout/";
        }

        /// <summary>
        /// ContactAPI
        /// </summary>
        public static class ContactEndpoints
        {
            /// <summary>
            /// Returns the collection of all <c>ContactEntry</c>.
            /// Method: GET
            /// Param: Not yet implemented. none
            /// </summary>
            public static string GetListContacts => "http://mafreebox.freebox.fr/api/v4/contact/";
            /// <summary>
            /// Returns the <c>ContactEntry</c> with the given ID.
            /// Method: GET
            /// Param: ID (replace {id} with the ID)
            /// </summary>
            public static string GetContactByID => "http://mafreebox.freebox.fr/api/v4/contact/{id}";
            /// <summary>
            /// Creates a new <c>ContactEntry</c>.
            /// Method: POST
            /// Param: none
            /// </summary>
            public static string CreateContact => "http://mafreebox.freebox.fr/api/v4/contact/";
            /// <summary>
            /// Deletes the <c>ContactEntry</c> with the given ID.
            /// Method: DELETE
            /// Param: ID (replace {id} with the ID)
            /// </summary>
            public static string DeleteContactByID => "http://mafreebox.freebox.fr/api/v4/contact/{id}";
            /// <summary>
            /// Updates the <c>ContactEntry</c> with the given ID.
            /// Method: PUT
            /// Param: ID (replace {id} with the ID)
            /// </summary>
            public static string UpdateContactByID => "http://mafreebox.freebox.fr/api/v4/contact/{id}";
            /// <summary>
            /// Returns the collection corresponding the info choosed for a given contactID.
            /// Method: GET
            /// Param: ID, Info (replace {id} with the ID and {info} with the contact info)
            /// </summary>
            /// <see cref="ContactAPI.ContactInfo"/>
            public static string GetListByContactID => "http://mafreebox.freebox.fr/api/v4/contact/{id}/{info}/";
            /// <summary>
            /// Returns the corresponding info choosed for a given contactID
            /// Method: GET
            /// Param: ID, Info (replace {id} with the ID and {info} with the contact info)
            /// </summary>
            /// <see cref="ContactAPI.ContactInfo"/>
            public static string GetContactInfoByID => "http://mafreebox.freebox.fr/api/v4/{info}/{id}";
            /// <summary>
            /// Create the contact info.
            /// Method: POST
            /// Param: Info (replace {info} with the Info)          
            /// </summary>
            /// <see cref="ContactAPI.ContactInfo"/>
            public static string CreateContactInfo => "http://mafreebox.freebox.fr/api/v4/{info}/";
            /// <summary>
            /// Deletes the corresponding Info with the given ID.
            /// Method: DELETE
            /// Param: Info, ID (replace {info} with the Info and {id} with the ID)
            /// </summary>
            public static string DeleteContactInfoByID => "http://mafreebox.freebox.fr/api/v4/{info}/{id}";
            /// <summary>
            /// Updates the corresponding Info with the given ID.
            /// Method: PUT
            /// Param: Info, ID (replace {info} with the Info and {id} with the ID)
            /// </summary>
            public static string UpdateContactInfoByID => "http://mafreebox.freebox.fr/api/v4/{info}/{id}";
        }

        /// <summary>
        /// DownloadAPI
        /// </summary>
        public static class DownloadEndpoints
        {
            /// <summary>
            /// Returns the collection of all <c>Download</c> tasks.
            /// Method: GET
            /// Param: none
            /// </summary>
            public static string GetDownloadTask => "http://mafreebox.freebox.fr/api/v4/downloads/";
            /// <summary>
            /// Returns the <c>Download</c> task with the given ID.
            /// Method: GET
            /// Param: ID (replace {id} with the ID)
            /// </summary>
            public static string GetDownloadTaskByID => "http://mafreebox.freebox.fr/api/v4/downloads/{id}";
            /// <summary>
            /// Deletes the <c>Download</c> task with the given ID, without erasing the downloaded files if task failed or stopped.
            /// Method: DELETE
            /// Param: ID (replace {id} with the ID)
            /// </summary>
            public static string DeleteDownloadTaskByID => "http://mafreebox.freebox.fr/api/v4/downloads/{id}";
            /// <summary>
            /// Same as <c>DeleteDownloadTaskByID</c> but erases the downloaded files.
            /// Method: DELETE
            /// Param: ID (replace {id} with the ID)
            /// </summary>
            public static string DeleteDownloadTaskAndFileByID => "http://mafreebox.freebox.fr/api/v4/downloads/{id}/erase";
            /// <summary>
            /// Updates the <c>Download</c> task with the given ID.
            /// Method: PUT
            /// Param: ID (replace {id} with the ID)
            /// </summary>
            public static string UpdateDownloadTaskByID => "http://mafreebox.freebox.fr/api/v4/downloads/{id}";
            /// <summary>
            /// Get download log of the given ID.
            /// Method: GET
            /// Param: ID (replace {id} with the ID)
            /// </summary>
            public static string GetDownloadLogByID => "http://mafreebox.freebox.fr/api/v4/downloads/{id}/log";
            /// <summary>
            /// Can be used to add URLs (scheme: 'http://', 'ftp://', 'magnet:') or file ('.torrent', '.nzb')
            /// Method: POST
            /// Param: More info on https://dev.freebox.fr/sdk/os/download/#
            /// </summary>
            public static string AddDownload => "http://mafreebox.freebox.fr/api/v4/downloads/add";
            /// <summary>
            /// Get the download statistics.
            /// Method: GET
            /// Param: none
            /// </summary>
            public static string GetDownloadStats => "http://mafreebox.freebox.fr/api/v4/downloads/stats";
            /// <summary>
            /// Get the list of files for a given <c>Download</c>.
            /// Method: GET
            /// Param: TaskID (replace {task_id} with the TaskID)
            /// </summary>
            public static string GetDownloadListFilesByTaskID => "http://mafreebox.freebox.fr/api/v4/downloads/{task_id}/files";
            /// <summary>
            /// Change the priority of a <c>Download</c> file.
            /// Method: PUT
            /// Param: TaskID, FileID (replace {task_id} with the TaskID and {file_id} with the FileID)
            /// </summary>
            public static string SetDownloadFilePriorityByTaskID => "http://mafreebox.freebox.fr/api/v4/downloads/{task_id}/files/{file_id}";
            /// <summary>
            /// Get the list of trackers for a given <c>Download</c>.
            /// Method: GET
            /// Param: TaskID (replace {task_id} with the TaskID)
            /// </summary>
            /// <remarks>
            /// Attempting to call this method on a download other than bittorent will fail.
            /// </remarks>
            public static string GetDownloadTrackersListByTaskID => "http://mafreebox.freebox.fr/api/v4/downloads/{task_id}/tracker";
            /// <summary>
            /// Add a new tracker on a <c>Download</c>
            /// Method: POST
            /// Param: TaskID (replace {task_id} with the TaskID)
            /// </summary>
            public static string AddDownloadTrackerByTaskID => "http://mafreebox.freebox.fr/api/v4/downloads/{task_id}/trackers";
            /// <summary>
            /// Remove a tracker from a given <c>Download</c>.
            /// Method: DELETE
            /// Param: TaskID, Announce (replace {task_id} with the TaskID and {announce} with the Announce)
            /// </summary>
            public static string DeleteDownloadTrackerByTaskID => "http://mafreebox.freebox.fr/api/v4/downloads/{task_id}/trackers/{announce}";
            /// <summary>
            /// Update a tracker from a given <c>Download</c>.
            /// Method: PUT
            /// Param: TaskID, Announce (replace {task_id} with the TaskID and {announce} with the Announce)
            /// </summary>
            public static string UpdateDownloadTrackerByTaskID => "http://mafreebox.freebox.fr/api/v4/downloads/{task_id}/trackers/{announce}";
            /// <summary>
            /// Get the list of peers for a given <c>Download</c>.
            /// Method: GET
            /// Param: TaskID (replace {task_id} with the TaskID)
            /// </summary>
            /// <remarks>
            /// Attempting to call this method on a download other than bittorent will fail.
            /// </remarks>
            public static string GetDownloadPeersByTaskID => "http://mafreebox.freebox.fr/api/v4/downloads/{task_id}/peers";
            /// <summary>
            /// Get the pieces status for a given <c>Download</c>.
            /// Method: GET
            /// Param: TaskID (replace {task_id} with the TaskID)
            /// </summary>
            public static string GetDownloadPiecesByTaskID => "http://mafreebox.freebox.fr/api/v4/downloads/{task_id}/pieces";
            /// <summary>
            /// Get the blacklist entries for a given download.
            /// Method: GET
            /// Param: TaskID (replace {task_id} with the TaskID)
            /// </summary>
            ///<remarks>
            ///Attempting to call this method on a download other than bittorent will fail.
            /// </remarks> 
            public static string GetDownloadBlacklistByTaskID => "http://mafreebox.freebox.fr/api/v4/downloads/{task_id}/blacklist";
            /// <summary>
            /// Delete all the blacklist for a downloadID.
            /// Method: DELETE
            /// Param: TaskID (replace {task_id} with the TaskID)
            /// </summary>
            public static string DeleteAllDownloadBlacklistByTaskID => "http://mafreebox.freebox.fr/api/v4/downloads/{task_id}/blacklist/empty";
            /// <summary>
            /// Delet a particular blacklist entry.
            /// Method: DELETE
            /// Param: Host (replace {host} with the Host)
            /// </summary>
            public static string DeleteDownloadBlacklistByTaskID => "http://mafreebox.freebox.fr/api/v4/downloads/blacklist/{host}";
            /// <summary>
            /// Add a blacklist entry.
            /// Method: POST
            /// Param: none
            /// </summary>
            public static string AddDownloadBlacklist => "http://mafreebox.freebox.fr/api/v4/downloads/blacklist";
        }
        //TODO:FSAPI
    }
}
