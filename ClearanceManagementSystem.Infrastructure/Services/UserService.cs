using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using ClearanceManagementSystem.Application.Interfaces;
using ClearanceManagementSystem.Application.ViewModels;
using ClearanceManagementSystem.Domain.Entities;
using ClearanceManagementSystem.Application.Commands;
using System.Linq;

namespace ClearanceManagementSystem.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<Users> _userManager;

        public UserService(UserManager<Users> userManager)
        {
            _userManager = userManager;
        }

        public async Task<RegisterResult> RegisterAsync(RegisterUserCommand command)
        {
            var user = new Users
            {
                FullName = command.Username,
                StudentNumber = command.StudentNumber,
                Email = command.Email,
                Course = command.Course,
                UserName = command.Email
            };

            var result = await _userManager.CreateAsync(user, command.Password);

            return new RegisterResult
            {
                Succeeded = result.Succeeded,
                Errors = result.Errors.Select(e => e.Description).ToList()
            };
        }
    }
}