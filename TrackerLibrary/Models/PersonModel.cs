using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {

        /// <summary>
        /// The unique identifier for the person
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The First Name of the person
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The Last Name of the person
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The EmailAddress of the person
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The CellPhoneNumber of the person
        /// </summary>
        public string CellPhoneNumber { get; set; }

        public string FullName
        {
            get
            {
                return $"{ FirstName } {LastName}";
            }
        }
    }


}
