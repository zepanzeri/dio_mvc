using Microsoft.EntityFrameworkCore;

namespace dio_mvc.Models
{
    public class Context : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer(@"Server=127.0.0.1,1433;Database=dio_mvc;User Id=SA;Password=Admin_123");
        }
    }
}