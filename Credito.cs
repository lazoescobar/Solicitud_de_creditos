using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solicitud_de_creditos
{
    class Credito {

        Cliente Clie;
        protected int Cuotas;
        protected int Interes;
        protected int Montosolicitado;
        protected bool aprobado;

        public Credito(int cuotas, int monto) {

            this.Cuotas = cuotas;
            this.Montosolicitado = monto;
        }

        public void setCuotas(int cuotas) {

            this.Cuotas = cuotas;
        }

        public int getCuotas() {

            return this.Cuotas;
        }

        public void setAprobado(bool boleano) {

            this.aprobado = boleano;
        }

        public bool getAprobado() {

            return this.aprobado;
        }

        public virtual Cliente getCliente() {

            return this.Clie;
        }

        public virtual int obtenerEl150PorcientoDelSueldo() {

            int sueldo = 0;

            return sueldo;
        }

        public virtual void determinarSolicitud() { }


        protected int obtenerValorDeCuota(int montoSolicitadoConInteres) {

            int valorCuota = montoSolicitadoConInteres / Cuotas;

            return valorCuota;
        }

        protected void mostarDetalleDeSolicitud(String mensaje, int cuotas, int tazaInteres, String interes, String valorCuota) {

            Console.WriteLine("SU CREDIDO FUE : " + mensaje);
            Console.WriteLine("LAS CANTIDAD DE CUOTAS SON :" + cuotas);
            Console.WriteLine("LA TAZA DE INTERES DEL " + tazaInteres + "% "+  "QUE SE APLICA A ESTE CREDITO ES DE :   " + "$"+  interes);
            Console.WriteLine("EL VALOR DE CADA CUOTAS ES DE : " + "    $" + valorCuota);

        }

        private String colocarSeparadorDeMiles(int monto) {

            String saldoSinFormato = monto.ToString();
            String saldoEnFormatoChileno = "";

            int cont = 0;

            int subIndice = 1;

            for (int i = saldoSinFormato.Length - 1; i >= 0; i--) {

                saldoEnFormatoChileno += saldoSinFormato.Substring(i, subIndice);

                cont++;

                if ( cont == 3 ) {

                    saldoEnFormatoChileno += ".";

                    cont = 0;
                }
            }

            String saldoFormateado = "";

            for (int j = saldoEnFormatoChileno.Length - 1; j >= 0; j--) {

                saldoFormateado += saldoEnFormatoChileno.Substring(j, subIndice);
            }

            return saldoEnFormatoChileno = saldoFormateado;
        }


        private String ComprobarQueSaldoNoEmpiezeConPunto(int monto) {

            String saldoFormatoChileno = this.colocarSeparadorDeMiles(monto);

            String saldoVerificado = "";

            int subIndice = 1;

            for (int i = 0; i <= saldoFormatoChileno.Length - 1; i++) {

                if ( saldoFormatoChileno.Substring(0, 1).Equals(".") ) {

                    saldoVerificado = saldoFormatoChileno.Substring(subIndice, saldoFormatoChileno.Length - 1);
                    continue;
                }

                else {

                    saldoVerificado += saldoFormatoChileno.Substring(i, subIndice);
                }

            }

            return saldoVerificado;
        }

        protected String ConvertirAPesosChilenos(int monto) {

            String SaldoConvertido = this.ComprobarQueSaldoNoEmpiezeConPunto(monto);

            return SaldoConvertido;
        }

    }

}