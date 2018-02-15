using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SOSWebApp.Models
{
    public class Events
    {
        public int ID { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime EventTime { get; set; }
        public string EventLocation { get; set; }

    }
}