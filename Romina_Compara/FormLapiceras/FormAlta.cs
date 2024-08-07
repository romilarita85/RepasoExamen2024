using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaDeLapiceras;

namespace FormLapiceras
{
    public partial class FormAlta : Form
    {
        Lapicera nuevaLapicera;
        public Lapicera NuevaLapicera { get => nuevaLapicera; }
        public FormAlta()
        {
            InitializeComponent();
        }
        private void FormAlta_Load(object sender, EventArgs e)
        {
            this.cmb_colores.DataSource = Lapicera.ColoresValidos();
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Color color = (Color)cmb_colores.SelectedItem;
            int precio = (int)num_precio.Value;
            string marca = string.Empty;

            foreach (RadioButton rd in gpb_marcas.Controls)
            {
                if (rd.Checked == true)
                {
                    marca = rd.Text;
                    break;
                }
            }

            nuevaLapicera = new Lapicera(color, precio, marca);
            DialogResult = DialogResult.OK;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    
    }
}
