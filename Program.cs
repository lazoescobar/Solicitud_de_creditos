using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solicitud_de_creditos
{
    class Program
    {
        static void Main(string[] args) {

            Credito[] solicitudCreditos = new Credito[1];

            Menu men = new Menu();

            int numeroDeSolicitud = 1;

            for (int i = 0; i <= solicitudCreditos.Length - 1; i++) {

                Console.WriteLine("NUMERO DE SOLICITUD : " + numeroDeSolicitud + "\n\n");

                numeroDeSolicitud++;

                String nombre = men.solicitarNombre();
                String apellido = men.solicitarApellido();
                int montoSueldo = men.solicitarSueldo();

                Sueldo suel = new Sueldo();
                suel.setMonto(montoSueldo);

                String tipo = men.solicitartipoCliente(nombre, apellido);

                int montoSolicitado = men.solicitarMontoParaPrestamo();

                int cuotas = men.solicitarNumeroDeCuotas();

                if(tipo == "NORMAL") {

                    ClienteNormal clieNorma = new ClienteNormal(nombre, apellido, suel);
                    clieNorma.setTipo(tipo);

                    CreditoNormal credNorma = new CreditoNormal(clieNorma, cuotas, montoSolicitado);

                    solicitudCreditos[i] = credNorma;
                }

                else if(tipo == "PREMIUN") {

                    ClientePremiun cliePremi = new ClientePremiun(nombre, apellido, suel);
                    cliePremi.setTipo(tipo);

                    CreditoPremiun credPremi = new CreditoPremiun(cliePremi, cuotas, montoSolicitado);

                    solicitudCreditos[i] = credPremi;
                }
                
                Console.Clear();
            }


            numeroDeSolicitud = 1;

            Console.Write("REGLAS : " + "\n" +
                          " * La cantidad de cuotas debe ser de 6 hasta 24 como maximo, si el clientes es premiun puede optar hasta 36 coutas." + "\n" +
                          " * El monto a solicitar no debe ser mayor al 150% del sueldo del solicitante. " + "\n" +
                          " * La tasa de interes es de 10%, si el clientes es premiun se aplica una tasa del 5%." + "\n\n");

            Console.WriteLine("-----------CLIENTES----------" + "\n\n");


            for (int j = 0; j <= solicitudCreditos.Length-1; j++) {

                Console.WriteLine("SOLICITUD : " + numeroDeSolicitud);

                numeroDeSolicitud ++;

                Console.WriteLine("NOMBRE : " + solicitudCreditos[j].getCliente().getNombre() );
                Console.WriteLine("APELLIDO : " + solicitudCreditos[j].getCliente().getApellido() );
                Console.WriteLine("TIPO : " + solicitudCreditos[j].getCliente().getTipo() );

                solicitudCreditos[j].determinarSolicitud();

                Console.WriteLine();
                Console.WriteLine();

            }

            Console.ReadKey();
        }
    }
}