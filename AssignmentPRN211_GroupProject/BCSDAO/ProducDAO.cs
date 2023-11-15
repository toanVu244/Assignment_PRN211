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
    }
}