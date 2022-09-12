﻿using Microsoft.AspNetCore.Identity;

namespace MVC_Assignment.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set;  }
    }
}
