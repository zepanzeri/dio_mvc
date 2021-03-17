using Microsoft.EntityFrameworkCore;

namespace dio_mvc.Models
{
    public class Context : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=dio_mvc;Integrated Security=True");
        }
    }
}