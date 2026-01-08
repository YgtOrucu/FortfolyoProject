using Microsoft.AspNetCore.Mvc;

namespace FortfolyoProject.ViewComponents.AdminComponents
{
    public class AdminScriptViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Views/Shared/Components/AdminComponents/AdminScript.cshtml");
        }
    }
}
