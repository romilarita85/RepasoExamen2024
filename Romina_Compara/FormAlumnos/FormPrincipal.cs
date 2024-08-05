using Libreria_De_Estudiante;
namespace FormAlumnos
{
    public partial class FormPrincipal : Form
    {
        private List<Alumno> alumnos;//lista alumnos
        private List<Materia> materias;//lista materias

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //cargar listas
            alumnos = new List<Alumno>();
            materias = new List<Materia>();
            alumnos = Alumno.ListaAlumnos();//llamar metodo lista de alumnos
            lst_alumnos.DataSource = alumnos;
        }
        private void btn_agregarAlumno_Click(object sender, EventArgs e)
        {
            FormAltaAlumno formAltaAlumno = new FormAltaAlumno();
            formAltaAlumno.ShowDialog();
            if (formAltaAlumno.DialogResult == DialogResult.OK && formAltaAlumno.NuevoAlumno is not null) 
            {
                alumnos.Add(formAltaAlumno.NuevoAlumno);
                CargarLstAlumnos();
            }
        }
        private void btn_agregarMateria_Click(object sender, EventArgs e)
        {
            FormAltaMateria formAltaMateria = new FormAltaMateria();
            formAltaMateria.ShowDialog();
            if (formAltaMateria.DialogResult == DialogResult.OK)
            {
                materias.Add(formAltaMateria.NuevaMateria);
                CargarLstMaterias();
            }
        }
        private void btn_estadoAcad_Click(object sender, EventArgs e)
        {
            Alumno alumno = alumnos[0];//primer alumno
            List<Materia> lista = materias; //listado de materias
            string carrera = "Trayecto programacion";//pasar la carrera hardcodeada
            //crear nueva instancia del formulario con esos datos
            FormEstadoAcademico estadoAcademico = new FormEstadoAcademico(alumno, lista, carrera);

            estadoAcademico.ShowDialog();
        }
        private void CargarLstAlumnos() 
        {
            lst_alumnos.DataSource = null;
            lst_alumnos.DataSource = alumnos;

        }
        private void CargarLstMaterias()
        {
            lst_materias.DataSource = null;
            lst_materias.DataSource = materias;

        }
    }
}
