using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAritmetica.Servicios
{
    /// <summary>
    /// Implementacion de las acciones del menu
    /// 111023 - JL
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;
            Console.WriteLine("##############################");
            Console.WriteLine("0. Cerrar aplicacion");
            Console.WriteLine("1. dividir");
            Console.WriteLine("2. multiplicar");
            Console.WriteLine("3. sumar");
            Console.WriteLine("4. restar");
            Console.WriteLine("Seleccione una opcion: ");
            Console.WriteLine("##############################");
            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;

        }
    }
}