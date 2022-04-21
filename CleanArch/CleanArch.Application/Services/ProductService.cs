using AutoMapper;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository productRepository;
        private readonly IMapper mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }

        public async Task<ProductViewModel> GetById(int? id)
        {
            var result = await productRepository.GetById(id);
            return mapper.Map<ProductViewModel>(result);
        }

        public async Task<IEnumerable<ProductViewModel>> GetProducts()
        {
            var result = await productRepository.GetProducts();
            return mapper.Map<IEnumerable<ProductViewModel>>(result);
        }

        public void Add(ProductViewModel product)
        {
            var mapProduct = mapper.Map<Product>(product);
            productRepository.Add(mapProduct);
        }

        public void Update(ProductViewModel product)
        {
            var mapProduct = mapper.Map<Product>(product);
            productRepository.Update(mapProduct);
        }

        public void Remove(int? id)
        {
            var product = productRepository.GetById(id).Result;
            productRepository.Remove(product);
        }
    }
}
