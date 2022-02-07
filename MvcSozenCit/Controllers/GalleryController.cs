using BusinessLayer.Concrete;

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
    }
}