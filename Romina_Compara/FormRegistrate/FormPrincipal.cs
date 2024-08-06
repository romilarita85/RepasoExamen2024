using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaDeIngresantes;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace FormRegistrate
{

    public partial class FormPrincipal : Form
    {
        
        List<Ingresante> ingresantes;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            ingresantes = new List<Ingresante>();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new FormAlta();
            formAlta.ShowDialog();

            if (formAlta.DialogResult == DialogResult.OK) 
            {
                ingresantes.Add(formAlta.NuevoIngresante);//uso propertie creada en formAlta
                CargaDgv();
            }
        }
        private void CargaDgv() 
        {
            dgv_lstIngresantes.DataSource = null;
            dgv_lstIngresantes.DataSource = ingresantes;
        }
    }
}
