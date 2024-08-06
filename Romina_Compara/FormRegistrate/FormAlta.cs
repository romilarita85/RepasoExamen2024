using LibreriaDeIngresantes;
namespace FormRegistrate
{
    public partial class FormAlta : Form
    {
        Ingresante nuevoIngresante;

        public Ingresante NuevoIngresante { get => nuevoIngresante; }

        public FormAlta()
        {
            InitializeComponent();
        }
        private void FormAlta_Load(object sender, EventArgs e)
        {
            lst_paises.DataSource = new List<string>()
            {
                "Colombia","Argentina","Venezuela","Chile","Peru","Uruguay"
            };
            
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            int edad = (int)num_edad.Value;
            string pais = lst_paises.Text;
            string genero = string.Empty;
            List<string> cursos = new List<string>();//instanciar la lista de cursos

            foreach (RadioButton rd in gpb_genero.Controls)
            {
                if (rd.Checked == true) //para verificar el componente (rd)q acabamps de sacar-> ver en q estado esta
                {                    //si es true ->fue chequeado
                    genero = rd.Text;// solo puede chekear uno
                    break;
                }


            }
            foreach (CheckBox chk in gpb_cursos.Controls)
            {
                if (chk.Checked == true) 
                {
                    cursos.Add(chk.Text);//lista de cursos punto Add(chek)
                }

            }

            nuevoIngresante = new Ingresante(nombre, apellido, edad, genero,pais, cursos);

            DialogResult = DialogResult.OK;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        
    }
}
