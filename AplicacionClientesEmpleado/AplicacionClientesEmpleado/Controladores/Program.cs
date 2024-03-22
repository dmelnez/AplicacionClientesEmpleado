
using AplicacionClientesEmpleado.Servicios;
using AplicacionClientesEmpleado.Dtos;
class Progam
{

    public static void Main(string[] args)
    {

        MenuInterfaz me = new MenuImplementacion();

        ValidadoresInterfaz val = new ValidadoresImplementacion();

        ClienteOperativaInterfaz cli = new ClienteOperativaImplementacion();

        EmpleadoOperativaInterfaz em = new EmpleadoOperativaImplementacion();

        List<AltaCliente> listaClientes = new List<AltaCliente>();


        // -------------------------------------------------------------------------------
        int seleccionMenuPrincipal;
        bool cerrarMenuPrincipal = false;

        Console.WriteLine("a");

        while (!cerrarMenuPrincipal)
        {
            seleccionMenuPrincipal = me.menuPrincipal();

            switch (seleccionMenuPrincipal)
            {
                case 0:

                    cerrarMenuPrincipal = true;

                    break;

                case 1:
                    // Entrar en modo Empleado
                    // Se muestra el siguiente menu
                    int seleccionMenuEmpleado = me.menuEmpleado();

                    switch (seleccionMenuEmpleado)
                    {

                        case 0:
                            // El empleado se le enviara al Menu Principal
                            break;

                        case 1:
                            // Metodo que validara a un Cliente
                            break;

                        case 2:
                            // Metodo que Borrara a un Cliente

                            break;

                        case 3:
                            // Metodo que Mostrara los datos de los clientes
                            /*em.mostrarCliente(listaClientes);*/
                            
                            foreach ( AltaCliente alt in listaClientes) { 
                            Console.WriteLine(alt.ToString());
                            }


                            break;



                    }
                  

                    break;

                case 2:
                    // Entrar en modo Cliente
                    // Se muestra el siguiente Menu
               

                    int seleccionMenuCliente = me.menuCliente();

                    switch (seleccionMenuCliente)
                    {

                        case 0:
                            // El cliente se le enviara al Menu Principal
                            break;
                        case 1:
                            // Metodo de registra al Cliente

                            cli.registroCliente(listaClientes);

                            break;

                        case 2:
                            //Metodo que logea al cliente y comprueba si es valido

                            val.validadorAccesoCliente(listaClientes);


                            break;


                    }

                    break;

                default:
                    break;




            }



        }

        // -------------------------------------------------------------------------------





    }
}
