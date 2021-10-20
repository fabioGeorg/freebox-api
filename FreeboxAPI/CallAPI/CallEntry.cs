using System;

namespace FreeboxAPI.CallAPI
{
    /// <summary>
    /// CallEntry
    /// </summary>
    public class CallEntry
    {
        /// <summary>
        /// Paramer constructor.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="callType"></param>
        /// <param name="dateTime"></param>
        /// <param name="number"></param>
        /// <param name="name"></param>
        /// <param name="duration"></param>
        /// <param name="new"></param>
        /// <param name="contactID"></param>
        public CallEntry(int id, CallTypes callType, DateTime dateTime, string number, string name, int duration, bool @new, int contactID)
        {
            ID = id;
            CallType = callType;
            DateTime = dateTime;
            Number = number;
            Name = name;
            Duration = duration;
            New = @new;
            ContactID = contactID;
        }

        /// <summary>
        /// Call ID.
        /// </summary>
        public int ID { get; protected set; }
        /// <summary>
        /// Call type.
        /// </summary>
        public CallTypes CallType { get; protected set; }
        /// <summary>
        /// Call creation timestamp.
        /// </summary>
        public DateTime DateTime { get; protected set; }
        /// <summary>
        /// Callee number for outgoing calls. Caller number for incoming calls.
        /// </summary>
        public string Number { get; protected set; }
        /// <summary>
        /// Callee name for outgoing calls. Caller name for incoming calls.
        /// For incoming call if the network does not provide a contact name, we try to use the contact database to find a suitable name.
        /// </summary>
        public string Name { get; protected set; }
        /// <summary>
        /// Call duration in seconds.
        /// </summary>
        public int Duration { get; protected set; }
        /// <summary>
        /// Call entry as not been acknowledged yet.
        /// </summary>
        public bool New { get; protected set; }
        /// <summary>
        /// If the number matches an entry in the contact database, the id of the matching contact.
        /// </summary>
        public int ContactID { get; protected set; }

    }
}
