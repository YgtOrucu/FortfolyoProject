using Microsoft.AspNetCore.Mvc;

namespace FortfolyoProject.ViewComponents.AdminComponents
{
    public class AdminHeadViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Views/Shared/Components/AdminComponents/AdminHead.cshtml");
        }
    }
}
