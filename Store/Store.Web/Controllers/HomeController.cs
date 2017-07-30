using Store.Common;
using Store.Domain.Abstact;
using Store.Domain.Entity;
using Store.Web.Models;
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
        /// <summary>
        /// 显示产品列表
        /// </summary>
        /// <returns></returns>
        public string List()
        {
            ProductsListViewModel model = new ProductsListViewModel();
            model.Products = respository.Products;
            return "[" + JsonHelper.GetJson<Product>(model.Products.FirstOrDefault()) + "]";
        }
    }
}