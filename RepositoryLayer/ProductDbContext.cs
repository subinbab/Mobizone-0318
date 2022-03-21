using DomainLayer;
using Microsoft.EntityFrameworkCore;
using System;

namespace RepositoryLayer
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Product> products { get; set; }
    }
}
