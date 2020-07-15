using System.Collections.Generic;
using System.Threading.Tasks;
using GraphqlTest.API.Data;
using GraphqlTest.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphqlTest.API.Repositories
{
    public class ProductRepository
    {
        private readonly CarvedRockDbContext _dbContext;

        public ProductRepository(CarvedRockDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Product>> GetAll()
        {
            return _dbContext.Products.ToListAsync();
        }
    }
}
