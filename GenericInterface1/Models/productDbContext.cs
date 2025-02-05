using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RazorPageDemo.Models
{
    public class productDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public productDbContext(DbContextOptions<productDbContext> options) : base(options)
        {

        }
    }
}