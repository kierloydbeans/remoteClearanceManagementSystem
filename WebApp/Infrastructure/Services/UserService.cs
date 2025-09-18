using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using WebApp.Application.Interfaces;
using WebApp.Application.ViewModels;
using WebApp.Domain.Entities;
using System.Linq;

namespace WebApp.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<Users> _userManager;

        public UserService(UserManager<Users> userManager)
        {
            _userManager = userManager;
        }

        public async Task<RegisterResult> RegisterAsync(RegisterViewModel model)
        {
            var user = new Users
            {
                FullName = model.Username,
                StudentNumber = model.StudentNumber,
                Email = model.Email,
                Course = model.Course,
                UserName = model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            return new RegisterResult
            {
                Succeeded = result.Succeeded,
                Errors = result.Errors.Select(e => e.Description).ToList()
            };
        }
    }
}