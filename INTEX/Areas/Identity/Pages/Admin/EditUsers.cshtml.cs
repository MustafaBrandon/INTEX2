using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using INTEX.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace INTEX.Areas.Identity.Pages.Admin
{
    [Authorize(Policy = "RequireAdmin")]
    public class EditUsersModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public EditUsersModel(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;

            UserIds = new List<string>();
            UserNames = new List<string>();
            FirstNames = new List<string>();
            LastNames = new List<string>();
            IsSelected = new List<bool>();
        }

        [BindProperty]
        public List<string> UserIds { get; set; }

        [BindProperty]
        public List<bool> IsSelected { get; set; }

        [BindProperty]
        public string RoleId { get; set; }

        public string RoleName { get; set; }
        public List<string> UserNames { get; set; }
        public List<string> FirstNames { get; set; }
        public List<string> LastNames { get; set; }


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
                UserIds.Add(user.Id);
                UserNames.Add(user.UserName);
                FirstNames.Add(user.FirstName);
                LastNames.Add(user.LastName);

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

        public async Task<IActionResult> OnPostAsync(List<string> userIds, List<bool> isSelected, string roleId)
        {
            if (ModelState.IsValid)
            {
                var role = await _roleManager.FindByIdAsync(roleId);

                IdentityResult result = null;

                for(int i = 0; i < userIds.Count; i++)
                {
                    var user = await _userManager.FindByIdAsync(userIds[i]);

                    if (isSelected[i] && !(await _userManager.IsInRoleAsync(user, role.Name)))
                    {
                        result = await _userManager.AddToRoleAsync(user, role.Name);
                    }
                    else if (!isSelected[i] && await _userManager.IsInRoleAsync(user, role.Name))
                    {
                        result = await _userManager.RemoveFromRoleAsync(user, role.Name);
                    }
                    else
                    {
                        continue;
                    }

                    if (result.Succeeded)
                    {
                        if (i < userIds.Count)
                        {
                            continue;
                        }
                        else
                        {
                            return RedirectToPage("./RoleDetails", RoleId);
                        }
                    }
                }

                return RedirectToPage("./RoleDetails", RoleId);

            }

                return Page();
        }
    }
}
