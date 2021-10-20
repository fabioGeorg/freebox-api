using System;

namespace FreeboxAPI.ContactAPI
{
    /// <summary>
    /// ContactEntry
    /// </summary>
    public class ContactEntry
    {
        /// <summary>
        /// Parameters constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="displayName"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="company"></param>
        /// <param name="photoUrl"></param>
        /// <param name="lastUpdate"></param>
        /// <param name="notes"></param>
        /// <param name="addresses"></param>
        /// <param name="emails"></param>
        /// <param name="numbers"></param>
        /// <param name="urls"></param>
        public ContactEntry(int id, string displayName, string firstName, string lastName, string company,
            string photoUrl, DateTime lastUpdate, string notes, ContactAddress[] addresses = null, ContactEmail[] emails = null, ContactNumber[] numbers = null, ContactURL[] urls = null)
        {
            ID = id;
            DisplayName = displayName;
            FirstName = firstName;
            LastName = lastName;
            Company = company;
            PhotoURL = photoUrl;
            LastUpdate = lastUpdate;
            Notes = notes;
            Addresses = addresses;
            Emails = emails;
            Numbers = numbers;
            URLs = urls;
        }

        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; protected set; }
        /// <summary>
        /// DisplayName
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// FirstName
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// LastName
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Company
        /// </summary>
        public string Company { get; set; }
        /// <summary>
        /// PhotoURL
        /// </summary>
        public string PhotoURL { get; set; }
        /// <summary>
        /// LastUpdate
        /// </summary>
        public DateTime LastUpdate { get; set; }
        /// <summary>
        /// Notes
        /// </summary>
        public string Notes { get; set; }
        /// <summary>
        /// Addresses
        /// </summary>
        public ContactAddress[] Addresses { get; set; }
        /// <summary>
        /// Emails
        /// </summary>
        public ContactEmail[] Emails { get; set; }
        /// <summary>
        /// Numbers
        /// </summary>
        public ContactNumber[] Numbers { get; set; }
        /// <summary>
        /// URLs
        /// </summary>
        public ContactURL[] URLs { get; set; }
    }
}
