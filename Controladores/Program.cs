using CalculadoraAritmetica.Servicios;
using CalculadoraAritmetica2.Servicios;

namespace CalculadoraAritmetica
{
    /// <summary>
    /// Clase que controla el flujo de procedimientos de la aplicacion
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo de entrada a la aplicacion
        /// Contiene el flujo de la aplicacion
        /// 111023 - JL
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //Llamada al metodo. Imprime el mensaje por consola
            MenuInterfaz Mi = new MenuImplementacion();
            OperacionesInterfaz Oi = new OperacionesImplementacion();
            //Variable que controla la entrada y salida del while
            bool cerrarMenu = false;
            //Opcion del usuario
            int opcionElegida;

            while (!cerrarMenu)
            {

                opcionElegida = Mi.mostrarMenuYSeleccion();


                switch (opcionElegida)
                {
                    case 0:
                        Console.WriteLine("[INFO] - Se cierra el menu.");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("[INFO] - Has seleccionado la operación dividir. ");
                        Oi.dividir();
                        break;

                    case 2:
                        Console.WriteLine("[INFO] - Has seleccionado la operacion multiplicar. ");
                        Oi.multiplicar();
                        break;
                    
                    case 3:
                        Console.WriteLine("[INFO] - Has seleccionado la operacion Sumar. ");
                        Oi.Sumar();
                        break;
                    
                    case 4:
                        Console.WriteLine("[INFO] - Has saleccionado la operacion restar. ");
                        Oi.restar();
                        break;

                    default:
                        Console.WriteLine("[INFO] - Esta opccion no coincide con ninguna. ");
                        break;
                        
                }   
            }
        }
    }
}