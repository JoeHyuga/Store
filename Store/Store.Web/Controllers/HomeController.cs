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
            Product product=respository.GetProduct();
            return View();
        }
    }
}