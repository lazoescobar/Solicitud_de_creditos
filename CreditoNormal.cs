using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solicitud_de_creditos
{
    class CreditoNormal : Credito {

        private ClienteNormal clieNorma;
        private readonly int TazaInteres = 10; // hace referencia a % 

        public CreditoNormal(ClienteNormal clienteNormal, int cuotas, int monto) : base(cuotas, monto) {

            this.clieNorma = clienteNormal;
        }

        public override Cliente getCliente() {

            return this.clieNorma;
        }

        public override int obtenerEl150PorcientoDelSueldo() {

            int montoSueldo = clieNorma.getSueldo().getMonto();

            int sueldoEn150porciento = (150 * montoSueldo) / 100;

            return sueldoEn150porciento;
        }


        public override void determinarSolicitud() {

            String mensajeDeApruebo = "";

            int valorCuota = 0;

            int sueldoEn150porciento = this.obtenerEl150PorcientoDelSueldo();

            this.Interes = (TazaInteres * this.Montosolicitado) / 100; //se obtiene el 5 % de interes al monto solicitado

            if ( this.Montosolicitado <= sueldoEn150porciento ) {

                if ( this.Cuotas >= 6 && this.Cuotas <= 24 ) {

                    Montosolicitado += Interes;

                    this.aprobado = true;
                    mensajeDeApruebo = "APROBADO";

                    valorCuota += this.obtenerValorDeCuota(Montosolicitado);

                    this.mostarDetalleDeSolicitud(mensajeDeApruebo, Cuotas, this.TazaInteres, this.ConvertirAPesosChilenos(Interes), this.ConvertirAPesosChilenos(valorCuota));
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
