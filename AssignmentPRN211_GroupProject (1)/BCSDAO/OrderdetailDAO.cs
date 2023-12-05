using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSDAO
{
    public class OrderdetailDAO
    {
        public static OrderdetailDAO instance;

        public OrderdetailDAO()
        {

        }
        public static OrderdetailDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderdetailDAO();
                }
                return instance;
            }
        }
        public List<OrderDetail> getAllOrderDetail()
        {
            try
            {
                var dbcontent = new BirdCageShopContext();
                return dbcontent.OrderDetails.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public OrderDetail GetOrderDetailById(int id)
        {
            try
            {
                var dbContent = new BirdCageShopContext();
                return dbContent.OrderDetails.SingleOrDefault(m => m.OrderId == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteOrder(int id)
        {
            try
            {
                var dbContent = new BirdCageShopContext();
                OrderDetail info = GetOrderDetailById(id);
                dbContent.OrderDetails.Remove(info);
                dbContent.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateOrder(OrderDetail orderInfo)
        {
            try
            {
                var dbContent = new BirdCageShopContext();

                dbContent.OrderDetails.Update(orderInfo);
                dbContent.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void AddOrder(OrderDetail orderInfo)
        {
            try
            {
                var dbContent = new BirdCageShopContext();

                dbContent.OrderDetails.Add(orderInfo);
                dbContent.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
