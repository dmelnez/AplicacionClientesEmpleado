using AplicacionClientesEmpleado.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionClientesEmpleado.Servicios
{
    internal class ClienteOperativaImplementacion : ClienteOperativaInterfaz
    {
        public void registroCliente(List<AltaCliente> listaClientes)
        {
            
            AltaCliente nuevoCliente = new AltaCliente();

            Console.WriteLine("################################");
            Console.WriteLine("# Se dara de alta como cliente #");
            Console.WriteLine("################################");

            Console.WriteLine("DNI: ");
            nuevoCliente.DniCliente = Console.ReadLine();
            Console.WriteLine("NOMBRE COMPLETO: ");
            string nombreCompleto = Console.ReadLine();
            nuevoCliente.NombreCompletoCliente = nombreCompleto;

            Console.WriteLine("EMAIL: ");
            nuevoCliente.EmailCliente = Console.ReadLine();

            Console.WriteLine("CONTRASEÑA: ");
            nuevoCliente.ContraseniaCliente = Console.ReadLine();

            // Asignacion de los campos mediante la division de los mismos en el nombre Completo


            char caracter = ',';
            string[] nombreSeparado = nombreCompleto.Split(caracter);
            foreach (string trozo in nombreSeparado)
            {
                Console.WriteLine(trozo);
            }
            nuevoCliente.Apellido2Cliente = nombreSeparado[0];
            string apellidoPrimeroSeparado;
            string apellidoSegundoSeparado;


            /*
            nuevoCliente.NombreCliente = nombreSeparado;
            nuevoCliente.Apellido1Cliente = apellidoPrimeroSeparado;
            nuevoCliente.Apellido2Cliente = apellidoSegundoSeparado;

            */

            // Añadir un nuevo cliente a la lista de los clientes en su totalidad
            listaClientes.Add(nuevoCliente);






        }

    }
}
