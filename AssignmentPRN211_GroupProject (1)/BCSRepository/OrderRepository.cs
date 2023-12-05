using BCSDAO;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSRepository
{
    public class OrderRepository : IOrderRepository
    {
        public void AddOrder(OrderInfo info)=>OrderDAO.Instance.AddOrder(info);

        public void AddOrderDeatil(OrderDetail info) => OrderdetailDAO.Instance.AddOrder(info);

        public void DeleteOrder(int id)=>OrderDAO.Instance.DeleteOrder(id);
       

        public void DeleteOrderDeatail(int id)=>OrderdetailDAO.Instance.DeleteOrder(id);

        public List<OrderInfo> GetAllOrder()=>OrderDAO.Instance.GetAllOrder();

        public List<OrderInfo> GetMethod()=>OrderDAO.Instance.GetMethod();

        public OrderInfo GetOrderInfoById(int id)=>OrderDAO.Instance.GetOrderInfoById(id);

        public void UpdateOrder(OrderInfo info)=>OrderDAO.Instance.UpdateOrder(info);

        public void UpdateOrderDeatail(OrderDetail info)=>OrderdetailDAO.Instance.UpdateOrder(info);
    }
}
