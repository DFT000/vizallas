using Microsoft.EntityFrameworkCore;
using vízallas.Models;

namespace vízallas.Data
{
    public class VizallasContext : DbContext
    {
        public VizallasContext(DbContextOptions<VizallasContext> options)
            : base(options)
        {
        }
        public DbSet<vízallas.Models.Vizallas> Vizallas { get; set; }
    }
}
