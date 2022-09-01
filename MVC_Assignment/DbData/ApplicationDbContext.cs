using Microsoft.EntityFrameworkCore;
using MVC_Assignment.Models;
using MVC_Assignment.ViewModels;

namespace MVC_Assignment.DbData
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
           
        }

        public DbSet<Person> People { get; set; }

  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Person>().HasData(new Person { Id = 1, Name = "Alisa", City = "Stockholm", PhoneNumber = 28356 });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 2, Name = "Erik", City = "Göteborg", PhoneNumber = 67890 });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 3, Name = "Ismet", City = "Malmö", PhoneNumber = 12345 });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 4, Name = "Åsa", City = "Malmö", PhoneNumber = 54545 });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 5, Name = "Jagvetinte", City = "Göteborg", PhoneNumber = 54343 });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 6, Name = "Hejpådig", City = "Stockholm", PhoneNumber = 54242 });



        }
    }
}
