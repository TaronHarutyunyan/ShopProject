using ShopProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopProject.Services
{
    public class ProductService : IProductService
    {
        private ShopProjectDbContext _dbContext;
        public ProductService(ShopProjectDbContext context)
        {
            _dbContext = context;
        }
        public void CreateProduct(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var product = _dbContext.Products.Find(id);
            if (product == null) throw new KeyNotFoundException();
            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();
        }

        public ICollection<Product> GetAllProducts()
        {
            return _dbContext.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return (Product)_dbContext.Products.Find(id) ?? throw new KeyNotFoundException();
        }

        public Product GetProductByName(string name)
        {
            return (Product)_dbContext.Products.Find(name) ?? throw new KeyNotFoundException();
        }

        public void UpdateProduct(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
