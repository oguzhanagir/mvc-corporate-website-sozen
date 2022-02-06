using MvcSozenCit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSozenCit.Controllers
{
    public class CharController : Controller
    {
        // GET: Char
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult VisualizeResult()
        {
            return Json(categorylist(), JsonRequestBehavior.AllowGet);
        }
        public List<Class1> categorylist()
        {
            List<Class1> c = new List<Class1>();
            c.Add(new Class1()
            {
                CategoryName = "Çit Direği",
                ProductCount = 15
            });
            c.Add(new Class1()
            {
                CategoryName = "Bağ Direği",
                ProductCount = 8
            });
            c.Add(new Class1()
            {
                CategoryName = "Tel Örgü",
                ProductCount = 10
            });

            return c;   
        }
    }
}