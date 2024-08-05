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
        private List<Materia> materias;
        private string carrera;

        public FormEstadoAcademico()//constructor vacio
        {
            InitializeComponent();
        }

        public FormEstadoAcademico(Alumno alumno, List<Materia> materias, string carrera):this()
        {
            this.alumno = alumno;
            this.materias = materias;
            this.carrera = carrera;
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
