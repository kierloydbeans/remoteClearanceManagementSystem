using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearanceManagementSystem.Application.Commands
{
    public class RegisterUserCommand
    {
        public string Username { get; set; }
        public string StudentNumber { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public string Password { get; set; }
    }
}
