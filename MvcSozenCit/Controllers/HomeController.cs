using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSozenCit.Controllers
{
    public class HomeController : Controller
    {

        ProductManager pm = new ProductManager();
        AboutManager abm = new AboutManager();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult MainPageHeader()
        {
            return PartialView();
        }
        public PartialViewResult ProductList()
        {
            var productlist = pm.GetAll();
            return PartialView(productlist);
        }
        public PartialViewResult ServicesList()
        {
            return PartialView();
        }

        public PartialViewResult Newsletter()
        {
            return PartialView();
        }

        public PartialViewResult Footer()
        {
            var aboutcontentlist = abm.GetAll();
            return PartialView(aboutcontentlist);
        }


    }
}