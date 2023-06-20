using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kubernetes
{
    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    FirstName = "Shaveta",
                    LastName = "Girdhar",
                    Title = "Mrs.",
                    Phone ="4738748374"
                },
                new User()
                {
                    Id = 2,
                    FirstName = "Aarav",
                    LastName = "Gupta",
                    Title = "Mr.",
                    Phone = "545474"
                },
                new User()
                {
                    Id = 3,
                    FirstName = "Anu",
                    LastName = "Girdhar",
                    Title = "Mrs.",
                    Phone = "432111111"
                },
                new User()
                {
                    Id = 4,
                    FirstName = "Tushar",
                    LastName = "Tuteja",
                    Title = "Mr.",
                    Phone = "13242455"
                },
                new User()
                {
                    Id = 5,
                    FirstName = "Anish",
                    LastName = "Gupta",
                    Title = "Mr.",
                    Phone = "876589039"
                });
        }
    }
}
