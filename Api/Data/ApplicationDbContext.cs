using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
        : base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
    }
}