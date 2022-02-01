using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSozenCit.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult ProductList()
        {
            return PartialView();
        }
     
        public PartialViewResult Newsletter()
        {
            return PartialView();
        }
        public PartialViewResult Footer()
        {
            return PartialView();
        }
    }
}