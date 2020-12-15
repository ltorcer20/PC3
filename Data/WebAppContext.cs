using Microsoft.EntityFrameworkCore;
using PC3.Models;

namespace PC3.Data
{
    public class WebAppContext : DbContext
    {
        public DbSet<Home> Productos { get; set; }
        public WebAppContext(DbContextOptions x) : base (x)
        {
            
        }
    }
}