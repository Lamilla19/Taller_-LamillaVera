using Microsoft.EntityFrameworkCore;

namespace Taller__LamillaVera.Models
{
    
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {

            }

            public DbSet<Usuarios> Usuarios { get; set; }
            public DbSet<Genero> generos { get; set; }

        }
    
}
