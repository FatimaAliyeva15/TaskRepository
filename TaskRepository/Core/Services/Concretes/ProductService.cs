using Core.AccessDataLayer;
using Core.Models;
using Core.Repositories.Abstracts;
using Core.Repositories.Concretes;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Concretes
{
    public class ProductService:IProductService
    {
        IProductRepository _productRepository = new ProductRepository();

        public void AddProduct(Product product)
        {
            _productRepository.Add(product);
        }

        public void DeleteProduct(int id)
        {
            Product product = _productRepository.Get(x => x.Id == id);
            if (product == null) throw new NullReferenceException("Product not found!");

            _productRepository.Delete(product);
        }

        public List<Product> GetAllProducts(Predicate<Product>? predicate = null)
        {
            return _productRepository.GetAll(predicate);

        }

        public Product GetProduct(Predicate<Product>? predicate = null)
        {
            return _productRepository.Get(predicate);
        }

        public void UpdateProduct(int id, Product newproduct)
        {
            Product updateProduct = AppDb.Products.Find(item => item.Id == id);
            updateProduct.Name = newproduct.Name;
            updateProduct.Description = newproduct.Description;
            updateProduct.Price = newproduct.Price;
            updateProduct.DiscountPercet = newproduct.DiscountPercet;
        }
    }
}
