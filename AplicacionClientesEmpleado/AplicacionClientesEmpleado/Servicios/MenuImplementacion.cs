using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionClientesEmpleado.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuPrincipal() {

            Console.WriteLine("############################");
            Console.WriteLine("# [0] -> Cerrar Aplicacion #");
            Console.WriteLine("# [1] -> Acceso Empleado   #");
            Console.WriteLine("# [2] -> Acceso Cliente    #");
            Console.WriteLine("############################");

            int seleccionMenuPrincipal = Convert.ToInt32(Console.ReadLine());


            return seleccionMenuPrincipal; }

        public int menuEmpleado() {

            Console.WriteLine("###############################");
            Console.WriteLine("# [0] -> Cerrar Ventana       #");
            Console.WriteLine("# [1] -> Validar Cliente      #");
            Console.WriteLine("# [2] -> Borrado de Cliente   #");
            Console.WriteLine("# [3] -> Mostrar Cliente      #");
            Console.WriteLine("###############################");

            int seleccionMenuEmpleado = Convert.ToInt32(Console.ReadLine());

            return seleccionMenuEmpleado; }

        public int menuCliente() {

            Console.WriteLine("#################################");
            Console.WriteLine("# [0] -> Cerrar Ventana         #");
            Console.WriteLine("# [1] -> Registro Cliente       #");
            Console.WriteLine("# [2] -> Acceso Cliente (Login) #");
            Console.WriteLine("#################################");
            
            int seleccionMenuCliente = Convert.ToInt32(Console.ReadLine());


            return seleccionMenuCliente; }
    }
}
