
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PL.Controllers
{
    public class UserController : Controller
    {
        private UserManager<IdentityUser> userManager;
        public UserController(UserManager<IdentityUser> userMgr)
        {
            userManager = userMgr;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var Users = userManager.Users.ToList();

            return View(Users);
        }

        [HttpGet]
        public async Task<IActionResult> Form(Guid? Id)
        {
            IdentityUser user = new IdentityUser();

            if (Id == null) //metodo add
            {
                return View(user);
            }
            else // update
            {
                var UserExist = await userManager.FindByIdAsync(Id.ToString()); //existencia de un rol

                user.Id = UserExist.Id;
                user.UserName = UserExist.UserName;
                //user.PhoneNumber = UserExist.PhoneNumber;
                //user.PhoneNumberConfirmed = UserExist.PhoneNumberConfirmed;
                //user.Email = UserExist.Email;
                //user.EmailConfirmed = UserExist.EmailConfirmed;
                user.PasswordHash = UserExist.PasswordHash;

                return View(user);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Form([Required] IdentityUser user)
        {
            if (ModelState.IsValid)
            {
                var UserExist = await userManager.FindByIdAsync(user.Id); //existencia de un rol
                IdentityResult result;

                if (UserExist == null) //no existe
                {
                    //add
                    result = await userManager.CreateAsync(new IdentityUser(user.UserName));
                    if (result.Succeeded)
                    {
                        return RedirectToAction("GetAll");
                    }

                }
                else
                {
                    if (UserExist.UserName != user.UserName)
                    {
                        UserExist.UserName = user.UserName;
                    }


                    result = await userManager.UpdateAsync(UserExist);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("GetAll", "User", new { Id = user.Id });
                    }
                    else
                    {
                        ModelState.AddModelError("", "No se puede realizar la accion");
                    }

                }

            }
            return View(user);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid? Id)
        {
            var user = await userManager.FindByIdAsync(Id.ToString());

            if (user != null)
            {
                var result = await userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("GetAll");
                }
            }
            else
            {
                ModelState.AddModelError("", "No se puede realizar la accion");
            }

            return View(user);

        }

    }
}
