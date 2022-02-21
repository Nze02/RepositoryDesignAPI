using Microsoft.EntityFrameworkCore;
using RepositoryDesignAPI.Models;

namespace RepositoryDesignAPI
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {}
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
