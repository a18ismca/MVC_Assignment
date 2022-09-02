﻿using Microsoft.EntityFrameworkCore;
using MVC_Assignment.Models;

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

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

           

            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 1, Name = "Sweden" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 2, Name = "Bosnia" });

            modelBuilder.Entity<City>().HasData(new City { CityId = 1, Name = "Göteborg", CountryId = 1, });
            modelBuilder.Entity<City>().HasData(new City { CityId = 2, Name = "Trebinje", CountryId = 2, });
            modelBuilder.Entity<City>().HasData(new City { CityId = 3, Name = "Malmö", CountryId = 1, });
            modelBuilder.Entity<City>().HasData(new City { CityId = 4, Name = "Stolac", CountryId = 2, });

            modelBuilder.Entity<Person>().HasData(new Person { Id = 1, Name = "Alisa", CityId = 1, PhoneNumber = 28356 });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 2, Name = "Erik", CityId = 2, PhoneNumber = 67890 });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 3, Name = "Ismet", CityId = 3, PhoneNumber = 12345 });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 4, Name = "Åsa", CityId = 4, PhoneNumber = 54545 });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 5, Name = "Avdo", CityId = 4, PhoneNumber = 10545 });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 6, Name = "Senad", CityId = 4, PhoneNumber = 51111 });








        }
    }
}
