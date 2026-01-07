using FortfolyoProject.DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace FortfolyoProject.ViewComponents
{
    public class SkillsViewComponent : ViewComponent
    {
        PortfolyoContext context = new PortfolyoContext();

        public IViewComponentResult Invoke()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
    }
}
