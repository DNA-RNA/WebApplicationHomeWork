using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplicationHomeWork.Models;

namespace WebApplicationHomeWork.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {

        private UserManager<ViewModel> userManager;
        private SignInManager<ViewModel> signInManager;

        public AccountController(UserManager<ViewModel> userMgr, SignInManager<ViewModel> signinMgr)
        {
            userManager = userMgr;
            signInManager = signinMgr;
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            Login login = new Login();
            login.ReturnUrl = returnUrl;
            return View(login);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Login login)
        {
            if (ModelState.IsValid)
            {
                ViewModel appUser = await userManager.FindByNameAsync(login.UserName);
                if (appUser != null)
                {
                    await signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(appUser, login.Password, false, false);
                    if (result.Succeeded)
                        return Redirect(login.ReturnUrl ?? "/");
                }
                ModelState.AddModelError(nameof(login.UserName), "Login Failed: Invalid Email or password");
            }
            return View(login);
        }

    }
}
