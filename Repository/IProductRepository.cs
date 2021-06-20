using System.Collections.Generic;
using ProductMicroservice.Model;

namespace ProductMicroservice.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
    }
}