using System.Drawing;
namespace LibreriaDeAutos
{
    public class Auto
    {
        //A.Los atributos marca, cantCombustible, color.
        private string marca;
        private double cantCombustible;
        private Color color;
        //B. un constructor que inicialice todos los atributos.
        public Auto(string marca, double cantCombustible, Color color)
        {
            this.marca = marca;
            this.cantCombustible = cantCombustible;
            this.color = color;
        }
        public Auto(string marca, string cantCombustible, Color color)//3°Constructor
        {
            this.marca = marca;
            this.cantCombustible = double.Parse(cantCombustible);
            this.color = color;
        }
        public bool SetColor(Color nuevoColor)
        {
            bool retorno = false;
            if (nuevoColor == Color.Green || nuevoColor == Color.Red || nuevoColor == Color.Blue)
            {
                this.color = nuevoColor;//Establecer el color si es uno de los colores permitidos
                retorno = true; // Indicar que se pudo establecer el color
            }

            return retorno;// Devolver si se pudo establecer el color o no
        }

        //C. Solo metodos Get() para todos sus atributos.
        public string GetMarca() 
        {
            return marca;
        }

        public double GetCantCombustible() 
        {
            return cantCombustible;
        }
        public Color GetColor() 
        {
            return color;
        }
        //D. El metodo AutoToString(), este metodo debe retornar un string con toda su informacion.

        public string AutoToString() 
        {
            return $" Marca{this.marca} - Cantidad de combustible {this.cantCombustible} - Color{this.color.Name}";
        }
        //E. El metodo Avanzar(int km) que retornara un booleano para informar
        //si pudo recorrer o no la cantidad de kilometros recibo por parametro,
        //tener en cuenta que para poder avanzar se debe tener conbustible y
        //por cada litro de combustible se pueden 10km.
        public bool Avanzar(int km) 
        {
            bool retorno = false;
            double combNecesario = (double)km / 10.0;

            if (cantCombustible > 0 && cantCombustible >= combNecesario) 
            {
                cantCombustible -= combNecesario;
                retorno = true;
            }
            return retorno;
        }
        public bool ConvertirStringEnCombustible(string combustible) //De instancia
        {
            bool retorno = false;

            if (double.TryParse(combustible, out double combValido))
            {
                this.cantCombustible = combValido;
                retorno = true; 
            }
            return retorno; 
        }
       
        public static List<Color> ColoresValidos()
        {
            List<Color> list = new List<Color>()
            {
                Color.Red,Color.Purple,Color.Green,Color.Blue,Color.Black,Color.Salmon
            };
            return list;
        }
        public override string ToString() //Sobreecribir metodo ToString que es propio de los objetos
        {
            return this.AutoToString();
            //return "quiero morstrar los datos";
        }
    }
}
