using Store.Domain.Abstact;
using Store.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.Web.Controllers
{
    public class CartController : Controller
    {
        public ICartRepository respository { get; set; }
        public CartController(ICartRepository res)
        {
            respository = res;
        }
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 添加购物车
        /// </summary>
        /// <param name="ProductID"></param>
        /// <returns></returns>
        public string AddCart()
        {
            Cart carts = new Cart { ProductID=Convert.ToInt32(Request["ProductID"]),UserID="guest",Amount=1};
           return  respository.AddCart(carts);
        }
    }
}