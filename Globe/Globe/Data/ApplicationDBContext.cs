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
        public DbSet<Sport> Sport { get; set; }
        public DbSet<Politlcs> Politlcs { get; set; }
        public DbSet<Technolgy> Technolgy { get; set; }
        public DbSet<Health> Health { get; set; }
        public DbSet<News> News { get; set; }

    }
}
