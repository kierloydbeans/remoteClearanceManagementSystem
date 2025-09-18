using System.Threading.Tasks;
using ClearanceManagementSystem.Application.Commands;
using ClearanceManagementSystem.Application.ViewModels;

namespace ClearanceManagementSystem.Application.Interfaces
{
    public interface IUserService
    {
        Task<RegisterResult> RegisterAsync(RegisterUserCommand model);
        // You can add more methods later (e.g., LoginAsync, ChangePasswordAsync)
    }
}