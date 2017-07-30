using Store.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Abstact
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        Product GetProduct();
        void SaveProduct(Product product);
        Product DeleteProduct(int productId);
    }
}
