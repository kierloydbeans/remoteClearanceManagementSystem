using System.ComponentModel.DataAnnotations;
namespace WebApp.ViewModels

{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email is Required.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Student Number is Required.")]
        [Display(Name = "Student Number")]
        public string? StudentNumber { get; set; }

        [Display(Name = "Remember Me?")]
        public bool RememberMe { get; set; }

        [Required(ErrorMessage = "Course is Required.")]
        public string Course { get; set; }
    }
}
