using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSozenCit.Controllers
{
    public class ProductController : Controller
    {
        ProductManager pm = new ProductManager();
        // GET: Product
        public ActionResult Index()
        {
            var productlist = pm.GetAll();
            return View(productlist);
        }

        public ActionResult ProductDetails()
        {
            return View();
        }
        public PartialViewResult ProductCover()
        {
            return PartialView();
        }
        public PartialViewResult ProductReadAll()
        {
            return PartialView();
        }
        public ActionResult ProductByCategory()
        {
            return View();
        }
    }
}