using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solicitud_de_creditos
{
    class CreditoPremiun : Credito
    {
        private ClientePremiun cliePrem;

        public CreditoPremiun(ClientePremiun clientePremiun, int cuotas, int monto) : base(cuotas, monto)
        {
            this.cliePrem = clientePremiun;
        }

        public override void mostrarCredito()
        {
            Console.WriteLine("YO SOY CREDITO PREMIUN");
        }

        public override Cliente getCliente()
        {
            return this.cliePrem;
        }
    }
}
