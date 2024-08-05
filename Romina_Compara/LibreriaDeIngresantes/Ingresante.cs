using System.Text;

namespace LibreriaDeIngresantes
{
    public class Ingresante
    {
        private List<string> cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string paises;

        public Ingresante(List<string> cursos, string direccion, int edad, string genero, string nombre, string paises)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.paises = paises;
        }
       
        public string Direccion { get => direccion; set => direccion = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Paises { get => paises; set => paises = value; }
        //lista de string genera problemas al usar DataGrew
        //Solucion ->usar StringBuilder
        public string Cursos
        {
            get
            {
                StringBuilder sb = new StringBuilder();//crea un nuevo objeto StringBuilder.
                                                      

                for (int i = 0; i < cursos.Count; i++)
                {//Este bucle itera a través de cada elemento en la colección cursos.
                    sb.Append(cursos[i]);//agrega el nombre del curso en el índice i de la colección
                    //cursos al StringBuilder.

                    if (i < cursos.Count - 1)
                    {//Verifica si el curso actual no es el último(basado en el índice comenzando desde cero).
                     //Si no es el último curso, agrega " - " para separar los cursos.
                        sb.Append(" - ");
                    }
                }
                return sb.ToString();//return sb.ToString(); convierte el objeto StringBuilder a una
                                     //cadena de texto y retorna el resultado concatenado.   
            }
        }


        //public string Mostrar() 
        //{
        //    return $"Cursos: {cursos}- Direccion: {direccion} - Edad {edad} - Genero: {genero} - Nombre: {nombre} - Paises: {paises}";
        //}

    }
    
}

