using System.Threading.Tasks;
using WebApp.Application.ViewModels;

namespace WebApp.Application.Interfaces
{
    public interface IUserService
    {
        Task<RegisterResult> RegisterAsync(RegisterViewModel model);
        // You can add more methods later (e.g., LoginAsync, ChangePasswordAsync)
    }
}