using Microsoft.EntityFrameworkCore;

namespace TextScan
{
    public class MobileContext : DbContext
    {
        public DbSet<Costs> Costs { get; set; }
        public  DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Mobile.db");
        }
    }
}
