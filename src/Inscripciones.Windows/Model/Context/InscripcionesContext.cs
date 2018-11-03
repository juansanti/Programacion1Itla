using Inscripciones.Windows.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inscripciones.Windows.Model.Context
{
    public class InscripcionesContext : DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }

        public InscripcionesContext():base("Inscripciones")
        {

        }
    }
}
