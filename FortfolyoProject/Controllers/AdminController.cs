using FortfolyoProject.DataAccessLayer.Context;
using FortfolyoProject.DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FortfolyoProject.Controllers
{
    public class AdminController : Controller
    {
        PortfolyoContext context = new PortfolyoContext();
        public IActionResult IndexLayout()
        {
            return View();
        }

        #region About
        public IActionResult About()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }

        #region Add

        public IActionResult AddAbout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAbout(About a)
        {
            context.Abouts.Add(a);
            context.SaveChanges();
            return RedirectToAction("About");
        }

        #endregion

        #region Delete

        public IActionResult DeleteAbout(int id)
        {
            var deletedvalue = context.Abouts.Find(id);
            context.Abouts.Remove(deletedvalue);
            context.SaveChanges();
            return RedirectToAction("About");
        }
        #endregion

        #region EditAndUpdate

        [HttpGet]
        public IActionResult EditAbout(int id)
        {
            var values = context.Abouts.Find(id);
            return View("EditAbout", values);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About a)
        {
            context.Abouts.Update(a);
            context.SaveChanges();
            return RedirectToAction("About");
        }

        #endregion

        #endregion

        #region Experience
        public IActionResult Experience()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }

        #region Add

        public IActionResult AddExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience e)
        {
            context.Experiences.Add(e);
            context.SaveChanges();
            return RedirectToAction("Experience");
        }

        #endregion

        #region Delete

        public IActionResult DeleteExperience(int id)
        {
            var deletedvalue = context.Experiences.Find(id);
            context.Experiences.Remove(deletedvalue);
            context.SaveChanges();
            return RedirectToAction("Experience");
        }
        #endregion

        #region EditAndUpdate

        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            var values = context.Experiences.Find(id);
            return View("EditExperience", values);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience e)
        {
            context.Experiences.Update(e);
            context.SaveChanges();
            return RedirectToAction("Experience");
        }

        #endregion

        #endregion
    }
}
