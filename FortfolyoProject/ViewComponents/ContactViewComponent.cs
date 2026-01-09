using FortfolyoProject.DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace FortfolyoProject.ViewComponents
{
    public class ContactViewComponent :ViewComponent
    {
        PortfolyoContext context = new PortfolyoContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Contacts.FirstOrDefault();
            return View(values);
        }
    }
}
