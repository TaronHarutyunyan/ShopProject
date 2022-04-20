using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopProject.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<Product> Products { get; set; }
        //public Order()
        //{

        //}
        //private static int _id = 1;
        //[Key]
        //public int OrderId { get; private set; }
        //private void SetId()
        //{
        //    OrderId = _id++;
        //}
    }
}
