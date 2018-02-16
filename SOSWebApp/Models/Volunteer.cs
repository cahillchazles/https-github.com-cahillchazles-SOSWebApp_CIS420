using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOSWebApp.Models
{
    public class Volunteer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int State { get; set; }
        public string ZipCode { get; set; }
        public string PreferredName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }

        
    }
}