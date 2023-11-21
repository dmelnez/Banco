using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        /// <summary>
        /// Metodo el cual Muestra al usuario un menu de seleccion
        /// DMN - 21/11/2023
        /// </summary>
        /// <param name="args"></param>

        public int menu()
        {

            Console.WriteLine("########## Seleccione una Opcion ##########");
            Console.WriteLine("0 -> Finalizar la Aplicacion");
            Console.WriteLine("1 -> Añadir un Nuevo usuario");
            Console.WriteLine("2 -> Crear cuenta Bancaria");
            Console.WriteLine("###########################################");
            int seleccionMenu = Convert.ToInt32(Console.ReadLine());
            return seleccionMenu;

        }
    }
}
