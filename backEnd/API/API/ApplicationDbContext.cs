using adConjuntos2.Models;
using Microsoft.EntityFrameworkCore;

namespace adConjuntos2
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Usuario_rol> Usuario_Rol { get; set; }
        public DbSet<Vivienda> Vivienda { get; set; }
        public DbSet<Tarifa> Tarifa { get; set; }
        public DbSet<Conjunto> Conjunto { get; set; }

    }
}
