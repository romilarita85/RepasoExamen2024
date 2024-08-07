using LibreriaDeComputadoras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormComputadora
{
    public partial class FormAlta : Form
    {
        Computadora nuevaComputadora;

        public Computadora NuevaComputadora { get => nuevaComputadora;}

        public FormAlta()
        {
            InitializeComponent();
        }
        private void FormAlta_Load(object sender, EventArgs e)
        {
            this.cmb_procesadores.DataSource = Computadora.ListadoDeProcesadores();
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string procesador = cmb_procesadores.Text;
            int memoriaRam = (int)num_memoriaRam.Value;
            int capacidadDisco = (int)num_disco.Value;
            string sistemaOperativo = string.Empty;
            List<string> programas = new List<string>();

            foreach (RadioButton rdt in gpb_sitemaOp.Controls)
            {
                if (rdt.Checked == true)
                {
                    sistemaOperativo = rdt.Text;
                    break;
                }

            }
            Computadora miComputadora = new Computadora(memoriaRam, capacidadDisco, procesador, sistemaOperativo);
            foreach (CheckBox chk in gpb_programas.Controls)
            {
                if (chk.Checked == true)
                {
                    miComputadora.SetPrograma(chk.Text);
                }
            }
            this.nuevaComputadora = miComputadora;
            DialogResult = DialogResult.OK;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

     
    }
}
