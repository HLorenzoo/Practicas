using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Clases
{
    public class Profesor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public List <Alumno> Alumnos { get; set; }
     
    }
}
