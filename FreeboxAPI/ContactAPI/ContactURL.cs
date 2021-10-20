
namespace FreeboxAPI.ContactAPI
{
    /// <summary>
    /// ContactURL
    /// </summary>
    public class ContactURL
    {
        /// <summary>
        /// Parameters constructor.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="contactID"></param>
        /// <param name="urlType"></param>
        /// <param name="url"></param>
        public ContactURL(int id, int contactID, URLTypes urlType, string url)
        {
            ID = id;
            ContactID = contactID;
            URLType = urlType;
            URL = url;
        }

        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; protected set; }
        /// <summary>
        /// ContactID
        /// </summary>
        public int ContactID { get; protected set; }
        /// <summary>
        /// URLType
        /// </summary>
        public URLTypes URLType { get; set; }
        /// <summary>
        /// URL
        /// </summary>
        public string URL { get; set; }
    }
}
