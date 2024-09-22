using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<IReadOnlyList<Product>> GetProducts(string? brand, string? type,string? sort);
        Task<IReadOnlyList<string>> GetBrands();
        Task<IReadOnlyList<string>> GetTypes();
        Task<Product?> GetProductById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        bool ProductExist(int id);
        Task<bool> SaveChangesAsync();
    }
}
