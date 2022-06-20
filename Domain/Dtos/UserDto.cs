using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dtos
{
    public class UserDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
