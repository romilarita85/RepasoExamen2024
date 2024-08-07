using LibreriaDeLapiceras;
namespace FormLapiceras
{
    public partial class FormPrincipal : Form
    {
        List<Lapicera> lapiceras;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            lapiceras = new List<Lapicera>();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FormAlta formAltaLapicera = new FormAlta();
            formAltaLapicera.ShowDialog();

            if (formAltaLapicera.DialogResult == DialogResult.OK) 
            {
                lapiceras.Add(formAltaLapicera.NuevaLapicera);
                CargarDGV();
            }
        }
        private void CargarDGV() 
        {
            dgv_lapiceras.DataSource = null;
            dgv_lapiceras.DataSource = lapiceras;

        }
    }
}
