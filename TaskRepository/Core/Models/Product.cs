using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Product
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double DiscountPercet { get; set; }

        public Product(string name, string description, double price, double discountpercet)
        {
            _id++;
            Id = _id;
            Name = name;
            Description = description;
            Price = price;
            DiscountPercet = discountpercet;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Description: {Description}, Price: {Price}, DiscountPercet: {DiscountPercet}";
        }
    }
}
