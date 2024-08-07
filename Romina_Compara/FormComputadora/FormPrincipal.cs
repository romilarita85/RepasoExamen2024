using LibreriaDeComputadoras;
using System.Security.Cryptography;

namespace FormComputadora
{
    public partial class Form1 : Form
    {
        List<Computadora> misComputadoras;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            misComputadoras = new List<Computadora>();
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new FormAlta();
            formAlta.ShowDialog();

            if (formAlta.DialogResult == DialogResult.OK) 
            {
                misComputadoras.Add(formAlta.NuevaComputadora);
                CargarDgv();
            
            }
        }
        private void CargarDgv() 
        {
            dgv_computadoras.DataSource = null;
            dgv_computadoras.DataSource = misComputadoras;
        }
        
    }
}
