using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solicitud_de_creditos
{
    class Credito
    {
        Cliente Clie;
        protected int Cuotas;
        protected int TazaDeInteres;
        protected int Montosolicitado;
        protected bool aprobado = false;

        public Credito( int cuotas, int monto)
        {

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



        public void setAprobado(bool boleano)
        {
            this.aprobado = boleano;
        }

        public bool getAprobado()
        {
            return this.aprobado;
        }

        public virtual void mostrarCredito()
        {
            Console.WriteLine("YO SOY CREDITO SOLO");
        }

        public virtual Cliente getCliente()
        {
            return this.Clie;
        }

        public virtual int obtenerEl150PorcientoDelSueldo()
        {
            int sueldo = 0;

            return sueldo; 
        }
    }
}