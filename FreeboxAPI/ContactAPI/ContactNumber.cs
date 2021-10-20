
namespace FreeboxAPI.ContactAPI
{
    /// <summary>
    /// ContactNumber
    /// </summary>
    public class ContactNumber
    {
        /// <summary>
        /// Parameters constructor.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="contactID"></param>
        /// <param name="numberType"></param>
        /// <param name="number"></param>
        /// <param name="isDefault"></param>
        /// <param name="isOwn"></param>
        public ContactNumber(int id, int contactID, NumberTypes numberType, string number, bool isDefault, bool isOwn)
        {
            ID = id;
            ContactID = contactID;
            NumberType = numberType;
            Number = number;
            IsDefault = isDefault;
            IsOwn = isOwn;
        }

        /// <summary>
        /// Address ID
        /// </summary>
        public int ID { get; protected set; }
        /// <summary>
        /// ID of the related contact.
        /// </summary>
        public int ContactID { get; protected set; }
        /// <summary>
        /// Type of number.
        /// </summary>
        public NumberTypes NumberType { get; set; }
        public string Number { get; set; }
        /// <summary>
        /// Is this number the preferred contact phone number.
        /// </summary>
        public bool IsDefault { get; set; }
        /// <summary>
        /// Is this number the Freebox owner number.
        /// </summary>
        public bool IsOwn { get; set; }
    }
}
