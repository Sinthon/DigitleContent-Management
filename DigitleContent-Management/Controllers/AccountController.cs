using DigitleContent_Management.Models.Admin;
using DigitleContent_Management.Models.DTOs.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitleContent_Management.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signinManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signinManager)
        {
            _userManager = userManager;
            _signinManager = signinManager;
        }

        [HttpGet]
        public IActionResult Register(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ViewBag.returnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterRequest register, string returnUrl)
        {
            returnUrl ??= Url.Content("~/");
            ViewBag.returnUrl = returnUrl;
            if (ModelState.IsValid)
            {
                var user = new IdentityUser() {
                    Email = register.Email,
                    UserName = register.Username
                };

                var result = await _userManager.CreateAsync(user, register.Password);

                if (result.Succeeded)
                {
                    await _signinManager.PasswordSignInAsync(user, register.Password, false,false);
                    return LocalRedirect(returnUrl);
                }
                foreach(var r in result.Errors)
                {
                    ModelState.AddModelError("",r.Description);
                }
                return View(register);
            }
            return View(register);
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> LoginAsync(LoginRequest login)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(login.Email);
                if(user == null)
                {
                    ModelState.AddModelError("", "User does not exist.");
                    return View(login);
                }
            }

            var userlogin = new IdentityUser() { 
                Email = login.Email,
            };

            _signinManager.SignInAsync(userlogin, isPersistent: false);
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            return View();
        }
    }
}
