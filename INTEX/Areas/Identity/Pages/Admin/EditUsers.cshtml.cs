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
        public List<string> UserIds { get; set; }
        public List<string> UserNames { get; set; }
        public List<string> FirstNames { get; set; }
        public List<string> LastNames { get; set; }

        public string RoleId { get; set; }
        public bool IsSelected { get; set; }

        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public EditUsersModel(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        //public async Task<IActionResult> OnGetAsync(string roleId)
        //{
        //    var role = await _roleManager.FindByIdAsync(roleId);

        //    if (role == null)
        //    {
        //        return RedirectToPage("./Roles");
        //    }

        //    foreach (var user in _userManager.Users)
        //    {
        //        UserIds.Add(user.Id);
        //        UserNames.Add(user.UserName);
        //        FirstNames.Add(user.FirstName);
        //        LastNames.Add(user.LastName);
        //    }


        //}
    }
}
