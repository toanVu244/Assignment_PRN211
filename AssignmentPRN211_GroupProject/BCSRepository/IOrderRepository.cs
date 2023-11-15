using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSRepository
{
    public interface IOrderRepository
    {
        public List<OrderInfo> GetAllOrder();
        public void AddOrder(OrderInfo info);
        public OrderInfo GetOrderInfoById(int id);
        public List<OrderInfo> GetMethod();
    }
}
