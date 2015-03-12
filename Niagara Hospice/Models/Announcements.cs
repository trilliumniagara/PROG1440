using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Niagara_Hospice.Models
{
    public class Announcements
    {
        [Key]
        public int AnnouncementID { get; set; }

        [Required]
        public string Title { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PostDate { get; set; }

        [Required]
        public string AnnouncementType { get; set; }

        public string Content { get; set; }
    }
}