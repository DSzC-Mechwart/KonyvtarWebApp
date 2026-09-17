using Microsoft.EntityFrameworkCore;
using KonyvtarWebApp.Models;

namespace KonyvtarWebApp.Data
{
    class KonyvtarDbContext : DbContext
    {
        public KonyvtarDbContext(DbContextOptions<KonyvtarDbContext> options)
             :base(options)
        {
            
        }
        public DbSet<Konyv> Konyvek { get; set; }

    }
}