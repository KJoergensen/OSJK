using OSJK.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OSJK.Web.Models
{
    public class EmailFormVM
    {
        [Display(Name = "Til")]
        [Range(1, int.MaxValue, ErrorMessage = "Der skal vælges en modtager")]
        public Contacts Contact { get; set; }

        [Display(Name = "Dit navn")]
        [Required(ErrorMessage = "Navn skal udfyldes")]
        public string FromName { get; set; }

        [Display(Name = "Din email")]
        [EmailAddress(ErrorMessage = "Email adressen er ufyldig")]
        [Required(ErrorMessage = "Email skal udfyldes")]
        public string FromEmail { get; set; }

        [Display(Name = "Besked")]
        [Required(ErrorMessage = "Besked skal udfyldes")]
        public string Message { get; set; }
    }
}