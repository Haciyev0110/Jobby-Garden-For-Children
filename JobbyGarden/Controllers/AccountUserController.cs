using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobbyGarden.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using JobbyGarden.ViewModel;
using Microsoft.AspNetCore.Http;
using JobbyGarden.Extino;
using System.IO;

namespace JobbyGarden.Controllers
{
    public class AccountUserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signManager;
        string path = Path.Combine(Directory.GetCurrentDirectory(), "usersimage");

        public AccountUserController(UserManager<User> userManager,SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signManager = signInManager;
        }
        public  IActionResult AccountIndex(string returnUrl=null)
        {
            LogOrRegster bnm = new LogOrRegster();
            bnm.Rester =new RegisterVM();
            bnm.Login = new LoginVm { ReturnUrl = returnUrl };
            
            return View(bnm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(LogOrRegster model, IFormFile Image)
        {

            if (ModelState.IsValid)
            {
                if (ModelState.IsValid)
                {
                   
                    User user = new User { Email = model.Rester.Email, Fullname = model.Rester.Fullname, UserName = model.Rester.Usernames };
                    if (Extension.CheckImg(Image, Extension.MAxfileSize))
                    {
                        try
                        {
                           user.Image = Extension.SaveImg(Image, path);
                        }
                        catch
                        {

                            ModelState.AddModelError("Img", "Img is not correct");
                        }


                    }
                    else
                    {

                        ModelState.AddModelError("Img", "Img is not correct");
                    }
                    var result = await _userManager.CreateAsync(user, model.Rester.Password);
                    if (result.Succeeded)
                    {
                        var resultAddRole= await _userManager.AddToRoleAsync(user, "User");

                        if (resultAddRole.Succeeded)
                        {
                            await _signManager.SignInAsync(user, false);
                            return RedirectToAction("Index", "Home");
                        }
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }
              

            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LogOrRegster model)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByEmailAsync(model.Login.Email);
                if (user != null)
                {
                    
                    var result =
                        await _signManager.PasswordSignInAsync(user, model.Login.Password, false, false);
                    if (result.Succeeded)
                    {
                        if (!string.IsNullOrEmpty(model.Login.ReturnUrl) && Url.IsLocalUrl(model.Login.ReturnUrl))
                        {
                            return Redirect(model.Login.ReturnUrl);
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Dont correct parol or email");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Dont correct parol or email");
                }
               



            }
            return RedirectToAction("AccountIndex","AccountUser");
        }
      
        public async Task<IActionResult> Logout()
        {
            await _signManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }



    }
}