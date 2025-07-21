using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Models.Role;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;

        public RoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }

        [HttpGet]   
        public IActionResult AddRole()
        {
            return View();  
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(AddRoleViewModel addRoleViewModel)
        {
            AppRole appRole = new AppRole { 
                Name = addRoleViewModel.RoleName,
            };

           var result =  await _roleManager.CreateAsync(appRole);

            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> DeleteRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role !=null)
            {
                var result = await _roleManager.DeleteAsync(role);
                if (result.Succeeded) { return RedirectToAction("Index"); } 
            }
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> UpdateRole(int id)
        {
            var role = await _roleManager.FindByIdAsync(id.ToString());
            UpdateRoleViewModel updateRoleViewModel1 = new UpdateRoleViewModel { 
                RoleID = role.Id.ToString(),
                RoleName = role.Name,   
            }; 
            return View(updateRoleViewModel1);
        }


        [HttpPost]
        public async Task<IActionResult> UpdateRole(UpdateRoleViewModel updateRoleViewModel)
        {
            var role = await _roleManager.FindByIdAsync(updateRoleViewModel.RoleID);
            if (role != null)
            {
                role.Name = updateRoleViewModel.RoleName;
                var result = await _roleManager.UpdateAsync(role);
                if (result.Succeeded) { return RedirectToAction("Index"); }
            }
            return View();
        }
    }
}
