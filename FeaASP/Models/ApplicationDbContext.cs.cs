using FEAasp.Models;
using Microsoft.EntityFrameworkCore;
namespace Sabadoanimado.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>
        options) : base(options)
        {
        }
        public DbSet<login> LOGIN { get; set; }
        internal bool TestConnection()
        {
            throw new NotImplementedException();
        }
    }
}