using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LukeFrahm.Web.HomePage.Models
{
    public class Email
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        public string Reason { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required] 
        public string Body { get; set; }
    }
}
