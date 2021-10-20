
namespace FreeboxAPI.ContactAPI
{
    /// <summary>
    /// ContactEmail
    /// </summary>
    public class ContactEmail
    {
        /// <summary>
        /// Parameters constructor.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="contactID"></param>
        /// <param name="emailType"></param>
        /// <param name="email"></param>
        public ContactEmail(int id, int contactID, EmailTypes emailType, string email)
        {
            ID = id;
            ContactID = contactID;
            EmailType = emailType;
            Email = email;
        }

        /// <summary>
        /// Address ID.
        /// </summary>
        public int ID { get; protected set; }
        /// <summary>
        /// ID of the related contact.
        /// </summary>
        public int ContactID { get; protected set; }
        /// <summary>
        /// Type of address.
        /// </summary>
        public EmailTypes EmailType { get; set; }
        /// <summary>
        /// Email address.
        /// </summary>
        public string Email { get; set; }
    }
}
