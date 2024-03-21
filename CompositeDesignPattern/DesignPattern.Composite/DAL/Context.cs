using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Composite.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-KVIRVD3\\SQLEXPRESS;initial catalog=DesignPattern3;integrated security=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
