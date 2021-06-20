using System.Collections.Generic;
using ProductMicroservice.Model;

namespace ProductMicroservice.Repository
{
    public class ProductRepository : IProductRepository
    {
        List<Product> _productList;
        public ProductRepository()
        {
            InitializeProductSample();            
        }
        public IEnumerable<Product> GetProducts()
        {
            return _productList;
        }

        private void InitializeProductSample()
        {
            _productList = new List<Product>();

            Product pd = new Product();
            pd.Id = 1;
            pd.Name = "Iphone 11";
            pd.Description = "IPhone 11 64 GB";
            pd.Price = 55450.00;

            _productList.Add(pd);

            pd.Id = 2;
            pd.Name = "Iphone 11";
            pd.Description = "IPhone 11 128 GB";
            pd.Price = 88784.00;

            _productList.Add(pd);

            pd.Id = 3;
            pd.Name = "Iphone 12 mini";
            pd.Description = "IPhone 12 mini 62 GB";
            pd.Price = 65980.00;

            _productList.Add(pd);

        }

    }
}