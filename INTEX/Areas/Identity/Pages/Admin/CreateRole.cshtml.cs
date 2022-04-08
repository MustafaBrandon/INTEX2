using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using INTEX.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

// Not Ready for Production

namespace INTEX.Areas.Identity.Pages.Admin
{
    public class CreateRoleModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public CreateRoleModel(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [Display(Name = "Role Name")]
            [DataType(DataType.Text)]
            public string RoleName { get; set; }
        }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            return RedirectToPage("./Roles");
        }

        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (ModelState.IsValid)
        //    {
        //        IdentityRole identityRole = new IdentityRole
        //        {
        //            Name = Input.RoleName
        //        };

        //        IdentityResult result = await _roleManager.CreateAsync(identityRole);

        //        if (result.Succeeded)
        //        {
        //            // Where to go after role is created?
        //            return RedirectToPage("./Roles");
        //        }

        //        foreach (IdentityError error in result.Errors)
        //        {
        //            ModelState.AddModelError("", error.Description);
        //        }

        //    }

        //    return Page();
        //}
    }
}
