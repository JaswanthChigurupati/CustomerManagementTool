using CustomerManagement.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagement.Api.Contexts
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
    }

}
