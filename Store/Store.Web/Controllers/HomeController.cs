using Store.Common;
using Store.Domain.Abstact;
using Store.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.Web.Controllers
{
    public class HomeController : Controller
    {
        public IProductRepository respository { get; set; }
        public HomeController(IProductRepository res)
        {
            respository = res;
        }
        public ActionResult Index()
        {
            return View();
        }
        public string List()
        {
            Product product = respository.GetProduct();
            return "[" + JsonHelper.GetJson<Product>(product) + "]";
        }
    }
}