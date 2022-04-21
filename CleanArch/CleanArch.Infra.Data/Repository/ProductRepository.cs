using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;
using System.Collections.Generic;

namespace CleanArch.Infra.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationDbContext context;

        public ProductRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Product> GetProducts()
            => context.Products;
    }
}
