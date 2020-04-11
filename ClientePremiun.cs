using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solicitud_de_creditos
{
    class ClientePremiun : Cliente
    {
        public ClientePremiun(string nombre, string apellido, Sueldo sueldo) : base(nombre, apellido, sueldo)
        {
        }

        public override void mostrar()
        {

            Console.WriteLine("YO SOY CLIENTE PREMIUN");
        }

        
    }
}
