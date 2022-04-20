using ShopProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopProject.Services
{
    public class OrderService : IOrderService
    {
        private ShopProjectDbContext _dbContext;
        public OrderService(ShopProjectDbContext context)
        {
            _dbContext = context;
        }
        public void CreateOrder(Order order)
        {            
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();   
        }

        public void DeleteOrder(int id)
        {            
            var order = _dbContext.Orders.Find(id);
            if(order == null) throw new KeyNotFoundException();
            _dbContext.Orders.Remove(order);
            _dbContext.SaveChanges();
        }

        public ICollection<Order> GetAllOrders()
        {
            return _dbContext.Orders.ToList();
        }

        public Order GetOrderById(int id)
        {
            return (Order)_dbContext.Orders.Find(id)??throw new KeyNotFoundException();
            //var order = _dbContext.Orders.Find(id);
            //if( order == null) throw new KeyNotFoundException();
            //else return order;
        }

        public void UpdateOrder(Order order)
        {
            throw new System.NotImplementedException();
        }
    }
}
