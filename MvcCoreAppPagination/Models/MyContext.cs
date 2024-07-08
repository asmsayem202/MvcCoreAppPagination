using Microsoft.EntityFrameworkCore;

namespace MvcCoreAppPagination.Models
{
    public class MyContext : DbContext
    {

        public MyContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
