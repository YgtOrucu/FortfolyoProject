using Microsoft.AspNetCore.Mvc;

namespace FortfolyoProject.ViewComponents
{
    public class StatisticViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
