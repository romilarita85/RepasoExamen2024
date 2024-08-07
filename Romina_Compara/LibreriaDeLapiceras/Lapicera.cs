using System.Drawing;

namespace LibreriaDeLapiceras
{
    public class Lapicera
    {//-Crear la clase lapicera, esta debe tener los atributos: color, precio, marca, nivelDeTinta.
        private Color color;
        private int precio;
        private string marca;
        private int nivelDeTinta = 100;//-Todas las lapiceras se crean con el nivel de tinta al 100.

        //-Crear propiedades todas las propiedad de lectura.
      
        public int Precio { get => precio; }
        public string Marca { get => marca;  }
        public int NivelDeTinta { get => nivelDeTinta;  }
        public Color Color { get => color;  }

        //-Un constructor que inicialice color, precio, marca.
        public Lapicera(int nivelDeTinta)
        {
            this.nivelDeTinta = nivelDeTinta;
        }

        public Lapicera(Color color, int precio, string marca)
        {
            this.color = color;
            this.precio = precio;
            this.marca = marca;
        }

        //-Sobreescribir el metodo ToString() para que muestre todos sus valores.
        public string LapiceraToString() 
        {
            return $"Color: {this.Color} - Precio {this.precio} - Marca {this.marca} - Nivel de tinta: {this.nivelDeTinta}";
        }
        public override string ToString()
        {
            return LapiceraToString();
        }
        //-Crear el metodo public. bool Escribir(int cantLetras), donde cada letra consume un nivel de tinta,
        //el metodo debe verificar si tiene tinta para escribir la cantidad de letas solicitadas por parametro
        //en informara con un true o false si le alcanzo.

        
        public bool Escribir(int cantLetras) 
        {
            bool sePuedeEscribir = false;
            if(nivelDeTinta >= cantLetras) 
            { 
                nivelDeTinta -= cantLetras; //nivelDeTinta = nivelDeTinta - cantLetras;
                sePuedeEscribir = true;
            
            }
            return sePuedeEscribir;
        }
        //-El metodo public void Recargar() que colocara el nivel a 100 nuevamente.
        public void Recargar() 
        {
            this.nivelDeTinta = 100;
        
        }
        public static List<Color> ColoresValidos()
        {
            List<Color> list = new List<Color>()
            {
                Color.Black,Color.Blue,Color.Orange,Color.Green,Color.Red,Color.Yellow
            };
            return list;
        }
    }
}





//Al igual que hicimos con los formularios de ingresante, crear dos forms, el principal con el datagridview y el boton agregar y el fomrAlta para crear lapiceras, utilizar groupbox, combobox y la mayor variedad de componentes posibles.
//.

