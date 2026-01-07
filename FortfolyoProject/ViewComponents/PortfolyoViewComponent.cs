using Microsoft.AspNetCore.Mvc;

namespace FortfolyoProject.ViewComponents
{
    public class PortfolyoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
