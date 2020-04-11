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


            //Cliente [] clientes = new Cliente[2];

            Credito[] solicitudCreditos = new Credito[2];

            Menu men = new Menu();

            int numeroDeSolicitud = 1;

            for (int i = 0; i <= solicitudCreditos.Length - 1; i++)
            {

                Console.WriteLine("NUMERO DE SOLICITUD : " + numeroDeSolicitud);

                numeroDeSolicitud++;

                String nombre = men.solicitarNombre();
                String apellido = men.solicitarApellido();
                String monto = men.solicitarSueldo();

                Sueldo suel = new Sueldo();
                suel.setMonto(monto);

                String tipo = men.solicitartipoCliente(nombre, apellido);

                int montoSolicitado = men.solicitarMontoParaPrestamo();

                int cuotas = men.solicitarNumeroDeCuotas();

                if(tipo == "NORMAL")
                {
                    ClienteNormal clieNorma = new ClienteNormal(nombre, apellido, suel);
                    clieNorma.setTipo(tipo);

                    CreditoNormal credNorma = new CreditoNormal(clieNorma, cuotas, montoSolicitado);

                    solicitudCreditos[i] = credNorma;
                }

                else if(tipo == "PREMIUN")
                {
                    ClientePremiun cliePremi = new ClientePremiun(nombre, apellido, suel);
                    cliePremi.setTipo(tipo);

                    CreditoPremiun credPremi = new CreditoPremiun(cliePremi, cuotas, montoSolicitado);

                    solicitudCreditos[i] = credPremi;
                }
                

                Console.Clear();
            }

            numeroDeSolicitud = 1;

            for (int j = 0; j <= solicitudCreditos.Length-1; j++)
            {

                Console.WriteLine("SOLICITUD : " + numeroDeSolicitud);

                numeroDeSolicitud ++;

                Console.WriteLine("NOMBRE : " + solicitudCreditos[j].getCliente().getNombre() );
                Console.WriteLine("APELLIDO : " + solicitudCreditos[j].getCliente().getApellido() );
                Console.WriteLine("TIPO : " + solicitudCreditos[j].getCliente().getTipo() );

                solicitudCreditos[j].mostrarCredito();

                Console.WriteLine();
                Console.WriteLine();

            }

            Console.ReadKey();
        }
    }
}