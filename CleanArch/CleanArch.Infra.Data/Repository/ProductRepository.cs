using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationDbContext context;

        public ProductRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<Product> GetById(int? id)
            => await context.Products.FindAsync(id);

        public async Task<IEnumerable<Product>> GetProducts()
            => await context.Products.ToListAsync();

        public void Add(Product product)
        {
            context.Add(product);
            context.SaveChanges();
        }

        public void Update(Product product)
        {
            context.Update(product);
            context.SaveChanges();
        }

        public void Remove(Product product)
        {
            context.Remove(product);
            context.SaveChanges();
        }
    }
}
