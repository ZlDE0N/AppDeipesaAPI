using System;
using System.Collections.Generic;

namespace AppDeipesaAPI.Models.Dtos.Auth
{
    public partial class RegisterDto
    {
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
