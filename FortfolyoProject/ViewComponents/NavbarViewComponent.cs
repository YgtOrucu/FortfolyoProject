using Microsoft.AspNetCore.Mvc;

namespace FortfolyoProject.ViewComponents
{
    public class NavbarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
