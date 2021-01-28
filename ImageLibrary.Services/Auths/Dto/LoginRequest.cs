using System;
using System.Collections.Generic;
using System.Text;

namespace ImageLibrary.Services.Auths.Dto
{
    public class LoginRequest
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string RememberMe { get; set; }

    }
}
