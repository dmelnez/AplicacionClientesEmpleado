using AplicacionClientesEmpleado.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionClientesEmpleado.Servicios
{
    internal class ValidadoresImplementacion : ValidadoresInterfaz
    {

        public void validadorAccesoCliente (List<AltaCliente> listaClientes)
        {

            Console.WriteLine("#######################");
            Console.WriteLine("######### LOGIN #######");
            Console.WriteLine("#######################");
            Console.WriteLine("EMAIL: ");
            string emailDeComprobacion = Console.ReadLine();

            Console.WriteLine("CONTRASEÑA: ");
            string contraseñaDeComprobacion = Console.ReadLine();

            /*
            foreach (string email in listaClientes)
            {





            }
            */





        }



    }
}
