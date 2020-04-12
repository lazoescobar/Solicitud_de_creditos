using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solicitud_de_creditos
{
    class Sueldo {

        private int Monto;

        public Sueldo() { }

        public Sueldo ( int monto ) {

            this.Monto = monto;
        }

        public void setMonto( int monto ) {

            this.Monto = monto;
        }

        public int getMonto() {

            return this.Monto;
        }
  
    }

}
