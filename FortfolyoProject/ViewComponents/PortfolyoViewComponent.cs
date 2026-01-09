using FortfolyoProject.DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace FortfolyoProject.ViewComponents
{
    public class PortfolyoViewComponent : ViewComponent
    {
        PortfolyoContext context = new PortfolyoContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Portfolios.ToList();
            return View(values);
        }
    }
}
