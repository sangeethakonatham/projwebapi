using Microsoft.EntityFrameworkCore;
using projwebapi.API.Models.Domain;

namespace projwebapi.API.Data
{
    public class projwebapiDbContext:DbContext
    {
        public projwebapiDbContext(DbContextOptions<projwebapiDbContext> options): base(options) 
        {
            
        }   
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> states { get; set; }

    }
}
