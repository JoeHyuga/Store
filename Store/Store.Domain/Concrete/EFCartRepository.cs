using Store.Domain.Abstact;
using Store.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Concrete
{
    public class EFCartRepository : ICartRepository
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<Cart> Carts
        {
            get { return context.Carts; }
        }
        public string AddCart(Cart cart)
        {
            Cart VailCart = context.Carts.Find(cart);
            if (VailCart != null)
            {

            }
            else
            {

            }
            return "";
        }
    }
}
