using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationProject.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AuthenticationProject.Pages.Admin
{
 
    [Authorize(Roles = "Admin")]
    public class AboutAdminModel : PageModel
    {
        public AdminUser AdminUser { get; set; }

        private readonly ApplicationDbContext _dbContext;
        public AboutAdminModel(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public async Task OnGetAsync()
        {
          

        }
    }
}
