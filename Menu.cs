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

                if ( vali.EsNombre( apellido ) == false) {

                    Console.Clear();
                    Console.WriteLine("Error...... apellido invalido " + "\n");
                }

            } while ( vali.EsApelllido( apellido ) == false );

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

                if ( vali.EsSueldo( sueldo ) == false) {

                    Console.Clear();
                    Console.WriteLine("Error...... sueldo invalido " + "\n");
                }

            } while ( vali.EsSueldo( sueldo ) == false );

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

                if ( vali.EsOpcion( Opcion ) == false ) {

                    Console.Clear();

                    Console.WriteLine("Error......Opcion invalida " + "\n");
                }

                else
                {
                    opcRespondida = Convert.ToInt32( Opcion );

                    if(opcRespondida == 1) {

                        Opcion = "NORMAL";
                        break;
                    }

                    else
                    {
                        Opcion = "PREMIUN";
                        break;
                    }
                    
                }

            } while (vali.EsOpcion( Opcion ) == false);

            Console.WriteLine();


            return Opcion;

        }
    }
}
