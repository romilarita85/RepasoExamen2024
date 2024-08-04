using LibreriaDeFunciones;
using LibreriaDeAutos;
namespace FormAuto
{
    public partial class FormAuto : Form
    {
        List<Auto> misAutos;
        public FormAuto()
        {
            InitializeComponent();
        }

        private void FormAuto_Load(object sender, EventArgs e)
        {
            misAutos = new List<Auto>();
            this.CargarCmb(Auto.ColoresValidos());
        }
        private void CargarCmb(List<Color> colores) 
        {
            this.cmb_colores.DataSource = colores;
        }
        private void btn_crear_Click(object sender, EventArgs e) //EVENTO
        {
            string marca = this.txt_marca.Text;
            string combustible = this.txt_cantidad.Text;
            Color color = (Color)this.cmb_colores.SelectedItem;

            DialogResult respuesta; // crear variable del tipo resultado que me devulva el metodo MensaggeBox

            if (this.ValidarEntradas(marca, combustible)) //Uso metodo Validar entradas
            { //auto solo se va a instanciar si el if me dio true (si cumple con validacion de marca y combustible)
                Auto miAuto = new Auto(marca, combustible, color); //crear objeto del tipo auto "miAuto"()

                respuesta = MessageBox.Show($"Decea agregar el auto {miAuto.GetMarca()}", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//se muestra el mensaje
             //parametros del MessageBox ->( ******************MENSAJE***********+****,**TITULO**, Que BOTONES va a tener ,********ICONO**********)

                if (respuesta == DialogResult.No)//DialogResult tiene los mismos valores de los botones (YesNo)
                {
                    MessageBox.Show("Auto no agregado");
                }
                else
                {
                    misAutos.Add(miAuto); //agrega el objeto miAuto a la lista llamada misAutos (lo agrega o no)
                }
                this.Limpiar();
                //Va  devolver un DialogResult
            }
        }
        private void Limpiar() //FUNCION
        {//función privada para borrar o "limpiar" los campos de entrada del formulario(interfaz gráfica de usuario).
            this.txt_marca.Text = string.Empty;
            this.txt_cantidad.Text = string.Empty;
            this.cmb_colores.Text = string.Empty;
        }

        private void btn_mostrar_Click(object sender, EventArgs e)//EVENTO
        {//muestras los autos en el ListBox lst_misAutos.
            this.VaciarLst();//antes de cargar la lista me aseguro q se vacie
            this.lst_autos.Items.AddRange(misAutos.ToArray());
        }

        private void btn_limpiar_Click(object sender, EventArgs e)//EVENTO
        { //vacías el ListBox lst_misAutos.
            this.VaciarLst();
        }
        private void VaciarLst() //METODO (no asociado a un evento) Lo voy a cargar dos veces (en evento mostrar y limpiar)
        {
            this.lst_autos.Items.Clear();
            //El método Clear() se utiliza para eliminar todos los elementos de una colección.
        }
        private bool ValidarEntradas(string marca, string combustible) //Metodo para validar-> Creo un constructor 3°
        {//validas la entrada del usuario para la marca y el combustible del auto.
            bool ok = true;
            if (!MisFunciones.EsSoloLetras(marca)) //EsSoloLetras metodo de LibreriaDeFunciones (llamo a la clase MisFunciones)
            {//si devuelve un false
                MessageBox.Show("La marca debe ser solo letras");
                ok = false;
            }
            if (!MisFunciones.EsNumerico(combustible))//EsNumerico metodo de LibreriaDeFunciones
            {
                MessageBox.Show("El combustible debe ser numerico");
                ok = false;
            }
            return ok;
        }
        //Precisaba recibir un array pero ese array no se podia convertir -Creamos metodo
      
    }
}
