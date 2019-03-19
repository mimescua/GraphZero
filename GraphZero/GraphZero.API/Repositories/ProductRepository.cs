using System.Collections.Generic;
using System.Threading.Tasks;
using GraphZero.API.Data;
using GraphZero.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphZero.API.Repositories
{
    public class ProductRepository
    {
        private readonly LandDbContext _dbContext;

        public ProductRepository(LandDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Product>> GetAll()
        {
            return _dbContext.Products.ToListAsync();
        }
    }
}
