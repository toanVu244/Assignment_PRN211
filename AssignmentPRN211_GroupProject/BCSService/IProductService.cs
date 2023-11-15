using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSService
{
    public interface IProductService
    {
        public List<Product> GetAllProduct();
    }
}
