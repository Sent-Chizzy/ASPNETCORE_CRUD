using ASPCRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ASPCRUD.Data
{
    public class MVCDemoDBContext : DbContext
    {
        public MVCDemoDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
