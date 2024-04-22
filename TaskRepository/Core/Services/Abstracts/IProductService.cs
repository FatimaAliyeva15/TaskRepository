using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Abstracts
{
    public interface IProductService
    {
        public void AddProduct(Product product);
        public void UpdateProduct(int id, Product newproduct);
        public void DeleteProduct(int id);
        public Product GetProduct(Predicate<Product>? predicate=null);
        public List<Product> GetAllProducts(Predicate<Product>? predicate=null);
    }
}
