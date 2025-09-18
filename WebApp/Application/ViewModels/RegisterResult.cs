using System.Collections.Generic;

namespace WebApp.Application.ViewModels
{
    public class RegisterResult
    {
        public bool Succeeded { get; set; }
        public List<string> Errors { get; set; } = new();
    }
}