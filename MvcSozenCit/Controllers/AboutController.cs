using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSozenCit.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        AboutManager abm = new AboutManager();
        // GET: About
        public ActionResult Index()
        {
            
            return View();
        }
        public PartialViewResult AboutContent1()
        {
            var aboutcontent1 = abm.GetAll();
            return PartialView(aboutcontent1);
        }
        public PartialViewResult AboutContent2()
        {
            var aboutcontent2 = abm.GetAll();
            return PartialView(aboutcontent2);
        }

        public PartialViewResult MainAbout()
        {
            var aboutcontentlist = abm.GetAll();
            return PartialView(aboutcontentlist);
        }
        public ActionResult UpdateAboutList()
        {
            var aboutlist = abm.GetAll();

            return View(aboutlist);

        }
        [HttpPost]
        public ActionResult UpdateAbout(About p)
        {
            abm.UpdateAboutBM(p);
            return RedirectToAction("UpdateAboutList");
        }
    }
}