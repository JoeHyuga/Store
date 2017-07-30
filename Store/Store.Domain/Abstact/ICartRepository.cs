using Store.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Abstact
{
    public interface ICartRepository
    {
        IEnumerable<Cart> Carts { get; }
        string AddCart(Cart cart);
    }
}
