using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ML;
using System.ComponentModel.DataAnnotations;

namespace PL.Controllers
{
    public class RolController : Controller
    {
        private RoleManager<IdentityRole> roleManager;
        public RolController(RoleManager<IdentityRole> roleMgr)
        {
            roleManager = roleMgr;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var Roles = roleManager.Roles.ToList();

            return View(Roles);
        }

        [HttpGet]
        public async Task<IActionResult> Form(Guid? Id)
        {
            IdentityRole role = new IdentityRole();

            if (Id == null) //metodo add
            {
                return View(role);
            }
            else // update
            {
                var rolExist = await roleManager.FindByIdAsync(Id.ToString()); //existencia de un rol

                role.Id = rolExist.Id;
                role.Name = rolExist.Name;

                return View(role);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Form([Required] IdentityRole rol)
        {
            if (ModelState.IsValid)
            {
                var rolExist = await roleManager.FindByIdAsync(rol.Id); //existencia de un rol
                IdentityResult result;

                if (rolExist == null) //no existe
                {
                    //add
                    result = await roleManager.CreateAsync(new IdentityRole(rol.Name));
                    if (result.Succeeded)
                    {
                        return RedirectToAction("GetAll");
                    }
                   
                }
                else
                {
                    if (rolExist.Name != rol.Name)
                    {
                        rolExist.Name = rol.Name;
                    }
                        

                    result = await roleManager.UpdateAsync(rolExist);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("GetAll", "Rol", new { Id = rol.Id });
                    }
                    else
                    {
                        ModelState.AddModelError("", "No se puede realizar la accion");
                    }
                                                  
                }
                               
            }
            return View(rol);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid? Id)
        {
            var role = await roleManager.FindByIdAsync(Id.ToString());
            
            if (role != null)
            {
                var result = await roleManager.DeleteAsync(role);
                if (result.Succeeded)
                {  
                    return RedirectToAction("GetAll");
                }                    
            }
            else
            {
                ModelState.AddModelError("", "No se puede realizar la accion");
            }
               
            return View(role);

        }

    }
}