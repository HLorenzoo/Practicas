using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Clases
{
    [Table("Alumno")]
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Curso { get; set; }

        public int IdProfesor { get; set;}

        [ForeignKey("IdProfesor")]
        public Profesor Profesor { get; set; }

    }
}
