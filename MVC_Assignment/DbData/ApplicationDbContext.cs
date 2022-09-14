using Microsoft.EntityFrameworkCore;
using MVC_Assignment.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace MVC_Assignment.DbData
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
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

        public DbSet<Language> Languages { get; set; }

       

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Language>().HasData(new Language { LanguageId = 1, Name = "Swedish" });
            modelBuilder.Entity<Language>().HasData(new Language { LanguageId = 2, Name = "English" });
            modelBuilder.Entity<Language>().HasData(new Language { LanguageId = 3, Name = "Bosnian" });




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

            string adminRoleId = Guid.NewGuid().ToString();
            string userRoleId = Guid.NewGuid().ToString();
            string userId = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = adminRoleId,
                Name = "Admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = userRoleId,
                Name = "User",
                NormalizedName = "USER"
            });

            PasswordHasher<AppUser> hasher = new PasswordHasher<AppUser>();

            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = userId,
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                FirstName = "Admin",
                LastName = "Adminsson",

                PasswordHash = hasher.HashPassword(null, "password")

            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = userId,
                RoleId = adminRoleId,
            });






        }
    }
}
