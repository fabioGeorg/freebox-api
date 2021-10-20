
namespace FreeboxAPI.ContactAPI
{
    /// <summary>
    /// ContactAddress
    /// </summary>
    public class ContactAddress
    {
        /// <summary>
        /// Parameters constructor.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="contactID"></param>
        /// <param name="addressType"></param>
        /// <param name="number"></param>
        /// <param name="street"></param>
        /// <param name="city"></param>
        /// <param name="zipcode"></param>
        /// <param name="country"></param>
        /// <param name="street2"></param>
        public ContactAddress(int id, int contactID, EmailTypes addressType, string number, string street, string city, string zipcode, string country, string street2 = "")
        {
            ID = id;
            AddressType = addressType;
            Number = number;
            Street = street;
            Street2 = street2;
            City = city;
            Country = country;
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
        public EmailTypes AddressType { get; protected set; }
        /// <summary>
        /// Contact number.
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// Street
        /// </summary>
        public string Street { get; set; }
        /// <summary>
        /// Street2
        /// </summary>
        public string Street2 { get; set; }
        /// <summary>
        /// City
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// ZipCode
        /// </summary>
        public string ZipCode { get; set; }
        /// <summary>
        /// Country
        /// </summary>
        public string Country { get; set; }
    }
}
