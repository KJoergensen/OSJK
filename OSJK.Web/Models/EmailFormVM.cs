using OSJK.Core.Enums;
using OSJK.Web.Resources;
using System.ComponentModel.DataAnnotations;

namespace OSJK.Web.Models
{
    public class EmailFormVM
    {
        [Display(Name = nameof(Strings.SYS_TO), ResourceType = typeof(Strings))]
        [Range(1, int.MaxValue, ErrorMessageResourceName = nameof(Strings.ERROR_CHOOSE_A_RECIPIENT), ErrorMessageResourceType = typeof(Strings))]
        public Contacts Contact { get; set; }

        [Display(Name = nameof(Strings.SYS_YOUR_NAME), ResourceType = typeof(Strings))]
        [Required(ErrorMessageResourceName = nameof(Strings.ERROR_NAME_MUST_BE_FILLED_OUT), ErrorMessageResourceType = typeof(Strings))]
        public string FromName { get; set; }

        [Display(Name = nameof(Strings.SYS_YOUR_EMAIL), ResourceType = typeof(Strings))]
        [EmailAddress(ErrorMessageResourceName = nameof(Strings.ERROR_EMAIL_ADDRESS_INVALID))]
        [Required(ErrorMessageResourceName = nameof(Strings.ERROR_EMAIL_MUST_BE_FILLED_OUT), ErrorMessageResourceType = typeof(Strings))]
        public string FromEmail { get; set; }

        [Display(Name = nameof(Strings.SYS_MESSAGE), ResourceType = typeof(Strings))]
        [Required(ErrorMessageResourceName = nameof(Strings.ERROR_MESSAGE_MUST_BE_FILLED_OUT), ErrorMessageResourceType = typeof(Strings))]
        public string Message { get; set; }
    }
}