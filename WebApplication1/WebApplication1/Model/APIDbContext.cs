using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Model
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions option) : base(option)
        {

        }

        public DbSet<User> Users { get; set; }





        
     

    }
}