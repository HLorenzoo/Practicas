using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Clases
{
    public class DbAlumnosContext : DbContext
    {
       public DbAlumnosContext() :base("KEY") { }
    
       public DbSet<Alumno> Alumnos { get; set; }
       public DbSet<Profesor> Profesores { get; set; }


    }
}
