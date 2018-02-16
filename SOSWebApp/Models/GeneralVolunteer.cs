using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOSWebApp.Models
{
    public class GeneralVolunteer : Volunteer 
    {
        public string Employer { get; set; }
        public int DescribesYou { get; set; }
        public int Interests { get; set;}
        public int TShirtSize { get; set; }
    }
}