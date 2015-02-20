using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Niagara_Hospice.Models
{
    public class AspNetSubRoles
    {
        public int ID { get; set; }

        [Required]
        [StringLength(256)]
        public string SubRole { get; set; }
    }
}