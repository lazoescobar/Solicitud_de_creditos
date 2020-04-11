using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solicitud_de_creditos
{
    class Program
    {
        static void Main(string[] args)
        {


            Credito [] solicitudCreditos = new Credito[3];

            Menu men = new Menu();

            int numeroDeSolicitud = 1;

            for (int i = 0; i <= solicitudCreditos.Length-1; i++) {

                Console.WriteLine("NUMERO DE SOLICITUD : " + numeroDeSolicitud);

                numeroDeSolicitud ++; 

                String nombre = men.solicitarNombre();
                String apellido = men.solicitarApellido();
                String monto = men.solicitarSueldo();

                Sueldo suel = new Sueldo(monto);

                Cliente clie = new Cliente(nombre, apellido, suel);

                String tipo = men.solicitartipoCliente(clie);

                clie.setTipo(tipo);

                int montoSolicitado = men.solicitarMontoParaPrestamo();

                int cuotas = men.solicitarNumeroDeCuotas();

                CreditoNormal cre_norma = new CreditoNormal(clie, cuotas, montoSolicitado);
                CreditoPremiun cre_prem = new CreditoPremiun(clie, cuotas, montoSolicitado);

                if(clie.getTipo() == "NORMAL")
                {
                    solicitudCreditos[i] = cre_norma;
                }
                else if(clie.getTipo() == "PREMIUN")
                {
                    solicitudCreditos[i] = cre_prem;
                }

                Console.Clear();
            }




            numeroDeSolicitud = 1;

            //MOSTRA TODAS LAS SOLICITUDES
            for (int j = 0; j <= solicitudCreditos.Length - 1; j++) {

                Console.WriteLine(" SOLICITUD  NUMERO : " + numeroDeSolicitud);
                Console.WriteLine();

                numeroDeSolicitud++;

                Console.WriteLine(" CLIENTE " + "  \n " + "Nombre : " + solicitudCreditos[j].getCliente().getNombre() );
                Console.WriteLine("Apellido :" + solicitudCreditos[j].getCliente().getApellido() );
                Console.WriteLine("Tipo :" + solicitudCreditos[j].getCliente().getTipo() );

                
            }


            Console.ReadKey();
        }
    }
}
