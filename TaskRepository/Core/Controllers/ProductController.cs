using Core.Models;
using Core.Services.Abstracts;
using Core.Services.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Controllers
{
    public class ProductController
    {
        IProductService _productService = new ProductService();

        public void AddProduct()
        {
            Console.Write("Product Name: ");
            string name = Console.ReadLine();

            Console.Write("Product Description: ");
            string description = Console.ReadLine();


            string priceStr = "";
            double price;

            do
            {
                Console.Write("Product Price: ");
                priceStr = Console.ReadLine();
            } while (!double.TryParse(priceStr, out price));

            string discountPercetStr = "";
            double discountPercet;

            do
            {
                Console.Write("Product Discount Percet: ");
                discountPercetStr = Console.ReadLine();
            } while (!double.TryParse(discountPercetStr, out discountPercet));

            Product product = new Product(name, description, price, discountPercet);

            _productService.AddProduct(product);

        }

        public void UpdateProduct()
        {
            string idStr = "";
            int id;

            do
            {
                Console.Write("Id: ");
                idStr = Console.ReadLine();
            } while (!int.TryParse(idStr, out id));

            Console.WriteLine("");
            Console.Write("New Product Name: ");
            string name = Console.ReadLine();

            Console.Write("New Product Description: ");
            string description = Console.ReadLine();


            string priceStr = "";
            double price;

            do
            {
                Console.Write("New Product Price: ");
                priceStr = Console.ReadLine();
            } while (!double.TryParse(priceStr, out price));

            string discountPercetStr = "";
            double discountPercet;

            do
            {
                Console.Write("New Product Discount Percet: ");
                discountPercetStr = Console.ReadLine();
            } while (!double.TryParse(discountPercetStr, out discountPercet));

            Product newproduct = new Product(name, description, price, discountPercet);

            _productService.UpdateProduct(id, newproduct);
        }

        public void DeleteProduct()
        {
            string idStr = "";
            int id;

            do
            {
                Console.Write("Id: ");
                idStr = Console.ReadLine();
            } while (!int.TryParse(idStr, out id));

            _productService.DeleteProduct(id);
            Console.WriteLine("");
            Console.WriteLine($"Id {id} olan mehsul silindi");
        }

        public void GetAllProduct()
        {

            _productService.GetAllProducts().ForEach(product => Console.WriteLine(product));
        }

        public void GetProduct()
        {
            Console.WriteLine(_productService.GetProduct());
        }
    }
}
