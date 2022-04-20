using ShopProject.Models;
using System.Collections.Generic;

namespace ShopProject.Services
{
    public interface IOrderService
    {
        void CreateOrder(Order order);
        ICollection<Order> GetAllOrders();
        Order GetOrderById(int id);
        void DeleteOrder(int id);
        void UpdateOrder(Order order);
    }
}
