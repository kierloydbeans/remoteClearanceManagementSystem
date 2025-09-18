using System.ComponentModel.DataAnnotations;
namespace ClearanceManagementSystem.Web.ViewModels
{
    public class VerifyEmailViewmodel
    {
        [Required(ErrorMessage = "Email is Required.")]
        [EmailAddress]
        public String Email { get; set; }
    }
}
