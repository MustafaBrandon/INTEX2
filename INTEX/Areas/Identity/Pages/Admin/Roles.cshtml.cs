using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace INTEX.Areas.Identity.Pages.Admin
{
    public class RolesModel : PageModel
    {

        private readonly RoleManager<IdentityRole> _roleManager;

        public RolesModel(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IEnumerable<IdentityRole> Roles { get; set; }

        public IActionResult OnGet()
        {
            Roles = _roleManager.Roles;

            return Page();
        }
    }
}
