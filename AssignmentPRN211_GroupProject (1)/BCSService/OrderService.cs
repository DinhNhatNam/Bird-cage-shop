using BCSRepository;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSService
{
    public class OrderService : IOrderService
    {
        private IOrderRepository orderRepository;

        public OrderService()
        {
            orderRepository = new OrderRepository();
        }

        public void AddOrder(OrderInfo info)=>orderRepository.AddOrder(info);

        public List<OrderInfo> GetAllOrder()=>orderRepository.GetAllOrder();

        public List<OrderInfo> GetMethod()=>orderRepository.GetMethod();

        public OrderInfo GetOrderInfoById(int id)=>orderRepository.GetOrderInfoById(id);

        public void UpdateOrder(OrderInfo info)=>orderRepository.UpdateOrder(info);

        public void DeleteOrder(int id)=>orderRepository.DeleteOrder(id);

        public void UpdateOrderDetail(OrderDetail info) => orderRepository.UpdateOrderDeatail(info);

        public void DeleteOrderDetail(int id) => orderRepository.DeleteOrderDeatail(id);

        public void AddOderDetail(OrderDetail info)=> orderRepository.AddOrderDeatil(info);

        public List<String> country = new List<String>
        {
            new String("Hà Nội"),
            new String("Hồ Chí Minh"),
            new String("Đà Nẵng"),
            new String("Cần Thơ"),
            new String("Quy Nhơn"),
            new String("Vũng Tàu"),
            new String("Đà Lạt"),
        };
    }
}
