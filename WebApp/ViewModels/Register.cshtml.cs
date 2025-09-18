using ClearanceManagementSystem.Application.Commands;
using ClearanceManagementSystem.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace ClearanceManagementSystem.Web.ViewModels
{
    public class RegisterModel : PageModel
    {
        private readonly IUserService _userService;

        public RegisterModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public RegisterViewModel Register { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // The model (the RegisterViewModel) is automatically bound here
            if (!ModelState.IsValid)
            {
                // If invalid, return the current page with the view model
                return Page();
            }

            // Correctly map the ViewModel to the Command
            var command = new RegisterUserCommand
            {
                Username = Register.Username,
                StudentNumber = Register.StudentNumber,
                Email = Register.Email,
                Course = Register.Course,
                Password = Register.Password
            };

            // Call the service with the Command
            var result = await _userService.RegisterAsync(command);

            if (result.Succeeded)
            {
                return RedirectToPage("/Account/Login");
            }

            // Add the errors to the ModelState.
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error);
            }

            // Return the page to display the errors. No model is passed here.
            return Page();
        }
    }
}