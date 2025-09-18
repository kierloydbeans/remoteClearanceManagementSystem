using Microsoft.AspNetCore.Identity;

namespace ClearanceManagementSystem.Domain.Entities
{
    public class Users: IdentityUser

    {
        public string FullName { get; set; }
        public string Course { get; set; } 
        public string StudentNumber { get; set; } 
    
    }
}
