using Microsoft.EntityFrameworkCore;
using onlineCart.API.Controllers.Models;

namespace onlineCart.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options){}

        public DbSet<Value> Values { get; set; }
    }
}