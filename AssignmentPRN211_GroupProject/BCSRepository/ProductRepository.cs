using BCSDAO;
using BusinessObject.Models;

namespace BCSRepository
{
    public class ProductRepository : IProductRepository
    {
        public void AddProduct(Product product)
        {
            ProducDAO.Instance.AddProduct(product);
        }

        public void DeleteProduct(string id)
        {
            ProducDAO.Instance.DeleteProduct(id);
        }
        public List<Product> GetAllProduct()=>ProducDAO.Instance.GetAllProduct();
        public Product GetProductById(string id) => ProducDAO.Instance.GetProductById(id);

        public List<Product> SearchProducts(string key) => ProducDAO.Instance.searchProduct(key);


        public void UpdateProduct(Product product)
        {
            ProducDAO.Instance.UpdateProduct(product);
        }
    }
}