using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solicitud_de_creditos
{
    class CreditoPremiun : Credito
    {
        public CreditoPremiun(Cliente cliente, int cuotas, int monto) : base(cliente, cuotas, monto) { }

        public virtual void determinarTazaDeInteres()
        {
            int sueldoenPorcentaje = this.verificarPorcentajeDeSueldo(); // 150 %

            if (sueldoenPorcentaje <= this.Montosolicitado)
            {

                this.TazaDeInteres = (Montosolicitado / 10) / 2 ; //determina el 5 %  de interes
            }
        }

    }
}

