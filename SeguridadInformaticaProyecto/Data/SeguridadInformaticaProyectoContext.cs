using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SeguridadInformaticaProyecto.Models;

namespace SeguridadInformaticaProyecto.Data
{
    public class SeguridadInformaticaProyectoContext : DbContext
    {
        public SeguridadInformaticaProyectoContext (DbContextOptions<SeguridadInformaticaProyectoContext> options)
            : base(options)
        {
        }

        public DbSet<SeguridadInformaticaProyecto.Models.Activo> Activo { get; set; } = default!;
    }
}
