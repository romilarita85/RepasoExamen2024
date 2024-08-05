using Libreria_De_Estudiante;
namespace FormAlumnos
{
    public partial class FormPrincipal : Form
    {
        private List<Alumno> alumnos;
        private List<Materia> materias;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //cargar listas
        }
        private void btn_agregarAlumno_Click(object sender, EventArgs e)
        {
            FormAltaAlumno formAltaAlumno = new FormAltaAlumno();
            formAltaAlumno.ShowDialog();
            if (formAltaAlumno.DialogResult == DialogResult.OK) 
            {
                alumnos.Add(formAltaAlumno.NuevoAlumno);
            }
        }
        private void btn_agregarMateria_Click(object sender, EventArgs e)
        {
            FormAltaMateria formAltaMateria = new FormAltaMateria();
            formAltaMateria.ShowDialog();
            if (formAltaMateria.DialogResult == DialogResult.OK)
            {
                materias.Add(formAltaMateria.NuevaMateria);

            }
        }

        private void btn_estadoAcad_Click(object sender, EventArgs e)
        {
            FormEstadoAcademico formEstadoAcademico = new FormEstadoAcademico();
            formEstadoAcademico.ShowDialog();

        }
    }
}
