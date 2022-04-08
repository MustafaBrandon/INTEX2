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
    public class EditUsersModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public EditUsersModel(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;

            Users = new List<ApplicationUser>();
            IsSelected = new List<bool>();
        }

        public List<ApplicationUser> Users { get; set; }
        public List<bool> IsSelected { get; set; }

        public string RoleId { get; set; }
        public string RoleName { get; set; }


        public async Task<IActionResult> OnGetAsync(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                return RedirectToPage("./Roles");
            }

            RoleId = role.Id;
            RoleName = role.Name;

            foreach (var user in _userManager.Users.ToList())
            {
                Users.Add(user);

                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    IsSelected.Add(true);
                }
                else
                {
                    IsSelected.Add(false);
                }
            }

            return Page();
        }
    }
}
