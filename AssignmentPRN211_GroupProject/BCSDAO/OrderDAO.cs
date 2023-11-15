using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSDAO
{
    public class OrderDAO
    {
        public static OrderDAO instance;

        public OrderDAO()
        {

        }
        public static OrderDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDAO();
                }
                return instance;
            }
        }

        public List<OrderInfo> GetAllOrder()
        {
            try
            {
                var dbcontent = new BirdCageShopContext();
                return dbcontent.OrderInfos.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<OrderInfo> GetMethod()
        {
            try
            {
                var dbcontent = new BirdCageShopContext();
                return dbcontent.OrderInfos.OrderBy(e => e.OrderId)
                .Take(5)
                .ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void AddOrder(OrderInfo info)
        {
            try
            {
                var dbContent = new BirdCageShopContext();
                dbContent.OrderInfos.Add(info);
                dbContent.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public OrderInfo GetOrderInfoById(int id)
        {
            try
            {
                var dbContent = new BirdCageShopContext();
                return dbContent.OrderInfos.SingleOrDefault(m => m.OrderId == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


    }
}
