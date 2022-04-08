using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using INTEX.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

// Not Ready for Production

namespace INTEX.Areas.Identity.Pages.Admin
{
    [Authorize(Policy = "RequireAdmin")]
    public class UpdateRoleModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public UpdateRoleModel(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public string Id { get; set; }

        [BindProperty]
        [Required]
        [Display(Name = "Role Name")]
        [DataType(DataType.Text)]
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

        public async Task<IActionResult> OnPostAsync(string RoleName, string Id)
        {
            if (ModelState.IsValid)
            {
                var role = await _roleManager.FindByIdAsync(Id);
                role.Name = RoleName;
                var result = await _roleManager.UpdateAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToPage("./RoleDetails", new { id = Id });
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
