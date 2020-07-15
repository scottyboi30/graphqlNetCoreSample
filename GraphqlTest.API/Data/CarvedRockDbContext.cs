using GraphqlTest.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphqlTest.API.Data
{
    public class CarvedRockDbContext: DbContext
    {
        public CarvedRockDbContext(DbContextOptions<CarvedRockDbContext> options): base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}
