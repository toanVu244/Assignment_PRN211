using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSRepository
{
    public interface IProductRepository
    {
        public List<Product> GetAllProduct();
        public Product GetProductById(string id);

        public void AddProduct(Product product);
        public void UpdateProduct(Product product);
        public void DeleteProduct(string id);

        public List<Product> SearchProducts(string key);
    }
}
