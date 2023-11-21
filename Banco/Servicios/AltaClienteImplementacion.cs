using Banco.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Servicios
{
    internal class AltaClienteImplementacion : AltaClienteInterfaz
    {

        public void clienteAlta(List<ClientesDtos> listaAntigua)
        {
            /// <summary>
            /// Metodo el cual solicita losdatos al usuario y los añade a una lista de clientes
            /// DMN - 21/11/2023
            /// </summary>
            /// <param name="args"></param>

            ClientesDtos nuevoCliente = new ClientesDtos();

            Console.WriteLine("#############################");
            Console.WriteLine("####### Nuevo Usuario #######");
            Console.WriteLine("#############################");
            Console.WriteLine("### Introduzca sus Datos ####");
            Console.WriteLine("#############################");

            Console.WriteLine("Id: ");
            nuevoCliente.IdCliente = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Nombre: ");
            nuevoCliente.NombreCliente = Console.ReadLine();
            Console.WriteLine("Apellidos: ");
            nuevoCliente.ApellidosCliente = Console.ReadLine();
            Console.WriteLine("DNI: ");
            nuevoCliente.DniCliente = Console.ReadLine();
            Console.WriteLine("Fecha de Nacimiento: ");
            nuevoCliente.FchNacimientoCliente = Console.ReadLine();
            Console.WriteLine("Email: ");
            nuevoCliente.EmailCliente = Console.ReadLine();
            Console.WriteLine("Nº de Telfono: ");
            nuevoCliente.TlfCliente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fecha de Alta: ");
            nuevoCliente.FchAltaCliente = Console.ReadLine();
        }

    }
}
