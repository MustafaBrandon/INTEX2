using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace INTEX.Areas.Identity.Pages.Admin
{
    public class DeleteRoleModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public DeleteRoleModel(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

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

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);

            if (role == null)
            {
                return RedirectToPage("./Roles");
            }

            var result = await _roleManager.DeleteAsync(role);

            if (result.Succeeded)
            {
                return RedirectToPage("./Roles");
            }

            return Page();
        }
    }
}
