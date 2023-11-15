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

    }
}