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
        private Materia nuevaMateria;

        public Materia NuevaMateria { get => nuevaMateria; } //propertie

        public FormAltaMateria()
        {
            InitializeComponent();
        }

        private void FormAltaMateria_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_materia.Text) && txt_materia.Text is not null && txt_materia.Text != "")
            {// si no esta vacia o no o si esta nula
                this.nuevaMateria = new Materia(txt_materia.Text);//crear nueva instancia de cada materia
                this.DialogResult = DialogResult.OK;//para informar q mi funcion termino acceder a la propertie
                                                    //propia del formulario -DialogResul 
            }
            else //si esta vacia va a devolver
            {
                MessageBox.Show("Debe ingresar un nombre");
            }
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
