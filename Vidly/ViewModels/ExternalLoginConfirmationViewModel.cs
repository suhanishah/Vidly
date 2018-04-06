using System.ComponentModel.DataAnnotations;

namespace Vidly.ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name="Driving License")]
        public string DrivingLicence { get; set; }

        [Required]
        [Display(Name="Phone Number")]
        public string CustomerPhoneNumer { get; set; }
    }
}