using BusinessObject.Models;

namespace BCSDAO
{
    public class ProducDAO
    {
        public static ProducDAO instance;

        public ProducDAO()
        {

        }

        public static ProducDAO Instance {
            get { 
                if(instance == null)
                {
                    instance = new ProducDAO();
                }
            return instance; 
            }
        }

        public List<Product> GetAllProduct()
        {
            try
            {
                var dbcontent = new BirdCageShopContext();
                return dbcontent.Products.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public Product? GetProductById(String id)
        {
            try
            {
                var dbcontent = new BirdCageShopContext();
                return dbcontent.Products.SingleOrDefault(a => a.ProductId.Equals(id));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void AddProduct(Product product)
        {
            try
            {
                var dbcontent = new BirdCageShopContext();
                dbcontent.Products.Add(product);
                dbcontent.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void UpdateProduct(Product product)
        {
            try
            {
                var dbcontent = new BirdCageShopContext();
                dbcontent.Products.Update(product);
                dbcontent.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteProduct(string product)
        {
            try
            {
                var dbcontent = new BirdCageShopContext();

                dbcontent.Products.Remove(GetProductById(product));
                dbcontent.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Product>? searchProduct(String key)
        {
            try
            {
                var dbcontent = new BirdCageShopContext();
                return dbcontent.Products.Where(a => a.ProductName.Contains(key)
                       || a.BirdType.Contains(key)
                   ).ToList();
            }
            catch
           (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}