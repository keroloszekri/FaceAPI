using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaceApp.Model;
using FaceApp.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FaceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Copy data from RegisterViewModel to IdentityUser
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email
                };

                // Store user data in AspNetUsers database table
                var result = await userManager.CreateAsync(user, model.Password);

                // If user is successfully created, sign-in the user using
                // SignInManager and redirect to index action of HomeController
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return Created("", "Register Success And User Name Is  :  " + user.UserName);
                }

                // If there are any errors, add them to the ModelState object
                // which will be displayed by the validation summary tag helper
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return Created("", "Register Failed Check Erroe and try again ");

            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        //[HttpPost]
        //[Route("/login")]
        //public async Task<IActionResult> Login(LoginViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var result = await signInManager.PasswordSignInAsync(
        //            model.Email, model.Password, model.RememberMe, false);

        //        if (result.Succeeded)
        //        {
        //            return Created("", "Login Success ");
        //        }

        //        ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
        //    }

        //    return Created("", "Failed ");
        //}
    }
}