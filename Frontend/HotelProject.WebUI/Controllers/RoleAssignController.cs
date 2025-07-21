using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Models.Role;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class RoleAssignController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public RoleAssignController(IAppUserService appUserService,
            UserManager<AppUser> userManager,
            RoleManager<AppRole> roleManager)
        {
            _appUserService = appUserService;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> AssignRole(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                TempData["userid"] = user.Id;
                var roles = _roleManager.Roles.ToList();
                var userRoles = await _userManager.GetRolesAsync(user);
                List<RoleAssignViewModel> roleAssignViewModels = new List<RoleAssignViewModel>();
                foreach (var role in roles)
                {
                    RoleAssignViewModel roleAssignViewModel = new RoleAssignViewModel
                    {
                        RoleName = role.Name,
                        RoleID = role.Id,
                        RoleExist = userRoles.Contains(role.Name)
                    };
                    roleAssignViewModels.Add(roleAssignViewModel);
                }
                return View(roleAssignViewModels);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AssignRole(List<RoleAssignViewModel> roleAssignViewModels)
        {
            var userId = (int) TempData["userid"];    
            var user =  _userManager.Users.FirstOrDefault(x=>x.Id==userId);
            if (user != null)
            {
                foreach (var role in roleAssignViewModels)
                {
                    if (role.RoleExist)
                    {
                        await _userManager.AddToRoleAsync(user, role.RoleName);
                    }
                    else
                    {
                        await _userManager.RemoveFromRoleAsync(user, role.RoleName);
                    }
                }

                return RedirectToAction("Index");
            }
            return View(roleAssignViewModels);  
        }
    
    }
}