using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;

namespace Api.Interfaces
{
    public interface IProductRepository
    {
        public Task<Product?> GetByIdAsync(int id);
        public Task<IReadOnlyList<Product>> Get();
    }
}