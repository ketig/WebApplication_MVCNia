using Microsoft.EntityFrameworkCore;
using WebApplication_MVCNia.Models.Entities;

namespace WebApplication_MVCNia.Data
{
    public class SchoolsContext : DbContext
    {
        public SchoolsContext(DbContextOptions<SchoolsContext> options) : base(options)
        {
        }

        public DbSet<School> Schools { get; set; }
    }
}
