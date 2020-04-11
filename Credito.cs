using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solicitud_de_creditos
{
    class Credito
    {
        protected Cliente Clien;
        protected int Cuotas;
        protected int TazaDeInteres;
        protected int Montosolicitado;
        protected bool aprobado = false;

        public Credito(Cliente cliente, int cuotas, int monto)
        {

            this.Clien = cliente;
            this.Cuotas = cuotas;
            this.Montosolicitado = monto;
        }

        public void setCuotas(int cuotas)
        {

            this.Cuotas = cuotas;
        }

        public int getCuotas()
        {

            return this.Cuotas;
        }


        public Cliente getCliente()
        {

            return this.Clien;
        }

        public void setAprobado(bool boleano)
        {
            this.aprobado = boleano;
        }

        public bool getAprobado()
        {
            return this.aprobado;
        }


        protected int verificarPorcentajeDeSueldo() {

            String obtenerMonto = Clien.getSueldo().getMonto();

            int montoSueldo = Convert.ToInt32(obtenerMonto);

            montoSueldo += (montoSueldo / 2) + montoSueldo; //determina el 150 % del sueldo

            return montoSueldo;

        }

        public void determinarTazaDeInteres()
        {
            
        }

    }
    
}
