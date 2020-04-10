using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solicitud_de_creditos
{
    class Sueldo
    {
        private String Monto;

        public Sueldo() { }

        public Sueldo ( string monto ) {

            this.Monto = monto;
        }

        public void setMonto( String monto ) {

            this.Monto = monto;
        }

        public String getMonto() {

            return this.Monto;
        }

        
    }
}
