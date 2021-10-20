using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeboxAPI.ContactAPI
{
    public enum ContactErrors
    {
        /// <summary>
        /// No entry with this id.
        /// </summary>
        noent,
        /// <summary>
        /// An entry already exists.
        /// </summary>
        exists,
        /// <summary>
        /// No entry matched your request.
        /// </summary>
        no_match
    }
}
