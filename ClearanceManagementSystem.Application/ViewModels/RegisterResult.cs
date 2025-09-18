using System.Collections.Generic;

namespace ClearanceManagementSystem.Application.ViewModels
{
    public class RegisterResult
    {
        public bool Succeeded { get; set; }
        public List<string> Errors { get; set; } = new();
    }
}