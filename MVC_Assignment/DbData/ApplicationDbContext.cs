using Microsoft.EntityFrameworkCore;

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
    }
}
