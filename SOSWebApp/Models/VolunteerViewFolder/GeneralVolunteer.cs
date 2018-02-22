using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SOSWebApp.Models.VolunteerViewFolder
{
    public class GeneralVolunteer
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Preferred Name")]
        public string PreferredName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }

        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public DateTime Birthday { get; set; }

        [Display(Name = "T Shirt Size")]
        public string tShirtSize { get; set; }

        public string Employer { get; set; }

        [Display(Name = "Education Level")]
        public string DescribesYou { get; set; }

        [Display(Name = "Personal Interests")]
        public string Interest { get; set; }

    }
}