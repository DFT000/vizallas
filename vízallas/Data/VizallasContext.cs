using Microsoft.EntityFrameworkCore;
using Vizallas.Models;

namespace Vizallas.Data
{
    public class VizallasContext : DbContext
    {
        public VizallasContext(DbContextOptions<VizallasContext> options) : base(options)
        {
        }

        public DbSet<Models.Vizallas> VizallasAdatok { get; set; }
    }
}
