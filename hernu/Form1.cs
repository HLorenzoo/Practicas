using Practicas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hernu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Profesor profe = new Profesor() { Nombre = "hernan" };
            AbmAlumnos.InsertProfe(profe);
            MostrarAlumnos();
        }
        private void MostrarAlumnos()
        {
            dataGridView1.DataSource= AbmAlumnos.SelectAll();
            dataGridView2.DataSource= AbmAlumnos.SelectAllp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno() { Nombre="Valentino",Curso="Segundo A",IdProfesor=1};

            int res = AbmAlumnos.Insert(alumno);
           

            if(res > 0) 
            {
                MessageBox.Show("Se creo el alumno!");
                MostrarAlumnos();
            }
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            Alumno alumnoAMostrar = AbmAlumnos.SelectWhereById(id);
            if(alumnoAMostrar != null)MessageBox.Show($"\n\t Alumno Encontrado : \n\t Nombre :{alumnoAMostrar.Nombre}  \n\t Curso: {alumnoAMostrar.Curso}");
            if (alumnoAMostrar == null) MessageBox.Show("no hay na");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int res = AbmAlumnos.Delete(Convert.ToInt32(textBox1.Text));
            if (res > 0)
            {
                MessageBox.Show("delete");
                MostrarAlumnos();
            }
                
            if(res==0) MessageBox.Show("No se pudo borra na perro");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Editar
            Alumno alumno = new Alumno()
            {
                Id = Convert.ToInt32(textBox1.Text),
                Nombre = textBox2.Text,
                Curso = textBox3.Text,
            };
           //Alumno alumnoEncontrado = AbmAlumnos.SelectWhereById(Convert.ToInt32(textBox1.Text));
           int res = AbmAlumnos.Update(alumno);
            if (res > 0) {
                MessageBox.Show("Alumno editado");
                    MostrarAlumnos();
            }
            
        }
    }
}
