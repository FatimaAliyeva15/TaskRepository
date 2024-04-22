using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Abstracts
{
    public interface IProductRepository
    {
        void Delete(Product product);
        void Add(Product product);
        Product Get(Predicate<Product>? predicate = null);
        List<Product> GetAll(Predicate<Product>? predicate = null);
    }
}
