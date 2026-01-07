using Microsoft.AspNetCore.Mvc;

namespace FortfolyoProject.ViewComponents
{
    public class TestimonialViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
