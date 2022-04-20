using System;

namespace ShopProject.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }

        //public Product() { }
        //public Product(string name,int price)
        //{
        //    ProductName = name;
        //    ProductPrice = price;
        //    SetId();
        //}

        //private static int _id = 1;
        //private string _name;
        //private int _price;
        //public int ProductId { get; private set; }
        //public string ProductName
        //{
        //    get
        //    {
        //        return _name;
        //    }
        //    set
        //    {
        //        _name = value ?? throw new ArgumentNullException(nameof(value));
        //    }
        //}
        //public int ProductPrice
        //{
        //    get
        //    {
        //        return _price;
        //    }
        //    set
        //    {
        //        if (value > 0) _price = value;
        //        else throw new ArgumentOutOfRangeException(nameof(value));
        //    }
        //}
        
        //private void SetId()
        //{
        //    ProductId = _id++;
        //}
    }
}
