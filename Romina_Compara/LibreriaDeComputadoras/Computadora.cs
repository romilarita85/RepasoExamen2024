using System.Text;

namespace LibreriaDeComputadoras
{
    public class Computadora
    {
        private int memoriaRam;
        private int capacidadDisco;
        private string procesador;
        private string sistemaOperativo;
        private List<string> programas;

        //❖	Constructor privado que solo instancia la lista de programas.
        private Computadora() 
        {
            this.programas = new List<string>();
        }

        //❖	Constructor público que asigna valores a todos sus campos excepto a la lista de programas.
        public Computadora(int memoriaRam, int capacidadDisco, string procesador, string sistemaOperativo):this()
        {
            this.memoriaRam = memoriaRam;
            this.capacidadDisco = capacidadDisco;
            this.procesador = procesador;
            this.sistemaOperativo = sistemaOperativo;

        }

        
        //❖	Método get que retorna la lista de programas.
        public List<string>Getprogramas()
        {
            return this.programas;
        }
        //❖	Método set que se encarga de agregar un programa a la lista.
        public void SetPrograma(string programa) 
        {
            this.programas.Add(programa);
        }
//❖	Método static ListadoDeProcesadores() que retorna una lista de al menos 5 tipos de procesadores.
        public static List<string>ListadoDeProcesadores() 
        {
            return new List<string> 
            { 
                "Word pad","Microsoft word","Google Docs","Mac os","Pentium"
            };
        }
//❖	Todas las propiedades son de solo lectura y retornan el valor de los atributos que hacen referencia,
//excepto Programas, esta propiedad retorna un string con todos los nombres de los programas concatenados.
        public int MemoriaRam { get => memoriaRam; }
        public int CapacidadDisco { get => capacidadDisco; }
        public string Procesador { get => procesador; }
        public string SistemaOperativo { get => sistemaOperativo; }

        public string Programas 
        {
            get 
            {
                StringBuilder stb = new StringBuilder();
                for (int i = 0; i>programas.Count; ++i)
                {
                    stb.Append(programas[i]);
                    if (i<programas.Count - 1)
                    {
                        stb.Append("-");
                    }

                
                }
                return stb.ToString();
            }
        }
    }
}

//Esta clase debe estar creada en una biblioteca de clases, respetar el encapsulamiento.

