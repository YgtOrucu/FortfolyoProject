using FortfolyoProject.DataAccessLayer.Context;
using FortfolyoProject.DataAccessLayer.Modal;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace FortfolyoProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        PortfolyoContext context = new PortfolyoContext();
        public IActionResult SıgnIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SıgnIn(SıgnInModal s)
        {
            var getadmin = context.Admins.Where(x => x.Mail == s.Mail && x.Password == s.Password).ToList();

            if (getadmin.Count != 0)
            {
                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, getadmin[0].Mail),
                        new Claim("NameSurname", getadmin[0].Name + getadmin[0].Surname),
                        new Claim("Role", getadmin[0].RoleType)
                    };

                var claimsIdentity = new ClaimsIdentity(
                    claims,
                    CookieAuthenticationDefaults.AuthenticationScheme
                );

                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = false // remember me isterse true
                };

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties
                );
                return RedirectToAction("Admin", "Admin");
            }
            else
            {
                return View(s);
            }
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme
            );

            HttpContext.Session.Clear();

            return RedirectToAction("HomePage", "Users");
        }

    }
}
