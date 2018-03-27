using System.ComponentModel.DataAnnotations;
using System.Web;

namespace MVCEmail.Models
{
    public class EmailFormModel
    {
        public bool IsPhysicianOnly { get; set; }
        public bool IsClinicalOnly { get; set; }
        public bool IsGeneralOnly { get; set; }
        public bool IsInterpreterOnly { get; set; }
        [Required, Display(Name = "Your name")]
        public string FromName { get; set; }

        [Display(Name = "Your email"), EmailAddress]
        public string FromEmail { get; set; }

        [Required]
        public string Message { get; set; }

        public HttpPostedFileBase Upload { get; set; }
    }
}