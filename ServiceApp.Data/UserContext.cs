using Microsoft.EntityFrameworkCore;
using ServiceApp.Domain;
using System;

namespace ServiceApp.Data
{
    public class UserContext : DbContext
    {
        public UserContext()
        {
        }

        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        { }

        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(x => new { x.Id });

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(
                 "Server=tcp:kratovichsqlserver.database.windows.net,1433;Initial Catalog=DataBaseProject;Persist Security Info=False;User ID=Aliaksandr_Kratovich;Password=alcatel918D; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
