using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inscripciones.Windows.Model.Entities
{
    [Table("Escuelas")]
    public class Escuela
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
