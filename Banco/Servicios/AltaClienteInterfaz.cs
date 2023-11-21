using Banco.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Servicios
{
    internal interface AltaClienteInterfaz
    {
        /// <summary>
        /// Interfaz de la implementacion
        /// DMN - 21/11/2023
        /// </summary>
        /// <param name="args"></param>
        /// 
        public void clienteAlta(List<ClientesDtos> listaAntigua);
    }
}
