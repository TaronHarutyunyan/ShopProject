using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopProject.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        ICollection<Order> Orders { get; set; }


        //private static int _id = 1;
        //private string _name;
        //public User(string userName)
        //{
        //    UserName = userName;
        //    SetId();
        //}
        //[Key]
        //public int UserId { get; private set; }
        //[Required]
        //public string UserName
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
        //private void SetId()
        //{
        //    UserId = _id++;
        //}
    }
}
