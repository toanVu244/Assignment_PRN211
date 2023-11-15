using BCSRepository;
using BusinessObject.Models;

namespace BCSService
{
    public class ProductService : IProductService
    {
        private IProductRepository productRepository;

        public ProductService()
        {
            productRepository = new ProductRepository();
        }

        public List<Product> GetAllProduct()=>productRepository.GetAllProduct();
        public void AddProduct(Product product)
        {
            productRepository.AddProduct(product);
        }

        public void DeleteProduct(string id)
        {
            productRepository.DeleteProduct(id);
        }

        

        public Product GetProductById(string id)
        {
            if (id == null)
            {
                return null;
            }
            else
            {
                return productRepository.GetProductById(id);
            }
        }

        public string GetProductIdvalid()
        {
            List<Product> products = GetAllProduct();
            int a = Int32.Parse(products.Last().ProductId.Substring(1));
            a++;
            return "P0" + a.ToString();
        }

        public List<Product> SearchProduct(string key)
        {
            if (key == null)
            {
                return null;
            }
            else
            {
                return productRepository.SearchProducts(key);
            }
        }

        public void UpdateProduct(Product product)
        {
            productRepository.UpdateProduct(product);
        }
    }
}