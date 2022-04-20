using ShopProject.Models;
using System.Collections.Generic;

namespace ShopProject.Services
{
    public interface IProductService
    {
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        ICollection<Product> GetAllProducts();
        Product GetProductById(int id);
        Product GetProductByName(string name);
        void DeleteProduct(int id);
    }
}
