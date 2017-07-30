﻿using Store.Domain.Abstact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Domain.Entity;

namespace Store.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        EFDbContext context = new EFDbContext();
        public Product GetProduct()
        {
            Product pro = new Product { ProductID = 1, Name = "Auto", Description = "Fucking Great", Price = 2000, Count = "30" };
            return pro;
        }
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }

        public Product DeleteProduct(int productId)
        {
            Product dbProduct = context.Products.Find(productId);
            return dbProduct;
        }

        public void SaveProduct(Product product)
        {
            
        }
    }
}
