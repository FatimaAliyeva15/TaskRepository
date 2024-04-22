using Core.AccessDataLayer;
using Core.Models;
using Core.Repositories.Abstracts;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Concretes
{
    public class ProductRepository : IProductRepository
    {
        public void Add(Product product)
        {
            AppDb.Products.Add(product);
        }

        public void Delete(Product product)
        {
            AppDb.Products.Remove(product);
        }

        public List<Product> GetAll(Predicate<Product>? predicate = null)
        {
            if (predicate != null)
            {
                return AppDb.Products.FindAll(predicate);
            }
            return AppDb.Products;
        }

        public Product Get(Predicate<Product>? predicate = null)
        {
            if (predicate != null)
            {
                return AppDb.Products.Find(predicate);
            }
            return AppDb.Products.Find(x => true);
        }
    }
}
