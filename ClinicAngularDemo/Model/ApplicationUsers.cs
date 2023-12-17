﻿using Microsoft.AspNetCore.Identity;

namespace ClinicAngularDemo.Model
{
    public class ApplicationUsers:IdentityUser
    {
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}
