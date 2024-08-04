using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria_De_Estudiante;
namespace FormAlumnos
{
    public partial class FormAltaAlumno : Form
    {
        private Alumno nuevoAlumno;
        public Alumno NuevoAlumno { get => nuevoAlumno; }
        public FormAltaAlumno()
        {
            InitializeComponent();
        }
        private void FormAltaAlumno_Load(object sender, EventArgs e)
        {

        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {    
            string legajo = txt_legajo.Text;
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;

            DialogResult = DialogResult.OK;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

  
    }
}
