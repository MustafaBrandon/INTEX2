using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using INTEX.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace INTEX.Areas.Identity.Pages.Admin
{
    public class RoleDetailsModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public RoleDetailsModel(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;

            UserNames = new List<string>();
            FirstNames = new List<string>();
            LastNames = new List<string>();
        }

        public List<string> UserNames { get; set; }
        public List<string> FirstNames { get; set; }
        public List<string> LastNames { get; set; }
        public string Id { get; set; }
        public string RoleName { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);

            if (role == null)
            {
                return RedirectToPage("./Roles");
            }

            Id = role.Id;
            RoleName = role.Name;

            foreach (var user in await _userManager.GetUsersInRoleAsync(RoleName))
            {
                UserNames.Add(user.UserName);
                FirstNames.Add(user.FirstName);
                LastNames.Add(user.LastName);
            }

            return Page();
        }
    }
}
