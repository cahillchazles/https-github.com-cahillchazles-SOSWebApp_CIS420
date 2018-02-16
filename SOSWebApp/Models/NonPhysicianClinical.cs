using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOSWebApp.Models
{
    public class NonPhysicianClinical : Volunteer
    {
        public int ProfessionalTitle { get; set; }
        public int LicensedState { get; set; }
        public string ProfessionalLicenseNumber { get; set; }
        public int TShirtSize { get; set; }
    }
}