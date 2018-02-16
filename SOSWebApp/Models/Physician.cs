using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOSWebApp.Models
{
    public class Physician : Volunteer
    {
        public string MedicalSpecialty { get; set; }
        public int LicensedState { get; set; }
        public string LincenseNumber { get; set; }
        public string ProfessionalAlmaMater { get; set; }
        public string GraduationDate { get; set; }
    }
}