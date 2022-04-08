using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using INTEX.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace INTEX.Areas.Identity.Pages.Admin
{
    public class EditRoleModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public EditRoleModel(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;

            Users = new List<string>();
        }

        public string Id { get; set; }

        [BindProperty]
        [Required]
        [Display(Name = "Role Name")]
        [DataType(DataType.Text)]
        public string RoleName { get; set; }

        public List<string> Users { get; set; }


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
                Users.Add(user.UserName);
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string RoleName, string Id)
        {
            if (ModelState.IsValid)
            {
                var role = await _roleManager.FindByIdAsync(Id);
                role.Name = RoleName;
                var result = await _roleManager.UpdateAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToPage("./Roles");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return Page();
        }
    }
}
