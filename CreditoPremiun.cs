using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solicitud_de_creditos
{
    class CreditoPremiun : Credito {

        private ClientePremiun cliePrem;
        private readonly int TazaInteres = 5; // hace referencia a % 

        public CreditoPremiun(ClientePremiun clientePremiun, int cuotas, int monto) : base(cuotas, monto) {

            this.cliePrem = clientePremiun;
        }

        public override Cliente getCliente() {

            return this.cliePrem;
        }

        public override int obtenerEl150PorcientoDelSueldo() {

            int sueldo = Convert.ToInt32(cliePrem.getSueldo().getMonto());

            int sueldoEn150porciento = (sueldo / 2) + sueldo;

            return sueldoEn150porciento;
        }

        public override void determinarSolicitud() {

            String mensajeDeApruebo = "";

            int valorCuota = 0;

            int sueldoEn150porciento = this.obtenerEl150PorcientoDelSueldo();

            this.Interes = (TazaInteres * this.Montosolicitado) / 100; //se obtiene el 5 % de interes al monto solicitado

            if (this.Montosolicitado <= sueldoEn150porciento) {

                if (this.Cuotas >= 6 && this.Cuotas <= 36) {

                    Montosolicitado += Interes;

                    this.aprobado = true;
                    mensajeDeApruebo = "APROBADO";

                    valorCuota +=  this.obtenerValorDeCuota(Montosolicitado);

                    this.mostarDetalleDeSolicitud(mensajeDeApruebo, Cuotas, this.TazaInteres, Interes, valorCuota);
                }
                else {

                    this.aprobado = false;
                    mensajeDeApruebo = "REPROBADO";

                    Console.WriteLine("SU CREDIDO FUE : " + mensajeDeApruebo); 
                }
            }
            else {


                this.aprobado = false;
                mensajeDeApruebo = "REPROBADO";

                Console.WriteLine("SU CREDIDO FUE : " + mensajeDeApruebo);
            }

        }

    }

}

