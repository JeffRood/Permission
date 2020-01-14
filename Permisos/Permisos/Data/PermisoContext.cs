using Microsoft.EntityFrameworkCore;
using Permisos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMatheFinal.Models;

namespace Permisos.Data
{
    public class PermisoContext: DbContext
    {
        public PermisoContext(DbContextOptions<PermisoContext> options): base(options)
        {        }

        public DbSet<TipoPermiso> TipoPermiso { get; set; }

        public DbSet<Permiso> Permisos { get; set; }

    }
}
