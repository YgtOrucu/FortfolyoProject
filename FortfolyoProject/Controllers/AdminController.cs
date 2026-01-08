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

        #region Skill
        public IActionResult Skill()
        {
            var values = context.Skills.ToList();
            return View(values);
        }

        #region Add

        public IActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Skills s)
        {
            context.Skills.Add(s);
            context.SaveChanges();
            return RedirectToAction("Skill");
        }

        #endregion

        #region Delete

        public IActionResult DeleteSkill(int id)
        {
            var deletedvalue = context.Skills.Find(id);
            context.Skills.Remove(deletedvalue);
            context.SaveChanges();
            return RedirectToAction("Skill");
        }
        #endregion

        #region EditAndUpdate

        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            var values = context.Skills.Find(id);
            return View("EditSkill", values);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skills s)
        {
            context.Skills.Update(s);
            context.SaveChanges();
            return RedirectToAction("Skill");
        }

        #endregion

        #endregion 

        #region Feature
        public IActionResult Feature()
        {
            var values = context.Features.ToList();
            return View(values);
        }

        #region Add

        public IActionResult AddFeature()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddFeature(Feature f)
        {
            context.Features.Add(f);
            context.SaveChanges();
            return RedirectToAction("Feature");
        }

        #endregion

        #region Delete

        public IActionResult DeleteFeature(int id)
        {
            var deletedvalue = context.Features.Find(id);
            context.Features.Remove(deletedvalue);
            context.SaveChanges();
            return RedirectToAction("Feature");
        }
        #endregion

        #region EditAndUpdate

        [HttpGet]
        public IActionResult EditFeature(int id)
        {
            var values = context.Features.Find(id);
            return View("EditFeature", values);
        }

        [HttpPost]
        public IActionResult UpdateFeature(Feature f)
        {
            context.Features.Update(f);
            context.SaveChanges();
            return RedirectToAction("Feature");
        }

        #endregion

        #endregion 

        #region Contact
        public IActionResult Contact()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }

        #region Add

        public IActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddContact(Contact c)
        {
            context.Contacts.Add(c);
            context.SaveChanges();
            return RedirectToAction("Contact");
        }

        #endregion

        #region Delete

        public IActionResult DeleteContact(int id)
        {
            var deletedvalue = context.Contacts.Find(id);
            context.Contacts.Remove(deletedvalue);
            context.SaveChanges();
            return RedirectToAction("Contact");
        }
        #endregion

        #region EditAndUpdate

        [HttpGet]
        public IActionResult EditContact(int id)
        {
            var values = context.Contacts.Find(id);
            return View("EditContact", values);
        }

        [HttpPost]
        public IActionResult UpdateContact(Contact c)
        {
            context.Contacts.Update(c);
            context.SaveChanges();
            return RedirectToAction("Contact");
        }

        #endregion

        #endregion
    }
}
