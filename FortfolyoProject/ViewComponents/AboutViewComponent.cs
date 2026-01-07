using FortfolyoProject.DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace FortfolyoProject.ViewComponents
{
    public class AboutViewComponent : ViewComponent
    {
        PortfolyoContext context = new PortfolyoContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Abouts.FirstOrDefault();
            return View(values);
        }
    }
}
