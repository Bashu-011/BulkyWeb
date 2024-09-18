using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    //necessary for migrations
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        //prop for creating the table
        public DbSet<Category> Category { get; set; }

        //seeding data into a db
        //override the base function
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Comedy", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Romance", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Thriller", DisplayOrder = 4 }

                );
        }


    }
}
