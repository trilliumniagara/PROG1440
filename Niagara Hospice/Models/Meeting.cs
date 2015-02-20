using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Niagara_Hospice.Models
{
    public class Meeting
    {
        public int MeetingID { get; set; }

        public DateTime Date { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Location { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public string Requirements { get; set; }

        public string Lead { get; set; }
    }
}