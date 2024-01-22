using AplicacionClientesEmpleado.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionClientesEmpleado.Servicios
{
    internal interface ValidadoresInterfaz
    {
        public void validadorAccesoCliente(List<AltaCliente> listaClientes);
    }
}
