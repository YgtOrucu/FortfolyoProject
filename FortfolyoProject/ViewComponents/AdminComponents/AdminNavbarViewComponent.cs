using Microsoft.AspNetCore.Mvc;

namespace FortfolyoProject.ViewComponents.AdminComponents
{
    public class AdminNavbarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Views/Shared/Components/AdminComponents/AdminNavbar.cshtml");
        }
    }
}
