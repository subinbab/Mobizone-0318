using DomainLayer;
using RepositoryLayer;
using System;

namespace BusinessLayer
{
    public class ProductCatalog : IProductCatalog
    {
        ProductDbContext _context;
        IRepositoryOperations<Product> _repo;
        public ProductCatalog(ProductDbContext context , IRepositoryOperations<Product> repo )
        {
            _context = context;
            _repo = repo(_context);
        }
        public void AddProduct(Product product)
        {
            _repo.Add(product);
        }
    }
}
