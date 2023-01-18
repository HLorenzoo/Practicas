using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Clases
{
    public static class AbmAlumnos
    {

        public static DbAlumnosContext context = new DbAlumnosContext();
        public static List<Alumno> SelectAll()
        {
            return context.Alumnos.ToList();
        }
        public static List<Profesor> SelectAllp()
        {
            return context.Profesores.ToList();
        }

        public static Alumno SelectWhereById(int id)
        {
            return context.Alumnos.Find(id);

        }

        public static int Insert(Alumno alumno)
        {
            context.Alumnos.Add(alumno);

            return context.SaveChanges();
        }
        public static int InsertProfe(Profesor profesor)
        {
            context.Profesores.Add(profesor);

            return context.SaveChanges();
        }

        public static int Update(Alumno alumno)
        {
            Alumno categoriaOrigen = context.Alumnos.Find(alumno.Id);
            categoriaOrigen.Nombre = alumno.Nombre;
            categoriaOrigen.Curso = alumno.Curso;
            return context.SaveChanges();
        }

        public static int Delete(int id)
        {
            Alumno categoriaOrigen = context.Alumnos.Find(id);
            if (categoriaOrigen != null)
            {
                context.Alumnos.Remove(categoriaOrigen);
                return context.SaveChanges();
            }
            return 0;
        }

    }
}
