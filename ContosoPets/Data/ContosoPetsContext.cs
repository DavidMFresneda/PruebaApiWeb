using Microsoft.EntityFrameworkCore;
using ContosoPets.Controllers;
using ContosoPets.Models;

namespace ContosoPets.Data
{
    public class ContosoPetsContext : DbContext
    {
        public ContosoPetsContext(DbContextOptions<ContosoPetsContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}