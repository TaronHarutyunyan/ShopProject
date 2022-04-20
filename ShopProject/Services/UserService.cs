using ShopProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopProject.Services
{
    public class UserService : IUserService
    {
        private ShopProjectDbContext _dbContext;
        public UserService(ShopProjectDbContext context)
        {
            _dbContext = context;
        }
        public void CreateUser(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var user = _dbContext.Users.Find(id);
            if (user == null) throw new KeyNotFoundException();
            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
        }

        public ICollection<User> GetAllUsers()
        {
            return _dbContext.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return (User)_dbContext.Users.Find(id) ?? throw new KeyNotFoundException();
        }      

        public void UpdateUser(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}
