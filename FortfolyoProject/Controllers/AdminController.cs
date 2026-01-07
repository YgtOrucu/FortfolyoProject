using Microsoft.AspNetCore.Mvc;

namespace FortfolyoProject.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult IndexLayout()
        {
            return View();
        }


        public IActionResult Experience()
        {
            return View();
        }
    }
}
