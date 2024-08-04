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
    public partial class FormAltaMateria : Form
    {
        Materia nuevaMateria;

        public Materia NuevaMateria { get => nuevaMateria; set => nuevaMateria = value; }

        public FormAltaMateria()
        {
            InitializeComponent();
        }

        private void FormAltaMateria_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string nombre = txt_materia.Text;
            DialogResult = DialogResult.OK;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
