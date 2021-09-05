using Catalog.API.Data;
using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Repositories
{
    public class ProductRepositories : IProductRepositories
    {
        private readonly ICatalogContext _context;

        public ProductRepositories(ICatalogContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Task CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProduct(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProduct(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _context.Products.Find(prop => true).ToListAsync();
        }

        public Task<bool> UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
