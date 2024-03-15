using HMTF.Models;
using Microsoft.EntityFrameworkCore;

namespace HMTF.Data
{
    public class HTMFDbContext : DbContext
    {
        public HTMFDbContext(DbContextOptions<HTMFDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<FirstMCU> FirstMcus { get; set; }

    }
}
