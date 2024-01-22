using AplicacionClientesEmpleado.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionClientesEmpleado.Servicios
{
    internal interface ClienteOperativaInterfaz
    {
        public void registroCliente(List<AltaCliente> listaClientes);
    }
}
