using BCSDAO;
using BusinessObject.Models;

namespace BCSRepository
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetAllProduct()=>ProducDAO.Instance.GetAllProduct();
    }
}