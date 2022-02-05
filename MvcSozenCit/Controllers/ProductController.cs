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
        public PartialViewResult ProductReadAll(int id)
        {
            var ProductDetailsList = pm.ProductByID(id);
            return PartialView(ProductDetailsList);
        }
        public ActionResult ProductByCategory()
        {
            return View();
        }
        public ActionResult AdminProductList()
        {
            var productlist = pm.GetAll();  
            return View(productlist);
        }
        [HttpGet]
        public ActionResult AddNewProduct()
        {
            Context c = new Context();

            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.values = values;
            return View();
        }
        [HttpPost]
        public ActionResult AddNewProduct(Product p)
        {
            pm.ProductAddBl(p);
            return RedirectToAction("AdminProductList");
        }
    }
}