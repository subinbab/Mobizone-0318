using DomainLayer;
using DomainLayer.ProductLayer;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class ProductCatalog : IProductCatalog
    {
        ProductDbContext _context;
        IRepositoryOperations<ProductBrand> _repo;
        public ProductCatalog(ProductDbContext context  )
        {
            _context = context;
            _repo = new RepositoryOperations<ProductBrand>(_context);
        }
        /*public void AddProduct(Products product)
        {
            _repo.Add();
        }*/
        public void AddBrand(ProductBrand brand)
        {
            _repo.Add(brand);
            _repo.Save();
        }
        public List<ProductBrand> productBrands()
        {
            IEnumerable<ProductBrand> brand = _repo.Get();
            List<ProductBrand> brandList = brand.ToList();
            return brandList;
        }
    }
}
