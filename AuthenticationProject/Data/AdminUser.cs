using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationProject.Data
{
    public class AdminUser : IdentityUser
    {
        public string Rank { get; set; }

    }
}
