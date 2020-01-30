using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AuthenticationProject.Pages.Guest
{
    [Authorize(Roles = "Guest")]
    public class AboutGuestModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
