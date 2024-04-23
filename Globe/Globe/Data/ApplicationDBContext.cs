using Globe.Models_DB;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Globe.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Admin> Admin { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Auther> Auther { get; set; }
        public DbSet<News> News { get; set; }

    }
}
