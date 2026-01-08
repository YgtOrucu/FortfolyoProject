using Microsoft.AspNetCore.Mvc;

namespace FortfolyoProject.ViewComponents.AdminComponents
{
    public class AdminSidebarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Views/Shared/Components/AdminComponents/AdminSidebar.cshtml");
        }
    }
}
