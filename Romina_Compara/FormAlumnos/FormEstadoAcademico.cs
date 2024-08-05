using Libreria_De_Estudiante;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAlumnos
{
    public partial class FormEstadoAcademico : Form
    {
        private Alumno alumno;
        private string carrera;
        private List<Materia> materias;

        public FormEstadoAcademico()//constructor vacio
        {
            InitializeComponent();
        }

        public FormEstadoAcademico(Alumno alumno, string carrera, List<Materia> materias):this()
        {//constructor con parametros
            this.alumno = alumno;
            this.carrera = carrera;
            this.materias = materias;
        }

        private void FormEstadoAcademico_Load(object sender, EventArgs e)
        {
            lst_estadoAcad.Items.Add(alumno);
            lst_estadoAcad.Items.Add($"Carrera: {carrera}");
            lst_estadoAcad.Items.Add("Listado de materias:");

            foreach (Materia item in materias)
            {
                lst_estadoAcad.Items.Add(item.Nombre);
            }
        }
    }
}
