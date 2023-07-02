using System;
using System.Collections.Generic;

namespace AppDeipesaAPI.Models.Dtos.Auth
{
    public partial class LoginDto
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
