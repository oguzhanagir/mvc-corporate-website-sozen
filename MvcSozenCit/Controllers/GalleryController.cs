using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSozenCit.Controllers
{
    [AllowAnonymous]
    public class GalleryController : Controller
    {
        GalleryManager gm = new GalleryManager();
        // GET: Gallery
       
        public ActionResult Index()
        {
            var gallerylist = gm.GetAll();
            return View(gallerylist);
        }
        public ActionResult AdminGallery()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AdminGalleryAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminCategoryAdd(Gallery p)
        {
            gm.GalleryAddBl(p);
            return RedirectToAction("AdminGallery");
        }
    }
}