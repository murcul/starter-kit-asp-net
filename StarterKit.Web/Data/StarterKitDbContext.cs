using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StarterKit.Web.Models;

namespace StarterKit.Web.Data
{
    public class StarterKitDbContext : DbContext
    {
        public StarterKitDbContext(DbContextOptions<StarterKitDbContext> options)
            : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().ToTable("Users");
        }

        public DbSet<User> Users { get; set; }
    }
}
