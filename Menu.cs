using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solicitud_de_creditos
{
    class Menu
    {
        private Validacion vali;

        public string solicitarNombre() {

            vali = new Validacion();

            String nombre;

            do
            {

                Console.WriteLine("Ingrese un nombre Porfavor : " + "\n");

                nombre = Console.ReadLine();

                if (vali.EsNombre(nombre) == false)
                {

                    Console.Clear();
                    Console.WriteLine("Error...... nombre invalido " + "\n");
                }

            } while (vali.EsNombre(nombre) == false);

            Console.WriteLine();

            return nombre;
        }


        public string solicitarApellido()
        {
            vali = new Validacion();

            String apellido;

            do
            {

                Console.WriteLine("Ingrese un apellido : " + "\n");

                apellido = Console.ReadLine();

                if (vali.EsNombre(apellido) == false) {

                    Console.Clear();
                    Console.WriteLine("Error...... apellido invalido " + "\n");
                }

            } while (vali.EsApelllido(apellido) == false);

            Console.WriteLine();

            return apellido;
        }

        public String solicitarSueldo() {

            vali = new Validacion();

            String sueldo;

            do
            {

                Console.WriteLine("Ingrese sueldo del cliente : " + "\n");

                sueldo = Console.ReadLine();

                if (vali.EsMontoDeDinero(sueldo) == false) {

                    Console.Clear();
                    Console.WriteLine("Error...... sueldo invalido " + "\n");
                }

            } while (vali.EsMontoDeDinero(sueldo) == false);

            Console.WriteLine();

            return sueldo;
        }

        public String solicitartipoCliente(Cliente cliente) {

            vali = new Validacion();

            String Opcion;

            int opcRespondida = 0;

            do
            {

                Console.WriteLine("Eliga el tipo de cliente para : " + cliente.getNombre() + " " + cliente.getApellido() + "\n" +
                                  "-------- TIPOS DE CLIENTES ------------" + "\n" +
                                  "(1) CLIENTE NORMAL " + "\n" +
                                  "(2) CliENTE PREMIUN " + "\n");


                Opcion = Console.ReadLine();

                if (vali.EsOpcion(Opcion) == false) {

                    Console.Clear();

                    Console.WriteLine("Error......Opcion invalida " + "\n");
                }

                else
                {
                    opcRespondida = Convert.ToInt32(Opcion);

                    if (opcRespondida == 1) {

                        Opcion = "NORMAL";
                        break;
                    }

                    else
                    {
                        Opcion = "PREMIUN";
                        break;
                    }

                }

            } while (vali.EsOpcion(Opcion) == false);

            Console.WriteLine();


            return Opcion;

        }

        public int solicitarMontoParaPrestamo()
        {

            vali = new Validacion();

            String montoSolicitado;

            int monto;

            do
            {

                Console.WriteLine(" ingrese monto de dinero para la soliciud : ");

                montoSolicitado = Console.ReadLine();

                if ( vali.EsMontoDeDinero( montoSolicitado ) == false ) {

                    Console.Clear();

                    Console.WriteLine("Error...... formato monto invalido " + "\n");
                }

            } while ( vali.EsMontoDeDinero( montoSolicitado ) == false );

            Console.WriteLine();

            monto = Convert.ToInt32(montoSolicitado);

            return monto;

        }

        public int solicitarNumeroDeCuotas() {

            vali = new Validacion();

            String cuotas;

            int cantidasCuotas = 0;

            do
            {
                Console.WriteLine("ingrese cantidad de cuotas : ");

                cuotas = Console.ReadLine();


                if( vali.EsCuotas( cuotas ) == false ) {

                    Console.Clear(); 

                    Console.WriteLine("Error.... ingreso de cuotas invalido ");

                    continue;

                }

                cantidasCuotas = Convert.ToInt32(cuotas);

                if( cantidasCuotas <= 0 ) {

                    Console.Clear();

                    Console.WriteLine("Error...... numero de cuotas no puede ser menor o igual a 0");

                }
                else if( cantidasCuotas > 52 ) {

                    Console.Clear();

                    Console.WriteLine("Error... numero de cuotas excede cualquier tipo de credito...(Maximo 48)");
                }

            } while ( vali.EsCuotas(cuotas) == false || cantidasCuotas <= 0 || cantidasCuotas > 52 );

            return cantidasCuotas;
        }
    }
}
