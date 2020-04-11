using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solicitud_de_creditos
{
    class CreditoNormal : Credito
    {
        private ClienteNormal clieNorma;

        public CreditoNormal(ClienteNormal clienteNormal, int cuotas, int monto) : base(cuotas, monto)
        {
            this.clieNorma = clienteNormal;
        }

        public override void mostrarCredito()
        {
            Console.WriteLine("YO SOY CREDITO NORMAL");
        }

        public override Cliente getCliente()
        {
            return this.clieNorma;
        }

        public override int obtenerEl150PorcientoDelSueldo()
        {
            int sueldo = Convert.ToInt32( clieNorma.getSueldo().getMonto() ) ;

            int sueldoEn150porciento = (sueldo / 2) + sueldo;

            return sueldoEn150porciento;
        }
    }
}
