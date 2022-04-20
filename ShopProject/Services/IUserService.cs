using ShopProject.Models;
using System.Collections.Generic;

namespace ShopProject.Services
{
    public interface IUserService
    {
        void CreateUser(User user);
        ICollection<User> GetAllUsers();
        User GetUserById(int id);
        void DeleteUser(int id);
        void UpdateUser(User user);

    }
}
