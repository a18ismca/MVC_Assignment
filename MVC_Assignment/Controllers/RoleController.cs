using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Assignment.Models;
using MVC_Assignment.ViewModels;

namespace MVC_Assignment.Controllers
{
    [Authorize(Roles = "Admin")]

    public class RoleController : Controller
    {

        readonly RoleManager<IdentityRole> _roleManager;
        readonly UserManager<AppUser> _userManager;

        public RoleController(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var roles = _roleManager.Roles;
            return View(roles);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole role)
        {
            role.NormalizedName = role.Name.ToUpper();
            await _roleManager.CreateAsync(role);
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> Delete(string id)
        {
            IdentityRole role = await _roleManager.FindByIdAsync(id);
            await _roleManager.DeleteAsync(role);
            return RedirectToAction("Index");
        }

        public IActionResult AddRoleToUser()
        {
            ViewBag.UserSelect = new SelectList(_userManager.Users, "Id", "UserName");
            ViewBag.RoleSelect = new SelectList(_roleManager.Roles, "Name", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRoleToUser(string userId, string roleName)
        {
            var user = await _userManager.FindByIdAsync(userId);
            await _userManager.AddToRoleAsync(user, roleName);

            return RedirectToAction("Index");
        }

        public IActionResult ShowAllUsers()
        {
            return View(_userManager.Users);
        }

        public async Task<IActionResult> ShowUserRoles(string Id)
        {
            UserRoleVM vm = new UserRoleVM();
            var user = await _userManager.FindByIdAsync(Id);

            var assignedRoles = new List<string>(await _userManager.GetRolesAsync(user));
            vm.UserId = Id;
            vm.UserName = user.UserName;

            vm.Roles.AddRange(assignedRoles);

            return View(vm);
        }
        public async Task<IActionResult> RemoveRoleFromUser(string rolename, string userid)
        {
            // Find and get id
            var user = await _userManager.FindByIdAsync(userid);

            // remove id from rolename
            await _userManager.RemoveFromRoleAsync(user, rolename);

            return RedirectToAction("ShowUserRoles", new { id = userid });
        }

    }
}
