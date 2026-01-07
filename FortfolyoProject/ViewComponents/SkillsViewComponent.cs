using Microsoft.AspNetCore.Mvc;

namespace FortfolyoProject.ViewComponents
{
    public class SkillsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
