using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Ex2_Test2
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
