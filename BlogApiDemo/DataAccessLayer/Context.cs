using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-PP0P5FV\\MSSQLSERVER01;database=CoreBlogApiDb;integrated security=true;");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
