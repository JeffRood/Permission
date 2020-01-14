using Microsoft.EntityFrameworkCore;
using Permisos.Models;

namespace Permisos
{
    public class PermisoContext: DbContext
    {
        public PermisoContext(DbContextOptions<PermisoContext> options) : base(options)
        { }

        public DbSet<TipoPermiso> TipoPermiso { get; set; }

        public DbSet<Permiso> Permisos { get; set; }
    }
}