namespace Libreria_De_Estudiante
{
    public class Alumno
    {
        private string legajo;
        private string nombre;
        private string apellido;

        //PROPIEDADES ********************************************************************************************
        //Condicion de set y get al mismo tiempo.
        //Pueden ser autosostenidas. Puede ser una propiedad que utilice un atributo set y get.
        //puedo modificar la visibilidad del get/set
        //Validaciones dentro de un mismo metodo
        //Enmascarar un metodo dentro de una propiedad 
        //Va a hacer referencia a un atributo propio de la clase
        //puedo poner el nombre que quiera pero debe empezar con mayuscula ej: Legajo, Promedio,NotaFinal
        public string Legajo //Propiedad publica de legajo (de la clase)
        {
            get//Define el bloque de código que se ejecutará cuando se intente obtener el valor de la propiedad "Legajo".
            {
                return legajo;//Devuelve el valor de la variable de instancia "legajo".
            }
            set
            {//Define el bloque de código que se ejecutará cuando se intente asignar un valor a la propiedad "Legajo".
                this.legajo = value;//hace referencia a lo que yo haga
                                    //Asigna el valor proporcionado (value) a una variable de instancia llamada "legajo".
                                    //this.legajo = string.Empty;
            }
        }
        //"value" representa el valor que se está asignando a la propiedad.
        //valor que se está asignando a la propiedad en el momento de la asignación
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        //CONSTRUCTOR*************************************************************
        //●	Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
        public Alumno(string legajo, string nombre, string apellido)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public static List<Alumno> ListaAlumnos()
        {//El método ListaAlumnos() intenta crear y devolver una lista de objetos Alumno.
            return new List<Alumno>()
            {
            new Alumno("1001","Roxana","Gomez"),
            new Alumno("1002","Carlos","Ramos"),
            new Alumno("1003","Cesar","Vivas"),
            new Alumno("1004","Clara","Sanchez"),
            new Alumno("1005", "Andrea", "Alvares")
            };
        }

        public override string? ToString()//Metodo ToString propio de todos los objetos
        {
            return $"{apellido},{nombre}";
        }
    }

    //public string Mostrar()
    //{
    //    double notaFinal = CalcularNotaFinal();
    //    if (CalcularNotaFinal() == -1)
    //    {
    //        return $"Nombre: {nombre}\n" +
    //           $"Apellido: {apellido}\n" +
    //           $"Legajo: {legajo}\n" +
    //           $"Nota del primer parcial: {notaPrimerParcial}\n" +
    //           $"Nota del segundo parcial: {notaSegundoParcial}\n" +
    //           $"Promedio: {CalcularPromedio()}\n" +
    //           "Alumno desaprovado";
    //    }
    //    else 
    //    {
    //        return $"Nombre: {nombre}\n" +
    //           $"Apellido: {apellido}\n" +
    //           $"Legajo: {legajo}\n" +
    //           $"Nota del primer parcial: {notaPrimerParcial}\n" +
    //           $"Nota del segundo parcial: {notaSegundoParcial}\n" +
    //           $"Promedio: {CalcularPromedio()}\n" +
    //           $"Nota final: {notaFinal}";
    //    }
}

