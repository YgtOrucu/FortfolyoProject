using Microsoft.AspNetCore.Mvc;

namespace FortfolyoProject.ViewComponents.AdminComponents
{
    public class AdminFooterViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Views/Shared/Components/AdminComponents/AdminFooter.cshtml");
        }
    }
}
