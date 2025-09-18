using ClearanceManagementSystem.Application.Commands;
using ClearanceManagementSystem.Application.Interfaces;
using ClearanceManagementSystem.Application.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ClearanceManagementSystem.Web.Controllers
{
    public class AccountController : Controller
    {
        // The controller now depends on the IUserService interface, not the concrete implementation.
        private readonly IUserService _userService;

        // The controller is only responsible for UI logic and delegates all business logic to the service.
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        /*[HttpPost]
        public async Task<IActionResult> Register(RegisterUserCommand model)
        {
            if (ModelState.IsValid)
            {
                // Step 1: Map the ViewModel to the Command.
                // The ViewModel is for the UI, the Command is for the business logic layer.
                var command = new RegisterUserCommand
                {
                    Username = model.Username,
                    StudentNumber = model.StudentNumber,
                    Email = model.Email,
                    Course = model.Course,
                    Password = model.Password
                };

                // Step 2: Call the service from the Application layer.
                var result = await _userService.RegisterAsync(command);

                if (result.Succeeded)
                {
                    // Redirect to the login page on success.
                    return RedirectToAction("Login", "Account");
                }

                // Add any returned errors to the model state to display to the user.
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error);
                }
            }
            return View(model);
        }*/

        public IActionResult VerifyEmail()
        {
            return View();
        }
        public IActionResult ChangePassword()
        {
            return View();
        }
    }
}
